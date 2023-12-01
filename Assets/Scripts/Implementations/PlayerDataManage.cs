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
    public class PlayerDataManage : IDataManage<PlayerData>
    {
        public PlayerData Load()
        {
            string destination = Application.persistentDataPath + FileLocation.DATAFOLDER + FileLocation.PLAYERDATAFILE;
            if (Directory.Exists(destination))
            {
                string jsonData = File.ReadAllText(destination);
                return JsonUtility.FromJson<PlayerData>(jsonData);
            }
            return new PlayerData(DateTime.Now.TimeOfDay);
        }

        public void Save(PlayerData data)
        {
            string playerData = JsonUtility.ToJson(data);
            string path = Application.persistentDataPath + "/SaveData";
            if(!Directory.Exists(FileLocation.DATAFOLDER)) 
            {
                Directory.CreateDirectory(FileLocation.DATAFOLDER);
            }
            File.WriteAllText(path + FileLocation.PLAYERDATAFILE, playerData);
        }
    }
}
