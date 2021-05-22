using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRobotSurvival
{
    public class Auth
    {
        private string name;
        private string password;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Password
        {
            get => password;
            set => password = value;
        }
        public Auth(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public Auth() : this("Noname", "Nopassword") { }
    }
}
