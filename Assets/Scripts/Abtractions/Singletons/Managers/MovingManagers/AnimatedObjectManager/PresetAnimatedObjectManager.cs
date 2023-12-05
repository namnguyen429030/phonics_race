using Spine.Unity;

namespace Assets.Scripts.Abtractions.Singletons.Managers
{
    public abstract class PresetAnimatedObjectManager<T> : AnimatedObjectManager<T> where T : class
    {
        protected override void Start()
        {
            base.Start();
            _skeleton = ManagedObject.GetComponent<SkeletonAnimation>();
        }
    }
}
