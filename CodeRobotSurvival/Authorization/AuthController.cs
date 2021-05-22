using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRobotSurvival.Authorization
{
    public class AuthController
    {
        private AuthService auth = new AuthService();
        public AuthService Auth
        {
            get => auth;
        }
        public void GetAuth()
        {
            AuthFileSave loader = new AuthFileSave();
            auth = loader.Load(auth);
        }
        public void SaveAuth()
        {
            AuthFileSave saver = new AuthFileSave();
            saver.Save(auth);
        }
    }
}
