using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CodeRobotSurvival.Moving
{
    public class RotateFileSave
    {
        public void Save(Rotate rotate)
        {
            string jsonStr = System.Text.Json.JsonSerializer.Serialize<Rotate>(rotate);
            File.WriteAllText(Rotate.fileName, jsonStr);
        }
        public Rotate Load()
        {
            if (File.Exists(Rotate.fileName))
            {
                string json_ = File.ReadAllText(Rotate.fileName);
                Rotate result = new Rotate();
                result = JsonConvert.DeserializeObject<Rotate>(json_);
                return result;
            }
            else
            {
                RegistrationForm.MessageShow("Rotate.json isn't exist.", "Info", MessageBoxButtons.OK);
                return null;
            }
        }
    }
}
