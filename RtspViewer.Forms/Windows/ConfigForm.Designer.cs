namespace RtspViewer.Forms.Windows
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsernane = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.streamConfigurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkIPAddressCamera = new System.Windows.Forms.CheckBox();
            this.textIPAddress = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.streamConfigurationBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.Location = new System.Drawing.Point(109, 41);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.MaxLength = 128;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(160, 26);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Phobos+1";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUsername.Location = new System.Drawing.Point(108, 8);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsername.MaxLength = 128;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(160, 26);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "admin";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(13, 43);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsernane
            // 
            this.lblUsernane.AutoSize = true;
            this.lblUsernane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsernane.Location = new System.Drawing.Point(8, 11);
            this.lblUsernane.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsernane.Name = "lblUsernane";
            this.lblUsernane.Size = new System.Drawing.Size(96, 20);
            this.lblUsernane.TabIndex = 1;
            this.lblUsernane.Text = "Username:";
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(163, 139);
            this.lblError.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblError.Size = new System.Drawing.Size(245, 35);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Default error message";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblError.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(12, 133);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(417, 133);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 46);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Connect...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.Location = new System.Drawing.Point(155, 97);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddress.MaxLength = 1024;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(402, 26);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddress.Location = new System.Drawing.Point(8, 100);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(142, 20);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Source Address:";
            // 
            // streamConfigurationBindingSource
            // 
            this.streamConfigurationBindingSource.DataSource = typeof(RtspViewer.Configuration.StreamConfiguration);
            // 
            // checkIPAddressCamera
            // 
            this.checkIPAddressCamera.AutoSize = true;
            this.checkIPAddressCamera.Checked = true;
            this.checkIPAddressCamera.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIPAddressCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkIPAddressCamera.Location = new System.Drawing.Point(11, 10);
            this.checkIPAddressCamera.Margin = new System.Windows.Forms.Padding(5);
            this.checkIPAddressCamera.Name = "checkIPAddressCamera";
            this.checkIPAddressCamera.Size = new System.Drawing.Size(230, 24);
            this.checkIPAddressCamera.TabIndex = 12;
            this.checkIPAddressCamera.Text = "IP address of the camera";
            this.checkIPAddressCamera.UseVisualStyleBackColor = true;
            this.checkIPAddressCamera.CheckedChanged += new System.EventHandler(this.checkIPAddressCamera_CheckedChanged);
            // 
            // textIPAddress
            // 
            this.textIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textIPAddress.Location = new System.Drawing.Point(12, 41);
            this.textIPAddress.Margin = new System.Windows.Forms.Padding(5);
            this.textIPAddress.MaxLength = 128;
            this.textIPAddress.Name = "textIPAddress";
            this.textIPAddress.Size = new System.Drawing.Size(229, 26);
            this.textIPAddress.TabIndex = 12;
            this.textIPAddress.Text = "192.168.88.21";
            this.textIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textIPAddress.TextChanged += new System.EventHandler(this.textIPAddress_TextChanged);
            this.textIPAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textIPAddress_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.checkIPAddressCamera);
            this.panel3.Controls.Add(this.textIPAddress);
            this.panel3.Location = new System.Drawing.Point(304, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 77);
            this.panel3.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUsernane);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 77);
            this.panel1.TabIndex = 0;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 190);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblAddress);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(585, 225);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(585, 225);
            this.Name = "ConfigForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stream Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.streamConfigurationBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsernane;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.BindingSource streamConfigurationBindingSource;
        private System.Windows.Forms.CheckBox checkIPAddressCamera;
        private System.Windows.Forms.TextBox textIPAddress;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}