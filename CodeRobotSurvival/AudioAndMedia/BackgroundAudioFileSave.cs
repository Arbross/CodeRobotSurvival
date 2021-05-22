using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeRobotSurvival.AudioAndMedia
{
    public class BackgroundAudioFileSave
    {
        public void Save(BackgroundAudio backgroundAudio)
        {
            string jsonStr = System.Text.Json.JsonSerializer.Serialize<BackgroundAudio>(backgroundAudio);
            File.WriteAllText(BackgroundAudio.JsonPathSave, jsonStr);
        }
        public BackgroundAudio Load(BackgroundAudio backgroundAudio)
        {
            if (File.Exists(BackgroundAudio.JsonPathSave))
            {
                string json_ = File.ReadAllText(BackgroundAudio.JsonPathSave);
                BackgroundAudio result = new BackgroundAudio();
                result = JsonConvert.DeserializeObject<BackgroundAudio>(json_);
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
