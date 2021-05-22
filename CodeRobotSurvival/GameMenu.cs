using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeRobotSurvival
{
    public partial class GameMenu : Form
    {
        private AudioAndMedia.BackgroundAudio backgroundAudio = new AudioAndMedia.BackgroundAudio();
        public static GameMenu MyForm { get; private set; }
        public GameMenu()
        {
            InitializeComponent();
            MyForm = this;
        }

        private void GameMenu_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            btnMusicState.Visible = false;
            tbVolume.Visible = false;
            lblVolume.Visible = false;

            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;

            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.FlatStyle = FlatStyle.Flat;

            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;

            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;

            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;

            btnStartGame.FlatAppearance.BorderSize = 0;
            btnStartGame.FlatStyle = FlatStyle.Flat;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Launcher.MyForm.Close();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            this.Close();
            CodeGame codeGame = new CodeGame();
            codeGame.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnExit.Visible = false;
            btnSettings.Visible = false;
            btnStartGame.Visible = false;

            btnBack.Visible = true;
            btnMusicState.Visible = true;
            tbVolume.Visible = true;
            lblVolume.Visible = true;

            AudioAndMedia.BackgroundAudioFileSave loader = new AudioAndMedia.BackgroundAudioFileSave();
            backgroundAudio = loader.Load(backgroundAudio);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Launcher.MyForm.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnExit.Visible = true;
            btnSettings.Visible = true;
            btnStartGame.Visible = true;

            btnBack.Visible = false;
            btnMusicState.Visible = false;
            tbVolume.Visible = false;
            lblVolume.Visible = false;

            AudioAndMedia.BackgroundAudioFileSave saver = new AudioAndMedia.BackgroundAudioFileSave();
            saver.Save(backgroundAudio);
        }

        private void btnMusicState_Click(object sender, EventArgs e)
        {
            if (backgroundAudio.SettingAudio)
            {
                btnMusicState.Text = "Turn on music : false";
            }
            else
            {
                btnMusicState.Text = "Turn on music : true";
            }
        }

        private void tbVolume_ValueChanged(object sender, EventArgs e)
        {
            backgroundAudio.Volume = tbVolume.Value;
        }
    }
}
