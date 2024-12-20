using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Threading;
using RtspViewer.Configuration;
using RtspViewer.RawFramesDecoding;
using RtspViewer.RawFramesDecoding.DecodedFrames;
using RtspViewer.RawFramesReceiving;

namespace RtspViewer.Forms.Controls
{
    public partial class VideoView : UserControl
    {
        private IRawFramesSource _rawFramesSource;
        private IAudioSource _audioSource;
        private IVideoSource _videoSource;

        private Dispatcher _dispatcher;
        private Bitmap _bitmap;
        private TransformParameters _transformParameters;
        private DateTime _startTime;

        public string ConnectionStatus { get; private set; } = "Disconnected";

        public long FramesReceived { get; private set; }

        public bool Started { get; private set; }

        public TimeSpan TimeElapsed
        {
            get 
            {
                if (Started)
                {
                    return DateTime.UtcNow - _startTime;
                }

                return TimeSpan.Zero;
            }
        }

        public VideoView()
        {
            InitializeComponent();
            _dispatcher = Dispatcher.CurrentDispatcher;
        }

        ~VideoView() 
        {
            Stop();
        }

        public void InitialiseStream(StreamConfiguration config)
        {
            Stop();

            _rawFramesSource = new RawFramesSource(config);
            _audioSource = new RealtimeAudioSource(_rawFramesSource);
            _videoSource = new RealtimeVideoSource(_rawFramesSource);  
        }

        public void Start()
        {
            if (!Started && _rawFramesSource != null)
            {
                Started = true;
                _rawFramesSource.ConnectionStatusChanged += RawFramesSource_OnConnectionStatusChanged;
                _audioSource.FrameReceived += AudioSource_FrameReceived;
                _videoSource.FrameReceived += VideoSource_FrameReceived;

                _bitmap = new Bitmap(Width, Height);
                _transformParameters = _bitmap.GetTransformParameters();

                _rawFramesSource.Start();
                _startTime = DateTime.UtcNow;
            }
        }

        public void Stop()
        {
            if (Started && _rawFramesSource != null)
            {
                Started = false;
                _rawFramesSource.Stop();

                _rawFramesSource.ConnectionStatusChanged -= RawFramesSource_OnConnectionStatusChanged;
                _audioSource.FrameReceived -= AudioSource_FrameReceived;
                _videoSource.FrameReceived -= VideoSource_FrameReceived;

                ConnectionStatus = "Disconnected";
                FramesReceived = 0;
            }
        }

        private void ReinitializeBitmap(int width, int height)
        {
            if (Started)
            {
                // Allow the next frame to size correctly
                _bitmap = new Bitmap(width, height);
                _transformParameters = _bitmap.GetTransformParameters();
            }
            else if (_bitmap != null)
            {
                // Resize the current frame
                _dispatcher.Invoke(() =>
                {
                    Bitmap resized = new Bitmap(width, height);
                    using (Graphics g = Graphics.FromImage(resized))
                    {
                        g.DrawImage(_bitmap, 0, 0, width, height);
                    }

                    video.Image = resized;
                }, DispatcherPriority.Send);
            }
        }

        private void RawFramesSource_OnConnectionStatusChanged(object sender, string status)
        {
            ConnectionStatus = status;
        }

        private void AudioSource_FrameReceived(object sender, IDecodedAudioFrame frame)
        {

        }

        private void VideoSource_FrameReceived(object sender, IDecodedVideoFrame frame)
        {
            FramesReceived++;

            _dispatcher.Invoke(() =>
            {
                _bitmap.UpdateBitmap(frame, _transformParameters);
                video.Image = _bitmap;
            }, DispatcherPriority.Send);
        }

        //private void Video_SizeChanged(object sender, EventArgs e)
        //{
        //    _dispatcher.Invoke(() => ReinitializeBitmap(Width, Height), DispatcherPriority.Send);
        //}
    }
}
