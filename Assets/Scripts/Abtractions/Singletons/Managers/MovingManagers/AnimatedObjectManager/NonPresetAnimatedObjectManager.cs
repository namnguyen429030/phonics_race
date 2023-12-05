using Assets.Scripts.Abtractions.Behaviours;
using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Abtractions.Singletons.Managers.MovingManagers;
using Spine.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Abtractions.Singletons.Managers
{
    public abstract class NonPresetAnimatedObjectManager<T> : AnimatedObjectManager<T> where T : class
    {
        public virtual void SetObject(GameObject _gameObject)
        {
            ManagedObject = _gameObject;
            ObjectMovement = ManagedObject.GetComponent<MoveBehaviour>();
            _skeleton = _gameObject.GetComponent<SkeletonAnimation>();
        }
    }
}
