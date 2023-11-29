using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Abtractions.Singletons.Managers.MovingManagers;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers.MovingManagers.AnimatedObjectManagers
{
    public class SelectedCarManager : CarManager<SelectedCarManager>
    {
        [HideInInspector]
        public bool CanSwitchLane { get; set; }
    }
}
