using Assets.Scripts.Abtractions.Behaviours;
using Assets.Scripts.Concretes.Singletons.Managers;
using Assets.Scripts.Concretes.Singletons.StateMachines;
using Assets.Scripts.Enums;
using UnityEngine;

namespace Assets.Scripts.Concretes.Behaviours
{
    public class PhonicsCollideBehaviour : CollideBehaviour
    {
        protected override void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.gameObject.CompareTag("Car"))
            {
                SoundManager.Instance.PlaySound(ESound.CollectingPhonicsSfx);
                SoundManager.Instance.PlayPhonic(PhonicsSpawnManager.Instance.GetCurrentPhonicIndex());
                GameStateMachine.Instance.HandleGetPhonicState();
            }
        }
    }
}
