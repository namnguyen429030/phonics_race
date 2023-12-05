using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.Singletons.Managers.MovingManagers;
using Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.SelectionManagers;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers.SelectPage;
using Assets.Scripts.Enums;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Concretes.States.SelectionPageStates
{
    public class ConfirmState : SelectionPageState
    {
        protected override IEnumerator Sequence()
        {
            CarRaceSelectionManager.Instance.isSelectable = false;
            SoundManager.Instance.PlaySound(ESound.YouGotAGreatCar);
            SelectPageButtonsManager.Instance.ShowButton(ESelectPageButton.ConfirmButton, false);
            CarRaceSelectionManager.Instance.ConfirmSelection();
            yield return new WaitForSeconds(2f);
            PodiumsManager.Instance.SetVelocity(10);
            PodiumsManager.Instance.SetDirection(new Vector3(0,-1,0));
            LightSpawnManager.Instance.RecallObject();
            yield return new WaitForSeconds(2f);
            SoundManager.Instance.StopAll();
            SceneManager.LoadSceneAsync("MainGame");
        }
    }
}
