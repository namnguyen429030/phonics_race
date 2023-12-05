using Assets.Scripts.Enums;
using System.Collections.Generic;

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
