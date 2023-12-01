using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    [System.Serializable]
    public class PlayerData
    {
        public int currentWordIndex = -1;
        public TimeSpan lastTimePlayed;
        public PlayerData() { }
        public PlayerData(TimeSpan lastTimeplayed)
        {
            this.lastTimePlayed = lastTimeplayed;
        }
    }
}
