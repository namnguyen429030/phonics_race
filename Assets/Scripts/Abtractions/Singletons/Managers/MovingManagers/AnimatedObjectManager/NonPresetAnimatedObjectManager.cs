using Assets.Scripts.Abtractions.Behaviours;
using Spine.Unity;
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
