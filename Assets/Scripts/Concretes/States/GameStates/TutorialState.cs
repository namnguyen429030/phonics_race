using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.Singletons.Managers;
using Assets.Scripts.Concretes.Singletons.StateMachines;
using Assets.Scripts.Enums;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Concretes.States.GameStates
{
    public class TutorialState : GameState
    {
        protected override IEnumerator Sequence()
        {
            SoundManager.Instance.PlaySound(ESound.TapHereToMoveYourCar);
            MainGameManager.Instance.SetVelocity(0);
            SelectedCarManager.Instance.SetVelocity(0);
            SecondCarManager.Instance.SetVelocity(0);
            ThirdCarManager.Instance.SetVelocity(0);
            SelectedCarManager.Instance.CanSwitchLane = true;
            GuidePointerSpawnManager.Instance.SpawnObject();
            yield return new WaitUntil(() => GuidePointerSpawnManager.Instance.isPointerTouch);
            GuidePointerSpawnManager.Instance.RecallObject();
            SoundManager.Instance.PlaySound(ESound.NiceDriving);
            MainGameManager.Instance.SetVelocity(5f);
            SelectedCarManager.Instance.SetVelocity(5f);
            SecondCarManager.Instance.SetVelocity(5f);
            ThirdCarManager.Instance.SetVelocity(5f);
            GuidePointerSpawnManager.Instance.isPointerTouch = false;
            yield return new WaitForSeconds(2f);
            GameStateMachine.Instance.HandleSpawnPhonicState();
        }
    }
}
