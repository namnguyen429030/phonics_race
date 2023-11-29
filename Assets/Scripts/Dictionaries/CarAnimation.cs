using Assets.Scripts.Enums;
using System.Collections.Generic;

namespace Assets.Scripts.Dictionaries
{
    public class CarAnimation
    {
        public static IReadOnlyDictionary<ECarAnimation, string> Init(string color)
        {
            switch(color)
            {
                case "Blue":
                    return BlueCarAnimations;
                case "Orange":
                    return OrangeCarAnimations;
                case "Pink":
                    return PinkCarAnimations;
                default: return null;
            }
        }
        private static readonly IReadOnlyDictionary<ECarAnimation, string> BlueCarAnimations = new Dictionary<ECarAnimation, string>()
        {
            { ECarAnimation.Ready, "Xe xanh_0" },
            { ECarAnimation.Set, "Xe xanh_0-1" },
            { ECarAnimation.NormalGo, "Xe xanh_1" },
            { ECarAnimation.PreSelfBoost, "Xe xanh_1-2" },
            { ECarAnimation.SelfBoost, "Xe xanh_2" },
            { ECarAnimation.EndSelfBoost, "Xe xanh_2-1" },
            { ECarAnimation.PreEnergyBoost, "Xe xanh_1-3" },
            { ECarAnimation.EnergyBoost, "Xe xanh_3" }
        };
        private static readonly IReadOnlyDictionary<ECarAnimation, string> OrangeCarAnimations = new Dictionary<ECarAnimation, string>()
        {
            { ECarAnimation.Ready, "Xe cam_0" },
            { ECarAnimation.Set, "Xe cam_0-1" },
            { ECarAnimation.NormalGo, "Xe cam_1" },
            { ECarAnimation.PreSelfBoost, "Xe cam_1-2" },
            { ECarAnimation.SelfBoost, "Xe cam_2" },
            { ECarAnimation.EndSelfBoost, "Xe cam_2-1" },
            { ECarAnimation.PreEnergyBoost, "Xe cam_1-3" },
            { ECarAnimation.EnergyBoost, "Xe cam_3" }
        };
        private static readonly IReadOnlyDictionary<ECarAnimation, string> PinkCarAnimations = new Dictionary<ECarAnimation, string>()
        {
            { ECarAnimation.Ready, "Xe hong_0" },
            { ECarAnimation.Set, "Xe hong_0-1" },
            { ECarAnimation.NormalGo, "Xe hong_1" },
            { ECarAnimation.PreSelfBoost, "Xe hong_1-2" },
            { ECarAnimation.SelfBoost, "Xe hong_2" },
            { ECarAnimation.EndSelfBoost, "Xe hong_2-1" },
            { ECarAnimation.PreEnergyBoost, "Xe hong_1-3" },
            { ECarAnimation.EnergyBoost, "Xe hong_3" }
        };
    }
}
