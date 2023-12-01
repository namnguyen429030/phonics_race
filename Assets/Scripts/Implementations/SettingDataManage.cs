using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Implementations
{
    public class SettingDataManage : IDataManage<PlayerSettings>
    {
        public PlayerSettings Load()
        {
            string destination = Application.persistentDataPath + FileLocation.DATAFOLDER + FileLocation.SETTINGSDATAFILE;
            if (Directory.Exists(destination))
            {
                string jsonData = File.ReadAllText(destination);
                return JsonUtility.FromJson<PlayerSettings>(jsonData);
            }
            return new PlayerSettings();
        }

        public void Save(PlayerSettings data)
        {
            string settingsData = JsonUtility.ToJson(data);
            string path = Application.persistentDataPath + "/SaveData";
            if (!Directory.Exists(FileLocation.DATAFOLDER))
            {
                Directory.CreateDirectory(FileLocation.DATAFOLDER);
            }
            File.WriteAllText(path + FileLocation.PLAYERDATAFILE, settingsData);
        }
    }
}
