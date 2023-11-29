using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.Singletons.Managers.MovingManagers;
using Assets.Scripts.Concretes.Singletons.Managers.MovingManagers.AnimatedObjectManagers;
using Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Concretes.Singletons.StateMachines;
using Assets.Scripts.Dictionaries;
using Assets.Scripts.Enums;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Concretes.States.GameStates
{
    public class StartState : GameState
    {
        protected override IEnumerator Sequence()
        {
            //Spawn cars
            CarsSpawnManager.Instance.SpawnObject();

            //Count down
            yield return new WaitForSeconds(1f);
            SelectedCarManager.Instance.SetAnimation(SelectedCarManager.Instance.Animations[ECarAnimation.Set]);
            SecondCarManager.Instance.SetAnimation(SecondCarManager.Instance.Animations[ECarAnimation.Set]);
            ThirdCarManager.Instance.SetAnimation(ThirdCarManager.Instance.Animations[ECarAnimation.Set]);
            yield return new WaitForSeconds(2f);
            RefereeManager.Instance.SetAnimation(RefereeAnimation.RefereeAnimations[ERefereeAnimation.Go]);
            yield return new WaitForSeconds(1f);

            //Second and third go
            SecondCarManager.Instance.SetAnimation(SecondCarManager.Instance.Animations[ECarAnimation.NormalGo]);
            ThirdCarManager.Instance.SetAnimation(ThirdCarManager.Instance.Animations[ECarAnimation.NormalGo]);
            SecondCarManager.Instance.SetVelocity(45f);
            ThirdCarManager.Instance.SetVelocity(25f);
            yield return new WaitForSeconds(1f);

            //Player go
            SelectedCarManager.Instance.SetAnimation(SelectedCarManager.Instance.Animations[ECarAnimation.NormalGo]);
            SelectedCarManager.Instance.SetVelocity(6f);
            MainGameManager.Instance.SetVelocity(7f);
            MountainManager.Instance.SetVelocity(0.5f);
            RoadManager.Instance.SetVelocity(0.5f);
            FinishLineManager.Instance.SetVelocity(-10f);
            RefereeManager.Instance.SetVelocity(-10f);
            TreesManager.Instance.SetVelocity(0.5f);
            yield return new WaitForSeconds(2f);

            //Referee and Finish line back to object pool
            RefereeManager.Instance.SetVelocity(0);
            FinishLineManager.Instance.SetVelocity(0);
            FinishLineSpawnManager.Instance.RecallObject();

            //Second and third slow down
            SecondCarManager.Instance.SetVelocity(5f);
            ThirdCarManager.Instance.SetVelocity(5f);
            yield return new WaitForSeconds(0.5f);

            //Camera and player go at the same speed for positioning player at the most - left of camera
            SelectedCarManager.Instance.SetVelocity(5f);
            MainGameManager.Instance.SetVelocity(5f);
            yield return new WaitForSeconds(2f);
            SelectedCarManager.Instance.CanSwitchLane = true;

            //If player has never played before, start guiding

            //If player has played before, start spawning phonics
            GameStateMachine.Instance.HandleSpawnPhonicState();
        }
    }
}
