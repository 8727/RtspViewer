using System;
using System.IO;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Windows.Forms;
using RtspViewer.Configuration;

namespace RtspViewer.Forms.Windows
{
    public partial class MainForm : Form
    {
        ConfigForm _configForm;

        StreamConfiguration _config = null;

        public MainForm()
        {
            InitializeComponent();
        }

        void ConfigForm_ConfigurationUpdated(object sender, StreamConfiguration config)
        {
            _config = config;
            videoView.InitialiseStream(_config);

            if (string.IsNullOrWhiteSpace(_config.Address))
            {
                videoView.Stop();
            }
            else
            {
                videoView.Start();
            }
            ControlStatus();
        }

        void MainForm_Load(object sender, EventArgs e)
        {

        }

        void Timer_Tick(object sender, EventArgs e)
        {
            var timeElapsed = videoView.TimeElapsed;
            var framesReceived = videoView.FramesReceived;

            var receivedFps = CalculateFps(framesReceived, timeElapsed);

            statusLblConnection.Text = videoView.ConnectionStatus;
            statusLblTimer.Text = $"{timeElapsed:hh}:{timeElapsed:mm}:{timeElapsed:ss}";
            statusLblFps.Text = $"{receivedFps:F2} fps";
        }

        static double CalculateFps(double frames, TimeSpan elapsed)
        {
            if (frames > 0)
            {
                return 1000d * frames / elapsed.TotalMilliseconds;
            }

            return 0d;
        }

        void MenuViver()
        {
            if (Application.OpenForms["ConfigForm"] == null)
            {
                _configForm = new ConfigForm();
                _configForm.InitialiseFields(_config);
                _configForm.ConfigurationUpdated += ConfigForm_ConfigurationUpdated;
                _configForm.FormClosing += (object _s, FormClosingEventArgs _e) =>
                {
                    _configForm.ConfigurationUpdated += ConfigForm_ConfigurationUpdated;
                };
                _configForm.Show();
            }
        }

        void menu_Click(object sender, EventArgs e)
        {
            MenuViver();    
        }

        void ControlStatus()
        {
            if (!videoView.Started)
            {
                playpause.BackgroundImage = Properties.Resources.play;
                videoView.BringToFront();
                playpause.BringToFront();
                menu.BringToFront();
            }
            else
            {
                playpause.BackgroundImage = Properties.Resources.pause;
                videoView.BringToFront();
                playpause.BringToFront();
                menu.BringToFront();
                focusNear.BringToFront();
                focusOnepush.BringToFront();
                focusFar.BringToFront();
                zoomIn.BringToFront();
                zoomOut.BringToFront();
            }
        }

        void playpause_Click(object sender, EventArgs e)
        {
            if(_config == null)
            {
                MenuViver();
            }
            else
            {
                if (videoView.Started)
                {
                    videoView.Stop();
                }
                else
                {
                    videoView.Start();
                }
            }
            ControlStatus();
        }

        async void GetHTTP(string url, string username, string password)
        {
            Uri myUri = new Uri(url);
            NetworkCredential myNetworkCredential = new NetworkCredential(username, password);
            CredentialCache myCredentialCache = new CredentialCache { { myUri, "Digest", myNetworkCredential } };
            var request = new HttpClient(new HttpClientHandler() { Credentials = myCredentialCache, PreAuthenticate = true });
            var response = await request.GetAsync(url);
            var responseStream = await response.Content.ReadAsStreamAsync();
            StreamReader responseStreamReader = new StreamReader(responseStream, Encoding.Default);
            _ = await responseStreamReader.ReadToEndAsync();
        }

        void SetPtzCommand(string command)
        {
            string request;

            switch (command)
            {
                case "focusNear":
                    request = "focusNear&step=1&speed=1";
                    break;
                case "focusOnepush":
                    request = "focusOnepush&step=0&speed=1";
                    break;
                case "focusFar":
                    request = "focusFar&step=1&speed=1";
                    break;
                case "zoomIn":
                    request = "zoomIn&step=1&speed=1";
                    break;
                case "zoomOut":
                    request = "zoomOut&step=1&speed=1";
                    break;
                case "focusNearDown":
                    request = "focusNear&step=0&speed=4";
                    break;
                case "focusFarDown":
                    request = "focusFar&step=0&speed=4";
                    break;
                case "zoomInDown":
                    request = "zoomIn&step=0&speed=4";
                    break;
                case "zoomOutDown":
                    request = "zoomOut&step=0&speed=4";
                    break;
                default:
                    request = "stop&step=0&speed=1";
                    break;
            }
            GetHTTP($"http://{_config.IPAddress}/cgi-bin/webSetup.cgi?action=ptzCommand&mode=0&command={request}", "admin", "Phobos+1");
        }

        void focusNear_Click(object sender, EventArgs e)
        {
            SetPtzCommand("focusNear");
        }

        void focusOnepush_Click(object sender, EventArgs e)
        {
            SetPtzCommand("focusOnepush");
        }

        void focusFar_Click(object sender, EventArgs e)
        {
            SetPtzCommand("focusFar");
        }

        void zoomIn_Click(object sender, EventArgs e)
        {
            SetPtzCommand("zoomIn");
        }

        void zoomOut_Click(object sender, EventArgs e)
        {
            SetPtzCommand("zoomOut");
        }

        void zoomIn_MouseDown(object sender, MouseEventArgs e)
        {
            SetPtzCommand("zoomInDown");
        }

        void zoomOut_MouseDown(object sender, MouseEventArgs e)
        {
            SetPtzCommand("zoomOutDown");
        }

        void focusNear_MouseDown(object sender, MouseEventArgs e)
        {
            SetPtzCommand("focusNearDown");
        }

        void focusFar_MouseDown(object sender, MouseEventArgs e)
        {
            SetPtzCommand("focusFarDown");
        }

        void zoomIn_MouseUp(object sender, MouseEventArgs e)
        {
            SetPtzCommand("stop");
        }

        void zoomOut_MouseUp(object sender, MouseEventArgs e)
        {
            SetPtzCommand("stop");
        }

        void focusNear_MouseUp(object sender, MouseEventArgs e)
        {
            SetPtzCommand("stop");
        }

        void focusFar_MouseUp(object sender, MouseEventArgs e)
        {
            SetPtzCommand("stop");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
