using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
