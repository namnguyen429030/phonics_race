using Assets.Scripts.Abtractions.Behaviours;
using Assets.Scripts.Concretes.Behaviours.MoveBehaviours;
using Assets.Scripts.Concretes.Singletons.Managers.MovingManagers.AnimatedObjectManagers;
using Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.Concretes.Behaviours.BeTouchBehaviours
{
    public class GuidePointerTouch : BeTouchBehaviour
    {
        public override void OnTouch()
        {
            GuidePointerSpawnManager.Instance.isPointerTouch = true;
            SelectedCarManager.Instance.GetObject().GetComponent<NonBackgroundMoveBehaviour>().SetDestination(gameObject);
        }
    }
}
