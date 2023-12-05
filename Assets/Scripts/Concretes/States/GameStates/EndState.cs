using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.Singletons.Managers;
using Assets.Scripts.Dictionaries;
using Assets.Scripts.Enums;
using Assets.Scripts.Implementations;
using Assets.Scripts.Interfaces;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Concretes.States.GameStates
{
    public class EndState : GameState
    {
        protected override IEnumerator Sequence()
        {
            MainGameButtonsManager.Instance.ShowButton(EGameButton.PauseButton, false);
            yield return new WaitForSeconds(2f);
            EnergyBoostSpawnManager.Instance.SpawnObject();
            yield return new WaitForSeconds(3f);
            MainGameManager.Instance.SetVelocity(15f);
            SelectedCarManager.Instance.SetAnimation(SelectedCarManager.Instance.Animations[ECarAnimation.EnergyBoost]);
            yield return new WaitForSeconds(2f);
            FinishLineSpawnManager.Instance.SpawnObject();
            HappyCrewSpawnManager.Instance.SpawnObject();
            RefereeManager.Instance.SetAnimation(RefereeAnimation.RefereeAnimations[ERefereeAnimation.Finish]);
            yield return new WaitForSeconds(1f);
            MountainManager.Instance.SetVelocity(0);
            RoadManager.Instance.SetVelocity(0);
            TreesManager.Instance.SetVelocity(0f);
            MainGameManager.Instance.SetVelocity(0);
            yield return new WaitForSeconds(4f);
            WordBoxManager.Instance.ShowWordBox();
            yield return new WaitForSeconds(2f);
            yield return StartCoroutine(WordBoxManager.Instance.RevealEnding());
            IDataManage<PlayerGameData> dataManage = new PlayerDataManage();
            PlayerGameData playerGameData = new PlayerGameData(WordSelectionManager.Instance.SelectedIndex);
            dataManage.Save(playerGameData);
            yield return new WaitForSeconds(2f);
            MainGameButtonsManager.Instance.ShowButton(EGameButton.NextPhonicButton, true);
            
        }
    }
}
