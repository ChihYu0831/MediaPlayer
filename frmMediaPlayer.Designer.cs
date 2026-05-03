namespace MediaPlayer
{
    partial class frmMediaPlayer
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMediaPlayer));
            this.palButton = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnFastForward = new System.Windows.Forms.Button();
            this.btnSlowMotion = new System.Windows.Forms.Button();
            this.grpAdjustSpeed = new System.Windows.Forms.GroupBox();
            this.btnNormalSpeed = new System.Windows.Forms.Button();
            this.palButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.grpAdjustSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // palButton
            // 
            this.palButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.palButton.Controls.Add(this.grpAdjustSpeed);
            this.palButton.Controls.Add(this.btnStop);
            this.palButton.Controls.Add(this.btnPause);
            this.palButton.Controls.Add(this.btnPlay);
            this.palButton.Controls.Add(this.btnBrowser);
            this.palButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.palButton.Location = new System.Drawing.Point(0, 253);
            this.palButton.Name = "palButton";
            this.palButton.Size = new System.Drawing.Size(644, 198);
            this.palButton.TabIndex = 1;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnStop.Location = new System.Drawing.Point(395, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 42);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPause.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPause.Location = new System.Drawing.Point(275, 19);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 42);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "暫停";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPlay.Location = new System.Drawing.Point(155, 19);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 42);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBrowser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBrowser.Location = new System.Drawing.Point(35, 19);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 42);
            this.btnBrowser.TabIndex = 2;
            this.btnBrowser.Text = "瀏覽";
            this.btnBrowser.UseVisualStyleBackColor = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // wmpVideo
            // 
            this.wmpVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(0, 0);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(644, 451);
            this.wmpVideo.TabIndex = 0;
            this.wmpVideo.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmpVideo_PlayStateChange);
            // 
            // btnFastForward
            // 
            this.btnFastForward.BackColor = System.Drawing.Color.Salmon;
            this.btnFastForward.Enabled = false;
            this.btnFastForward.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFastForward.ForeColor = System.Drawing.Color.Maroon;
            this.btnFastForward.Location = new System.Drawing.Point(428, 30);
            this.btnFastForward.Name = "btnFastForward";
            this.btnFastForward.Size = new System.Drawing.Size(92, 42);
            this.btnFastForward.TabIndex = 6;
            this.btnFastForward.Text = "快轉 (2x)";
            this.btnFastForward.UseVisualStyleBackColor = false;
            this.btnFastForward.Click += new System.EventHandler(this.btnFastForward_Click);
            // 
            // btnSlowMotion
            // 
            this.btnSlowMotion.BackColor = System.Drawing.SystemColors.Info;
            this.btnSlowMotion.Enabled = false;
            this.btnSlowMotion.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSlowMotion.ForeColor = System.Drawing.Color.Gold;
            this.btnSlowMotion.Location = new System.Drawing.Point(41, 30);
            this.btnSlowMotion.Name = "btnSlowMotion";
            this.btnSlowMotion.Size = new System.Drawing.Size(117, 42);
            this.btnSlowMotion.TabIndex = 7;
            this.btnSlowMotion.Text = "慢動作 (0.5x)";
            this.btnSlowMotion.UseVisualStyleBackColor = false;
            this.btnSlowMotion.Click += new System.EventHandler(this.btnSlowMotion_Click);
            // 
            // grpAdjustSpeed
            // 
            this.grpAdjustSpeed.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grpAdjustSpeed.Controls.Add(this.btnNormalSpeed);
            this.grpAdjustSpeed.Controls.Add(this.btnSlowMotion);
            this.grpAdjustSpeed.Controls.Add(this.btnFastForward);
            this.grpAdjustSpeed.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpAdjustSpeed.Location = new System.Drawing.Point(35, 82);
            this.grpAdjustSpeed.Name = "grpAdjustSpeed";
            this.grpAdjustSpeed.Size = new System.Drawing.Size(564, 90);
            this.grpAdjustSpeed.TabIndex = 8;
            this.grpAdjustSpeed.TabStop = false;
            this.grpAdjustSpeed.Text = "影片速度";
            // 
            // btnNormalSpeed
            // 
            this.btnNormalSpeed.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnNormalSpeed.Enabled = false;
            this.btnNormalSpeed.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNormalSpeed.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnNormalSpeed.Location = new System.Drawing.Point(232, 30);
            this.btnNormalSpeed.Name = "btnNormalSpeed";
            this.btnNormalSpeed.Size = new System.Drawing.Size(122, 42);
            this.btnNormalSpeed.TabIndex = 8;
            this.btnNormalSpeed.Text = "正常速度 (1x)";
            this.btnNormalSpeed.UseVisualStyleBackColor = false;
            this.btnNormalSpeed.Click += new System.EventHandler(this.btnNormalSpeed_Click);
            // 
            // frmMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 451);
            this.Controls.Add(this.palButton);
            this.Controls.Add(this.wmpVideo);
            this.Name = "frmMediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "多媒體播放器";
            this.palButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.grpAdjustSpeed.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private System.Windows.Forms.Panel palButton;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSlowMotion;
        private System.Windows.Forms.Button btnFastForward;
        private System.Windows.Forms.GroupBox grpAdjustSpeed;
        private System.Windows.Forms.Button btnNormalSpeed;
    }
}

