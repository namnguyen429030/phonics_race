using System;

namespace Assets.Scripts
{
    [System.Serializable]
    public class PlayerGameData
    {
        public int currentWordIndex = -1;
        public DateTime lastTimePlayed;
        public PlayerGameData() 
        {
            this.lastTimePlayed = DateTime.Now;
        }
        public PlayerGameData(int currentWordIndex)
        {
            this.currentWordIndex = currentWordIndex;
            this.lastTimePlayed = DateTime.Now;
        }
    }
}
