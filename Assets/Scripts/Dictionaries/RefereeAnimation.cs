using Assets.Scripts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Dictionaries
{
    public static class RefereeAnimation
    {
        public static IReadOnlyDictionary<ERefereeAnimation, string> RefereeAnimations = new Dictionary<ERefereeAnimation, string>()
        {
            { ERefereeAnimation.Idle, "Referee - Idle"},
            { ERefereeAnimation.Go, "Referee - Go"},
            { ERefereeAnimation.Finish, "Referee - Happy - 100%"}
        };
    }
}
