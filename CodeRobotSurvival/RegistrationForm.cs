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
    public partial class RegistrationForm : Form
    {
        private Authorization.AuthController auth = new Authorization.AuthController();
        public static RegistrationForm MyForm { get; private set; }
        public RegistrationForm()
        {
            InitializeComponent();
            MyForm = this;
        } 
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;

            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.FlatStyle = FlatStyle.Flat;

            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatStyle = FlatStyle.Flat;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public static void MessageShow(string text, string caption, MessageBoxButtons messageBoxButtons)
        {
            MessageBox.Show(text, caption, messageBoxButtons);
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == tbConfirmPassword.Text)
            {
                auth.GetAuth();
                auth.Auth.Registration(tbName.Text, tbPassword.Text);
                auth.SaveAuth();
            }
            else
            {
                MessageBox.Show("Confrim password error", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
