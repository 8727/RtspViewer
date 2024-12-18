using System;
using System.IO;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using RtspViewer.Configuration;

namespace RtspViewer
{
    public partial class UI : Form
    {
        private const string ConfigurationFilename = "config.json.enc";
        private SettingForm _configForm;

        private StreamConfiguration _config = null;
        public UI()
        {
            InitializeComponent();
        }

        public async void GetHTTP(string url, string username, string password)
        {
            Uri myUri = new Uri(url);
            NetworkCredential myNetworkCredential = new NetworkCredential(username, password);
            CredentialCache myCredentialCache = new CredentialCache { { myUri, "Digest", myNetworkCredential } };
            var request = new HttpClient(new HttpClientHandler() { Credentials = myCredentialCache, PreAuthenticate = true });
            var response = await request.GetAsync(url);
            var responseStream = await response.Content.ReadAsStreamAsync();
            StreamReader responseStreamReader = new StreamReader(responseStream, Encoding.Default);
            string answer = await responseStreamReader.ReadToEndAsync();
            label1.Text = answer;
        }
        private void SettingForm_ConfigurationUpdated(object sender, StreamConfiguration config)
        {
            _config = config;
            //videoView.InitialiseStream(_config);
            StreamConfiguration.Save(ConfigurationFilename, _config);

            if (string.IsNullOrWhiteSpace(_config.Address))
            {
                //videoView.Stop();
                //menuBtnPlay.Enabled = false;
            }
            else
            {
                //videoView.Start();
                //menuBtnPlay.Enabled = true;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            if (StreamConfiguration.TryLoad(ConfigurationFilename, out _config))
            {
                //videoView.InitialiseStream(_config);
                //menuBtnPlay.Enabled = true;
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            _configForm = new SettingForm();
            _configForm.InitialiseFields(_config);
            _configForm.ConfigurationUpdated += SettingForm_ConfigurationUpdated;
            _configForm.FormClosing += (object _s, FormClosingEventArgs _e) =>
            {
                _configForm.ConfigurationUpdated += SettingForm_ConfigurationUpdated;
            };
            _configForm.Show();
        }

        private void focusNear_Click(object sender, EventArgs e)
        {
            GetHTTP("http://192.168.1.170/cgi-bin/webSetup.cgi?action=ptzCommand&mode=0&command=focusNear&step=1&speed=1", "admin", "Phobos+1");
        }

        private void focusOnepush_Click(object sender, EventArgs e)
        {
            GetHTTP("http://192.168.1.170/cgi-bin/webSetup.cgi?action=ptzCommand&mode=0&command=focusOnepush&step=0&speed=1", "admin", "Phobos+1");
        }

        private void focusFar_Click(object sender, EventArgs e)
        {
            GetHTTP("http://192.168.1.170/cgi-bin/webSetup.cgi?action=ptzCommand&mode=0&command=focusFar&step=1&speed=1", "admin", "Phobos+1");
        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            GetHTTP("http://192.168.1.170/cgi-bin/webSetup.cgi?action=ptzCommand&mode=0&command=zoomIn&step=1&speed=1", "admin", "Phobos+1");
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            GetHTTP("http://192.168.1.170/cgi-bin/webSetup.cgi?action=ptzCommand&mode=0&command=zoomOut&step=1&speed=1", "admin", "Phobos+1");
        }





    }
}
