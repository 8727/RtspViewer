using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RtspViewer.Configuration;

namespace RtspViewer.Forms.Windows
{
    public partial class ConfigForm : Form
    {
        const string RtspPrefix = "rtsp://";

        public event EventHandler<StreamConfiguration> ConfigurationUpdated;

        public ConfigForm()
        {
            InitializeComponent();
        }

        public void InitialiseFields(StreamConfiguration config)
        {
            if (config != null)
            {
                txtAddress.Text = config.Address;
                textIPAddress.Text = config.IPAddress;
                txtUsername.Text = config.Username;
                txtPassword.Text = config.Password;
            }
        }

        void textIPAddressTotxtAddress()
        {
            lblError.Visible = true;
            Regex regex = new Regex("^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            if (regex.IsMatch(textIPAddress.Text))
            {
                lblError.Visible = false;
                txtAddress.Text = $"{RtspPrefix}{textIPAddress.Text}:554/trackID=1";
            }
            else
            {
                lblError.Text = "Invalid IP Address";
            }
        }

        void txtAddressTotextIPAddress()
        {
            lblError.Visible = true;
            Match match = Regex.Match(txtAddress.Text.ToString(), @"\b((([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])(\.)){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]))\b");
            if (match.Success)
            {
                lblError.Visible = false;
                textIPAddress.Text = match.Value;
            }
            else
            {
                lblError.Text = "Invalid IP Address";
            }
        }

        void ConfigForm_Load(object sender, EventArgs e)
        {
            if (checkIPAddressCamera.Checked)
            {
                txtAddress.Enabled = false;
            }

            if (textIPAddress.Text != "")
            {
                textIPAddressTotxtAddress();
            }
            else
            {
                txtAddressTotextIPAddress();
            }
        }

        void checkIPAddressCamera_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIPAddressCamera.Checked)
            {
                txtAddress.Enabled = false;
                textIPAddress.Enabled = true;
                textIPAddressTotxtAddress();
            }
            else
            {
                textIPAddress.Enabled = false;
                txtAddress.Enabled = true;
                txtAddressTotextIPAddress();
            }
        }

        void textIPAddress_TextChanged(object sender, EventArgs e)
        {
            if (checkIPAddressCamera.Checked)
            {
                textIPAddressTotxtAddress();
            }
        }

        void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (!checkIPAddressCamera.Checked)
            {
                txtAddressTotextIPAddress();
            }
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void saveConfigPlay()
        {
            string streamAddress = txtAddress.Text;

            if (!streamAddress.StartsWith(RtspPrefix))
            {
                streamAddress = RtspPrefix + streamAddress;
            }

            Match match = Regex.Match(streamAddress, @"rtsp:\/\/\b((([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])(\.)){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]))\b");
            if (!match.Success)
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Source Address";
                return;
            }

            lblError.Visible = false;
            ConfigurationUpdated(this, new StreamConfiguration
            {
                Address = streamAddress,
                IPAddress = textIPAddress.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
            });

            Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            saveConfigPlay();
        }

        void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                saveConfigPlay();
        }

        void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                saveConfigPlay();
        }

        void textIPAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                saveConfigPlay();
        }

        void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                saveConfigPlay();
        }
    }
}
