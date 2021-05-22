using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CodeRobotSurvival.Authorization
{
    public class AuthService
    {
        public List<Auth> users = new List<Auth>();
        [JsonIgnore]
        private Auth current_user;
        public void Registration(string name, string password)
        {
            if (name == String.Empty && name.Count() < 3)
            {
                RegistrationForm.MessageShow("Register name error.", "Info", MessageBoxButtons.OK);
                return;
            }
            if (password == String.Empty && password.Count() < 8)
            {
                RegistrationForm.MessageShow("Register password error.", "Info", MessageBoxButtons.OK);
                return;
            }
            foreach (Auth user in users)
            {
                if (name == user.Name)
                {
                    RegistrationForm.MessageShow("This name already exists.", "Info", MessageBoxButtons.OK);
                    return;
                }
            }
            users.Add(new Auth(name, password));
        }
        public void Login(string name, string password)
        {
            if (name == String.Empty && name.Count() < 3)
            {
                RegistrationForm.MessageShow("Register name error.", "Info", MessageBoxButtons.OK);
                return;
            }
            if (password == String.Empty && password.Count() < 8)
            {
                RegistrationForm.MessageShow("Register password error.", "Info", MessageBoxButtons.OK);
                return;
            }
            foreach (Auth user in users)
            {
                if (name == user.Name)
                {
                    if (user.Password == password)
                    {
                        current_user = new Auth();
                        current_user = user;
                        RegistrationForm.MessageShow("Successful auth.", "Info", MessageBoxButtons.OK);
                        RegistrationForm.MyForm.Close();
                        LoginForm.MyForm.Close();
                        Launcher.MyForm.Visible = false;
                        GameMenu gameMenu = new GameMenu();
                        gameMenu.Show();
                        return;
                    }
                    else
                    {
                        RegistrationForm.MessageShow("Uncorrect password.", "Info", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            RegistrationForm.MessageShow("There is no user like you try to enter. Please check registration form.", "Info", MessageBoxButtons.OK);
        }
    }
}
