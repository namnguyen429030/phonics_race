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
    public class SettingDataManage : IDataManage<PlayerSoundSettings>
    {
        public PlayerSoundSettings Load()
        {
            string destination = Application.persistentDataPath + FileLocation.DATAFOLDER;
            if (Directory.Exists(destination))
            {
                destination += FileLocation.SETTINGSDATAFILE;
                string jsonData = File.ReadAllText(destination);
                return JsonUtility.FromJson<PlayerSoundSettings>(jsonData);
            }
            return new PlayerSoundSettings(1,1,1,1);
        }

        public void Save(PlayerSoundSettings data)
        {
            Debug.Log("saved");
            string settingsData = JsonUtility.ToJson(data);
            string path = Application.persistentDataPath + FileLocation.DATAFOLDER;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path += FileLocation.SETTINGSDATAFILE;
            File.WriteAllText(path, settingsData);
        }
    }
}
