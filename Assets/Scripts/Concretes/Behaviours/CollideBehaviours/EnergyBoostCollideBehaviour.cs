﻿using Assets.Scripts.Abtractions.Behaviours;
using Assets.Scripts.Concretes.Singletons.Managers;
using Assets.Scripts.Enums;
using UnityEngine;

namespace Assets.Scripts.Concretes.Behaviours
{
    public class EnergyBoostCollideBehaviour : CollideBehaviour
    {
        protected override void OnTriggerEnter2D(Collider2D collider)
        {
            if(collider.gameObject.CompareTag("Car"))
            {
                SoundManager.Instance.PlaySound(ESound.CollectingBoostSfx);
                SelectedCarManager.Instance.SetAnimation(SelectedCarManager.Instance.Animations[ECarAnimation.PreEnergyBoost]);
                EnergyBoostSpawnManager.Instance.RecallObject();
                SelectedCarManager.Instance.SetVelocity(20f);
                SecondCarManager.Instance.SetVelocity(25f);
                ThirdCarManager.Instance.SetVelocity(35f);
            }
        }
    }
}
