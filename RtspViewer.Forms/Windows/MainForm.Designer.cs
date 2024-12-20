namespace RtspViewer.Forms.Windows
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLblConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLblTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLblFps = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.focusNear = new System.Windows.Forms.Button();
            this.playpause = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.focusFar = new System.Windows.Forms.Button();
            this.zoomIn = new System.Windows.Forms.Button();
            this.focusOnepush = new System.Windows.Forms.Button();
            this.zoomOut = new System.Windows.Forms.Button();
            this.videoView = new RtspViewer.Forms.Controls.VideoView();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLblConnection,
            this.statusLblTimer,
            this.statusLblFps});
            this.statusBar.Location = new System.Drawing.Point(0, 718);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1284, 27);
            this.statusBar.TabIndex = 1;
            // 
            // statusLblConnection
            // 
            this.statusLblConnection.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLblConnection.Name = "statusLblConnection";
            this.statusLblConnection.Size = new System.Drawing.Size(423, 22);
            this.statusLblConnection.Spring = true;
            this.statusLblConnection.Text = "Disconnected";
            this.statusLblConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLblTimer
            // 
            this.statusLblTimer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLblTimer.Margin = new System.Windows.Forms.Padding(2, 3, 0, 2);
            this.statusLblTimer.Name = "statusLblTimer";
            this.statusLblTimer.Size = new System.Drawing.Size(421, 22);
            this.statusLblTimer.Spring = true;
            this.statusLblTimer.Text = "00:00:00";
            // 
            // statusLblFps
            // 
            this.statusLblFps.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLblFps.Margin = new System.Windows.Forms.Padding(2, 3, 0, 2);
            this.statusLblFps.Name = "statusLblFps";
            this.statusLblFps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLblFps.Size = new System.Drawing.Size(421, 22);
            this.statusLblFps.Spring = true;
            this.statusLblFps.Text = "0 fps";
            this.statusLblFps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // focusNear
            // 
            this.focusNear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.focusNear.BackgroundImage = global::RtspViewer.Forms.Properties.Resources.focusFar;
            this.focusNear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.focusNear.Location = new System.Drawing.Point(1084, 591);
            this.focusNear.Name = "focusNear";
            this.focusNear.Size = new System.Drawing.Size(64, 64);
            this.focusNear.TabIndex = 14;
            this.focusNear.UseVisualStyleBackColor = true;
            this.focusNear.Click += new System.EventHandler(this.focusNear_Click);
            this.focusNear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.focusNear_MouseDown);
            this.focusNear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.focusNear_MouseUp);
            // 
            // playpause
            // 
            this.playpause.BackColor = System.Drawing.SystemColors.ControlLight;
            this.playpause.BackgroundImage = global::RtspViewer.Forms.Properties.Resources.play;
            this.playpause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playpause.Location = new System.Drawing.Point(2, 2);
            this.playpause.Name = "playpause";
            this.playpause.Size = new System.Drawing.Size(64, 64);
            this.playpause.TabIndex = 15;
            this.playpause.UseVisualStyleBackColor = false;
            this.playpause.Click += new System.EventHandler(this.playpause_Click);
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menu.BackgroundImage = global::RtspViewer.Forms.Properties.Resources.menu;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menu.Location = new System.Drawing.Point(2, 658);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(64, 64);
            this.menu.TabIndex = 9;
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // focusFar
            // 
            this.focusFar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.focusFar.BackgroundImage = global::RtspViewer.Forms.Properties.Resources.focusNea;
            this.focusFar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.focusFar.Location = new System.Drawing.Point(1218, 591);
            this.focusFar.Name = "focusFar";
            this.focusFar.Size = new System.Drawing.Size(64, 64);
            this.focusFar.TabIndex = 13;
            this.focusFar.UseVisualStyleBackColor = true;
            this.focusFar.Click += new System.EventHandler(this.focusFar_Click);
            this.focusFar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.focusFar_MouseDown);
            this.focusFar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.focusFar_MouseUp);
            // 
            // zoomIn
            // 
            this.zoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomIn.AutoSize = true;
            this.zoomIn.BackgroundImage = global::RtspViewer.Forms.Properties.Resources.zoomcloser;
            this.zoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zoomIn.Location = new System.Drawing.Point(1151, 523);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(64, 64);
            this.zoomIn.TabIndex = 12;
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            this.zoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zoomIn_MouseDown);
            this.zoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zoomIn_MouseUp);
            // 
            // focusOnepush
            // 
            this.focusOnepush.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.focusOnepush.BackgroundImage = global::RtspViewer.Forms.Properties.Resources.autofocus;
            this.focusOnepush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.focusOnepush.Location = new System.Drawing.Point(1151, 591);
            this.focusOnepush.Name = "focusOnepush";
            this.focusOnepush.Size = new System.Drawing.Size(64, 64);
            this.focusOnepush.TabIndex = 11;
            this.focusOnepush.UseVisualStyleBackColor = true;
            this.focusOnepush.Click += new System.EventHandler(this.focusOnepush_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomOut.BackgroundImage = global::RtspViewer.Forms.Properties.Resources.zoomfurther;
            this.zoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zoomOut.Location = new System.Drawing.Point(1151, 658);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(64, 64);
            this.zoomOut.TabIndex = 10;
            this.zoomOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
            this.zoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zoomOut_MouseDown);
            this.zoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zoomOut_MouseUp);
            // 
            // videoView
            // 
            this.videoView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoView.Location = new System.Drawing.Point(2, 2);
            this.videoView.Name = "videoView";
            this.videoView.Size = new System.Drawing.Size(1280, 720);
            this.videoView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 745);
            this.Controls.Add(this.playpause);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.videoView);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.focusNear);
            this.Controls.Add(this.focusFar);
            this.Controls.Add(this.zoomIn);
            this.Controls.Add(this.focusOnepush);
            this.Controls.Add(this.zoomOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1300, 780);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDIS RTSP Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLblConnection;
        private System.Windows.Forms.ToolStripStatusLabel statusLblTimer;
        private System.Windows.Forms.ToolStripStatusLabel statusLblFps;
        private RtspViewer.Forms.Controls.VideoView videoView;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button playpause;
        private System.Windows.Forms.Button focusNear;
        private System.Windows.Forms.Button focusFar;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button focusOnepush;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Button menu;
    }
}

