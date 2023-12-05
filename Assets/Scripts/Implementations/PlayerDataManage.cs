using Assets.Scripts.Interfaces;
using System.IO;
using UnityEngine;

namespace Assets.Scripts.Implementations
{
    public class PlayerDataManage : IDataManage<PlayerGameData>
    {
        public PlayerGameData Load()
        {
            string destination = Application.persistentDataPath + FileLocation.DATAFOLDER;
            if (Directory.Exists(destination))
            {
                destination += FileLocation.PLAYERDATAFILE;
                string jsonData = File.ReadAllText(destination);
                PlayerGameData playerGameData = JsonUtility.FromJson<PlayerGameData>(jsonData);
                Debug.Log(playerGameData.currentWordIndex);
                return playerGameData;
            }
            return new PlayerGameData();
        }

        public void Save(PlayerGameData data)
        {
            string playerData = JsonUtility.ToJson(data);
            string path = Application.persistentDataPath + FileLocation.DATAFOLDER;
            if(!Directory.Exists(path)) 
            {
                Directory.CreateDirectory(path);
            }
            File.WriteAllText(path + FileLocation.PLAYERDATAFILE, playerData);
        }
    }
}
