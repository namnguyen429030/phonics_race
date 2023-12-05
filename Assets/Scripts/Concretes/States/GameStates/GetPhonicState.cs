using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.Singletons.Managers;
using Assets.Scripts.Concretes.Singletons.StateMachines;
using Assets.Scripts.Enums;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Concretes.States.GameStates
{
    public class GetPhonicState : GameState
    {
        protected override IEnumerator Sequence()
        {
            SelectedCarManager.Instance.ResetCount();
            PhonicsSpawnManager.Instance.RecallObject();

            WordBoxManager.Instance.Reveal();
            yield return new WaitForSeconds(1f);

            HappyCrewSpawnManager.Instance.SpawnObject();
            yield return new WaitForSeconds(5f);

            SelectedCarManager.Instance.CanSwitchLane = false;
            SelectedCarManager.Instance.UpRank();
            SelectedCarManager.Instance.SetAnimation(SelectedCarManager.Instance.Animations[ECarAnimation.PreSelfBoost]);
            SelectedCarManager.Instance.SetVelocity(10f);
            ThirdCarManager.Instance.SetVelocity(0f);
            SecondCarManager.Instance.SetVelocity(0f);
            yield return new WaitForSeconds(1.5f);

            HappyCrewSpawnManager.Instance.RecallObject();
            SelectedCarManager.Instance.SetAnimation(SelectedCarManager.Instance.Animations[ECarAnimation.SelfBoost]);
            MainGameManager.Instance.SetVelocity(10f);
            yield return new WaitForSeconds(5f);

            SelectedCarManager.Instance.SetVelocity(5f);
            SelectedCarManager.Instance.SetAnimation(SelectedCarManager.Instance.Animations[ECarAnimation.EndSelfBoost]);
            yield return new WaitForSeconds(1.5f);

            ThirdCarManager.Instance.SetVelocity(5f);
            SecondCarManager.Instance.SetVelocity(5f);
            SelectedCarManager.Instance.CanSwitchLane = true;
            SelectedCarManager.Instance.SetAnimation(SelectedCarManager.Instance.Animations[ECarAnimation.NormalGo]);
            MainGameManager.Instance.SetVelocity(5f);
            yield return new WaitForSeconds(3f);
            if (PhonicsSpawnManager.Instance.GetCurrentPhonicIndex() < 2)
            {
                PhonicsSpawnManager.Instance.NextIndex();
                GameStateMachine.Instance.HandleSpawnPhonicState();
            }
            else
            {
                GameStateMachine.Instance.HandleEndState();
            }
        }
    }
}
