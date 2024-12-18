using RtspViewer.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RtspViewer
{
    public partial class SettingForm : Form
    {
        private const string RtspPrefix = "rtsp://";
        private const string HttpPrefix = "http://";

        public event EventHandler<StreamConfiguration> ConfigurationUpdated;

        public SettingForm()
        {
            InitializeComponent();
        }

        public void InitialiseFields(StreamConfiguration config)
        {
            if (config != null)
            {
                txtAddress.Text = config.Address;
                txtUsername.Text = config.Username;
                txtPassword.Text = config.Password;
                cbxProtocol.SelectedItem = config.Protocol.ToString();
            }
            else
            {
                cbxProtocol.SelectedItem = "TCP";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string streamAddress = txtAddress.Text;

            if (!streamAddress.StartsWith(RtspPrefix) && !streamAddress.StartsWith(HttpPrefix))
            {
                streamAddress = RtspPrefix + streamAddress;
            }

            if (!Uri.TryCreate(streamAddress, UriKind.Absolute, out Uri deviceUri))
            {
                lblError.Text = "Invalid device address";
                lblError.Visible = true;
                return;
            }

            lblError.Visible = false;
            ConfigurationUpdated(this, new StreamConfiguration
            {
                Address = streamAddress,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Protocol = (ConnectionType)cbxProtocol.SelectedIndex
            });

            Close();
        }
    }
}
