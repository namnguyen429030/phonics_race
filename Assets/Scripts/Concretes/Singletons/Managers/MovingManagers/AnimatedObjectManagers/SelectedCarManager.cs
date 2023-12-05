using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Abtractions.Singletons.Managers.MovingManagers;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers.MovingManagers.AnimatedObjectManagers
{
    public class SelectedCarManager : CarManager<SelectedCarManager>
    {
        [HideInInspector]
        public bool CanSwitchLane { get; set; }
        [HideInInspector]
        public int Place { get; private set; } = 3;
        public int MissCount {  get; private set;} = 0;
        public void UpRank()
        {
            Place--;
        }
        public void DownRank()
        {
            Place++;
        }
        public void ResetCount()
        {
            MissCount = 0;
        }
        public void AddCount()
        {
            MissCount++;
        }
    }
}
