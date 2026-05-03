using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class frmMediaPlayer : Form
    {
        // 1. 新增一個變數，用來記錄使用者選擇的速度
        private double _selectedSpeed = 1.0;

        public frmMediaPlayer()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "WMV files (*.wmv)|*.wmv|MP4 files (*.mp4)|*.mp4|AVI files (*.avi)|*.avi|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                wmpVideo.settings.autoStart = false;
                wmpVideo.URL = ofd.FileName;

                // 載入影片後，可以選速度
                btnFastForward.Enabled = true;
                btnNormalSpeed.Enabled = true;
                btnSlowMotion.Enabled = true;

                // 還沒選速度，所以播放不能按
                btnPlay.Enabled = false;

                // 還沒播放，所以暫停和停止都不能按
                btnPause.Enabled = false;
                btnStop.Enabled = false;

            }
        }

        // --- 速度選擇按鈕事件 ---
        private void btnFastForward_Click(object sender, EventArgs e)
        {
            _selectedSpeed = 2.0;
            EnablePlayButton();
        }

        private void btnNormalSpeed_Click(object sender, EventArgs e)
        {
            _selectedSpeed = 1.0;
            EnablePlayButton();
        }

        private void btnSlowMotion_Click(object sender, EventArgs e)
        {
            _selectedSpeed = 0.5;
            EnablePlayButton();
        }

        // 用來把播放按鈕打開的共用方法
        private void EnablePlayButton()
        {
            btnPlay.Enabled = true;
        }

        // --- 播放按鈕事件 ---
        private void btnPlay_Click(object sender, EventArgs e)
        {
            wmpVideo.settings.rate = _selectedSpeed;
            wmpVideo.Ctlcontrols.play();

            // 播放中不能再選速度
            btnPlay.Enabled = false;
            btnFastForward.Enabled = false;
            btnNormalSpeed.Enabled = false;
            btnSlowMotion.Enabled = false;

            // 播放中可以暫停、停止
            btnPause.Enabled = true;
            btnStop.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.pause();

            // 暫停後可以再按播放繼續
            btnPlay.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = true;

            // 暫停時先不讓改速度，避免邏輯混亂
            btnFastForward.Enabled = false;
            btnNormalSpeed.Enabled = false;
            btnSlowMotion.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop();

            // 停止後，讓使用者重新選擇速度
            btnFastForward.Enabled = true;
            btnNormalSpeed.Enabled = true;
            btnSlowMotion.Enabled = true;

            // 重新選速度前，播放鍵先關掉
            btnPlay.Enabled = false;

            // 停止後不能暫停、停止
            btnPause.Enabled = false;
            btnStop.Enabled = false;
        }
    }
}
