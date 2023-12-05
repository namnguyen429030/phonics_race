using Assets.Scripts.Abtractions.Behaviours;
using Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.SelectionManagers;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers.SelectPage;
using Assets.Scripts.Enums;
using UnityEngine;

namespace Assets.Scripts.Concretes.Behaviours.BeTouchBehaviours
{
    public class CarTouch : BeTouchBehaviour
    {
        public override void OnTouch()
        {
            if (CarRaceSelectionManager.Instance.isSelectable)
            {
                int index = int.Parse(gameObject.name.Split("_")[1]);
                CarRaceSelectionManager.Instance.SelectVehicle(index);
                LightSpawnManager.Instance.RecallObject();
                LightSpawnManager.Instance.SpawnObject(new Vector3(transform.position.x, 0));
                SelectPageButtonsManager.Instance.ShowButton(ESelectPageButton.ConfirmButton, true);
                SoundManager.Instance.PlaySound(ESound.GreatChoice);
            }
        }
    }
}
