using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CodeRobotSurvival.AudioAndMedia
{
    public class BackgroundAudio
    {
        private bool settingAudio;
        private int volume;
        [JsonIgnore]
        public const string JsonPathSave = "../../../JsonSaves/BackgroundAudio.json";
        public bool SettingAudio
        {
            get => settingAudio;
            set => settingAudio = value;
        }
        public int Volume
        {
            get => volume;
            set => volume = value;
        }
        public BackgroundAudio(bool settingAudio, int volume)
        {
            SettingAudio = settingAudio;
            Volume = volume;
        }
        public BackgroundAudio(bool settingAudio)
        {
            SettingAudio = settingAudio;
        }
        public BackgroundAudio(int volume)
        {
            Volume = volume;
        }
        public BackgroundAudio() : this(false, 0) { }
    }
}
