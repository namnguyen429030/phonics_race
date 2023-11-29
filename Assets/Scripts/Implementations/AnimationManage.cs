using Assets.Scripts.Interfaces;
using Spine.Unity;

namespace Assets.Scripts.Implementations
{
    public class AnimationManage : IAnimationManage
    {
        public void ChangeAnimation(SkeletonAnimation skeleton, string animationName)
        {
            skeleton.AnimationName = animationName;
        }
    }
}
