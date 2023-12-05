using Assets.Scripts.Abtractions.Behaviours;
using Assets.Scripts.Concretes.Singletons.Managers;
using Assets.Scripts.Enums;
using UnityEngine;

namespace Assets.Scripts.Concretes.Behaviours
{
    public class CarTouch : BeTouchBehaviour
    {
        public override void OnTouch()
        {
            if (CarSelectionManager.Instance.isSelectable)
            {
                int index = int.Parse(gameObject.name.Split("_")[1]);
                CarSelectionManager.Instance.SelectObject(index);
                LightSpawnManager.Instance.RecallObject();
                LightSpawnManager.Instance.SpawnObject(new Vector3(transform.position.x, 0));
                SelectPageButtonsManager.Instance.ShowButton(ESelectPageButton.ConfirmButton, true);
                SoundManager.Instance.PlaySound(ESound.GreatChoice);
            }
        }
    }
}
