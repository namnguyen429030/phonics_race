using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Enums;
using System.Collections;
using UnityEngine;
using Assets.Scripts.Concretes.Singletons.Managers;

namespace Assets.Scripts.Concretes.States.GameStates
{
    public class GuidingState : GameState
    {
        protected override IEnumerator Sequence()
        {
            PhonicsSpawnManager.Instance.SpawnObject();
            yield return new WaitForSeconds(2f);
            MainGameManager.Instance.SetVelocity(0);
            SelectedCarManager.Instance.SetVelocity(0);
            SecondCarManager.Instance.SetVelocity(0);
            ThirdCarManager.Instance.SetVelocity(0);
            SelectedCarManager.Instance.CanSwitchLane = true;
            GuidePointerSpawnManager.Instance.SpawnObject(PhonicsSpawnManager.Instance.CurrentPhonicPosition);
            yield return new WaitUntil(() => GuidePointerSpawnManager.Instance.isPointerTouch);
            GuidePointerSpawnManager.Instance.RecallObject();
            SoundManager.Instance.PlaySound(ESound.NiceDriving);
            SelectedCarManager.Instance.CanSwitchLane = false;
            MainGameManager.Instance.SetVelocity(5f);
            SelectedCarManager.Instance.SetVelocity(5f);
            SecondCarManager.Instance.SetVelocity(5f);
            ThirdCarManager.Instance.SetVelocity(5f);
            GuidePointerSpawnManager.Instance.isPointerTouch = false;
        }
    }
}
