namespace RtspViewer
{
    partial class UI
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.focusFar = new System.Windows.Forms.Button();
            this.focusNear = new System.Windows.Forms.Button();
            this.fps = new System.Windows.Forms.Label();
            this.playpause = new System.Windows.Forms.Button();
            this.zoomIn = new System.Windows.Forms.Button();
            this.focusOnepush = new System.Windows.Forms.Button();
            this.zoomOut = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.video = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.video)).BeginInit();
            this.SuspendLayout();
            // 
            // focusFar
            // 
            this.focusFar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.focusFar.Location = new System.Drawing.Point(1220, 593);
            this.focusFar.Name = "focusFar";
            this.focusFar.Size = new System.Drawing.Size(64, 64);
            this.focusFar.TabIndex = 5;
            this.focusFar.Text = "-";
            this.focusFar.UseVisualStyleBackColor = true;
            this.focusFar.Click += new System.EventHandler(this.focusFar_Click);
            // 
            // focusNear
            // 
            this.focusNear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.focusNear.Location = new System.Drawing.Point(1086, 593);
            this.focusNear.Name = "focusNear";
            this.focusNear.Size = new System.Drawing.Size(64, 64);
            this.focusNear.TabIndex = 6;
            this.focusNear.Text = "+";
            this.focusNear.UseVisualStyleBackColor = true;
            this.focusNear.Click += new System.EventHandler(this.focusNear_Click);
            // 
            // fps
            // 
            this.fps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fps.AutoSize = true;
            this.fps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fps.Location = new System.Drawing.Point(1190, 5);
            this.fps.Name = "fps";
            this.fps.Size = new System.Drawing.Size(93, 24);
            this.fps.TabIndex = 7;
            this.fps.Text = "25.00 fps";
            this.fps.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // playpause
            // 
            this.playpause.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playpause.BackgroundImage = global::RtspViewer.Properties.Resources.play;
            this.playpause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playpause.Location = new System.Drawing.Point(4, 4);
            this.playpause.Name = "playpause";
            this.playpause.Size = new System.Drawing.Size(64, 64);
            this.playpause.TabIndex = 8;
            this.playpause.UseVisualStyleBackColor = false;
            // 
            // zoomIn
            // 
            this.zoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomIn.AutoSize = true;
            this.zoomIn.BackgroundImage = global::RtspViewer.Properties.Resources.zoomcloser;
            this.zoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zoomIn.Location = new System.Drawing.Point(1153, 525);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(64, 64);
            this.zoomIn.TabIndex = 4;
            this.zoomIn.UseVisualStyleBackColor = true;
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            // 
            // focusOnepush
            // 
            this.focusOnepush.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.focusOnepush.BackgroundImage = global::RtspViewer.Properties.Resources.autofocus;
            this.focusOnepush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.focusOnepush.Location = new System.Drawing.Point(1153, 593);
            this.focusOnepush.Name = "focusOnepush";
            this.focusOnepush.Size = new System.Drawing.Size(64, 64);
            this.focusOnepush.TabIndex = 3;
            this.focusOnepush.UseVisualStyleBackColor = true;
            this.focusOnepush.Click += new System.EventHandler(this.focusOnepush_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomOut.BackgroundImage = global::RtspViewer.Properties.Resources.zoomfurther;
            this.zoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zoomOut.Location = new System.Drawing.Point(1153, 660);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(64, 64);
            this.zoomOut.TabIndex = 2;
            this.zoomOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.zoomOut.UseVisualStyleBackColor = true;
            this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menu.BackgroundImage = global::RtspViewer.Properties.Resources.menu;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menu.Location = new System.Drawing.Point(4, 660);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(64, 64);
            this.menu.TabIndex = 1;
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // video
            // 
            this.video.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.video.Location = new System.Drawing.Point(4, 4);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(1280, 720);
            this.video.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.video.TabIndex = 0;
            this.video.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(322, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1288, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playpause);
            this.Controls.Add(this.fps);
            this.Controls.Add(this.focusNear);
            this.Controls.Add(this.focusFar);
            this.Controls.Add(this.zoomIn);
            this.Controls.Add(this.focusOnepush);
            this.Controls.Add(this.zoomOut);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.video);
            this.MinimumSize = new System.Drawing.Size(1304, 764);
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RtspViewer";
            ((System.ComponentModel.ISupportInitialize)(this.video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox video;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button zoomOut;
        private System.Windows.Forms.Button focusOnepush;
        private System.Windows.Forms.Button zoomIn;
        private System.Windows.Forms.Button focusFar;
        private System.Windows.Forms.Button focusNear;
        private System.Windows.Forms.Label fps;
        private System.Windows.Forms.Button playpause;
        private System.Windows.Forms.Label label1;
    }
}

