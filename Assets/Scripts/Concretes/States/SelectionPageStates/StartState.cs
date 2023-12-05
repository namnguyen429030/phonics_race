using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.Singletons.Managers;
using Assets.Scripts.Enums;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Concretes.States.SelectionPageStates
{
    public class StartState : SelectionPageState
    {
        protected override IEnumerator Sequence()
        {
            CarSelectionManager.Instance.SelectObject();
            PodiumsManager.Instance.SetVelocity(5);
            SoundManager.Instance.PlaySound(ESound.SelectPageBGM);
            SelectionCarsSpawnManager.Instance.SetCars(CarSelectionManager.Instance.SelectedCars);
            SelectionCarsSpawnManager.Instance.SpawnObject();
            yield return new WaitForSeconds(1.25f);
            PodiumsManager.Instance.SetVelocity(0);
            SoundManager.Instance.PlaySound(ESound.TapToChooseACar);
            yield return new WaitForSeconds(1f);
            CarSelectionManager.Instance.isSelectable = true;
        }
    }
}
