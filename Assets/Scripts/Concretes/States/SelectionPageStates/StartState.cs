using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.Singletons.Managers.MovingManagers;
using Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.SelectionManagers;
using Assets.Scripts.Enums;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Concretes.States.SelectionPageStates
{
    public class StartState : SelectionPageState
    {
        protected override IEnumerator Sequence()
        {
            PodiumsManager.Instance.SetVelocity(5);
            SoundManager.Instance.PlaySound(ESound.SelectPageBGM);
            SelectionCarsSpawnManager.Instance.SetCars(CarRaceSelectionManager.Instance.SelectedVehicles);
            SelectionCarsSpawnManager.Instance.SpawnObject();
            yield return new WaitForSeconds(1.25f);
            PodiumsManager.Instance.SetVelocity(0);
            SoundManager.Instance.PlaySound(ESound.TapToChooseACar);
            yield return new WaitForSeconds(1f);
            CarRaceSelectionManager.Instance.isSelectable = true;
        }
    }
}
