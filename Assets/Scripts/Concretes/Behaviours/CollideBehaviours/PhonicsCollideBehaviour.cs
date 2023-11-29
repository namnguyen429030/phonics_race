using Assets.Scripts.Abtractions.Behaviours;
using Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers;
using Assets.Scripts.Concretes.Singletons.StateMachines;
using Assets.Scripts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Concretes.Behaviours.CollideBehaviours
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
