using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.Singletons.Managers;
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
            CarSelectionManager.Instance.isSelectable = false;
            SoundManager.Instance.PlaySound(ESound.YouGotAGreatCar);
            SelectPageButtonsManager.Instance.ShowButton(ESelectPageButton.ConfirmButton, false);
            CarSelectionManager.Instance.ConfirmSelection();
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
