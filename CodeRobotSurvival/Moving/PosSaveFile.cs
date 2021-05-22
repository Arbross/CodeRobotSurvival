using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeRobotSurvival.Moving
{
    public class PosSaveFile
    {
        public void Save(Position position)
        {
            string jsonStr = System.Text.Json.JsonSerializer.Serialize<Position>(position);
            File.WriteAllText(Position.fileName, jsonStr);
        }
        public Position Load()
        {
            if (File.Exists(Position.fileName))
            {
                string json_ = File.ReadAllText(Position.fileName);
                Position result = JsonConvert.DeserializeObject<Position>(json_);
                return result;
            }
            else
            {
                RegistrationForm.MessageShow("Position.json isn't exist.", "Info", MessageBoxButtons.OK);
                return null;
            }
        }
    }
}
