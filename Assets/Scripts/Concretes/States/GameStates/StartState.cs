using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.Singletons.Managers;
using Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Concretes.Singletons.StateMachines;
using Assets.Scripts.Dictionaries;
using Assets.Scripts.Enums;
using Assets.Scripts.Implementations;
using Assets.Scripts.Interfaces;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Concretes.States.GameStates
{
    public class StartState : GameState
    {
        protected override IEnumerator Sequence()
        {
            //Spawn cars
            WordSelectionManager.Instance.SelectObject();

            CarsSpawnManager.Instance.SetCars(CarSelectionManager.Instance.SelectedCars[0].GetGameObject(), CarSelectionManager.Instance.SelectedCars[1].GetGameObject(), CarSelectionManager.Instance.SelectedCars[2].GetGameObject());
            PhonicsSpawnManager.Instance.SetWord(WordSelectionManager.Instance.SelectedObject);
            SoundManager.Instance.SetWord(WordSelectionManager.Instance.SelectedObject);
            SoundManager.Instance.PlaySound(ESound.MainGameBGM);
            SoundManager.Instance.PlaySound(ESound.Welcome);
            CarsSpawnManager.Instance.SpawnObject();
            yield return new WaitForSeconds(1f);

            SecondCarManager.Instance.SetAnimation(SecondCarManager.Instance.Animations[ECarAnimation.NormalGo]);
            ThirdCarManager.Instance.SetAnimation(ThirdCarManager.Instance.Animations[ECarAnimation.NormalGo]);
            SelectedCarManager.Instance.SetAnimation(SelectedCarManager.Instance.Animations[ECarAnimation.NormalGo]);
            SelectedCarManager.Instance.SetVelocity(7f);
            SecondCarManager.Instance.SetVelocity(7f);
            ThirdCarManager.Instance.SetVelocity(7f);
            yield return new WaitForSeconds(1.25f);

            SelectedCarManager.Instance.SetVelocity(0);
            SecondCarManager.Instance.SetVelocity(0);
            ThirdCarManager.Instance.SetVelocity(0);
            //Count down
            CountDown.Instance.SpawnObject();
            SoundManager.Instance.PlaySound(ESound.CountingDown);
            yield return new WaitForSeconds(1f);
            SelectedCarManager.Instance.SetAnimation(SelectedCarManager.Instance.Animations[ECarAnimation.Set]);
            SecondCarManager.Instance.SetAnimation(SecondCarManager.Instance.Animations[ECarAnimation.Set]);
            ThirdCarManager.Instance.SetAnimation(ThirdCarManager.Instance.Animations[ECarAnimation.Set]);
            yield return new WaitForSeconds(2f);
            SoundManager.Instance.PlaySound(ESound.StartTheRace);
            RefereeManager.Instance.SetAnimation(RefereeAnimation.RefereeAnimations[ERefereeAnimation.Go]);
            yield return new WaitForSeconds(1f);
            CountDown.Instance.RecallObject();

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

            IDataManage<PlayerGameData> dataManage = new PlayerDataManage();
            PlayerGameData playerData = dataManage.Load();
            //If player has never played before, start guiding
            if (playerData.currentWordIndex == -1)
            {
                GameStateMachine.Instance.HandleTutorialState();
            }
            else
            {
                //If player has played before, start spawning phonics
                SelectedCarManager.Instance.CanSwitchLane = true;
                GameStateMachine.Instance.HandleSpawnPhonicState();
            }
        }
    }
}
