using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace CodeRobotSurvival.Authorization
{
    public class AuthFileSave
    {
        private const string fileName = @"../../../JsonSaves/Users.json";
        public void Save(AuthService authService)
        {
            string jsonStr = System.Text.Json.JsonSerializer.Serialize<List<Auth>>(authService.users);
            File.WriteAllText(fileName, jsonStr);
        }
        public AuthService Load(AuthService authService)
        {
            if (File.Exists(fileName))
            {
                string json_ = File.ReadAllText(fileName);
                AuthService result = new AuthService();
                result.users = JsonConvert.DeserializeObject<List<Auth>>(json_); 
                return result;   
            }
            else
            {
                RegistrationForm.MessageShow("Users.json isn't exist.", "Info", MessageBoxButtons.OK);
                return null;
            }
        }
    }
}
