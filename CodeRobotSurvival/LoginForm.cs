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
    public partial class LoginForm : Form
    {
        private Authorization.AuthController auth = new Authorization.AuthController();
        public static LoginForm MyForm { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
            MyForm = this;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            auth.GetAuth();
            auth.Auth.Login(tbName.Text, tbPassword.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;

            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.FlatStyle = FlatStyle.Flat;

            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatStyle = FlatStyle.Flat;
        }
    }
}
