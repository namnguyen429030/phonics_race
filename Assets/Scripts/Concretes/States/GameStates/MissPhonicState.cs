using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.Singletons.Managers;
using Assets.Scripts.Concretes.Singletons.StateMachines;
using Assets.Scripts.Enums;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Concretes.States.GameStates
{
    public class MissPhonicState : GameState
    {
        protected override IEnumerator Sequence()
        {
            SelectedCarManager.Instance.AddCount();
            DisappointedCrewSpawnManager.Instance.SpawnObject();
            SoundManager.Instance.PlaySound(ESound.CrowdDisappointing);
            PhonicsSpawnManager.Instance.RecallObject();
            yield return new WaitForSeconds(7f);
            DisappointedCrewSpawnManager.Instance.RecallObject();
            MainGameManager.Instance.SetVelocity(0);
            SelectedCarManager.Instance.SetVelocity(0);
            if(SelectedCarManager.Instance.Place != 3)
            {
                SecondCarManager.Instance.SetVelocity(10f);
                ThirdCarManager.Instance.SetVelocity(10f);
                yield return new WaitForSeconds(6.5f);
                SecondCarManager.Instance.SetVelocity(5f);
                ThirdCarManager.Instance.SetVelocity(5f);
            }
            if (SelectedCarManager.Instance.Place < 3)
            {
                SelectedCarManager.Instance.DownRank();
            }
            MainGameManager.Instance.SetVelocity(5f);
            SelectedCarManager.Instance.SetVelocity(5f);
            if (SelectedCarManager.Instance.MissCount == 3)
            {
                Debug.Log("Start guiding");
                GameStateMachine.Instance.HandleGuidingState();
            }
            else
            {
                GameStateMachine.Instance.HandleSpawnPhonicState();
            }
        }
    }
}
