using Assets.Scripts.Abtractions.Behaviours;
using Assets.Scripts.Implementations;
using Assets.Scripts.Interfaces;
using Spine.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Abtractions.Singletons.Managers
{
    public abstract class AnimatedObjectManager<T> : MovingManager<T> where T : class
    {
        protected SkeletonAnimation _skeleton;
        protected IAnimationManage animationManage;
        protected override void Start()
        {
            base.Start();
            animationManage = new AnimationManage();
        }
        public void SetAnimation(string animationName)
        {
            animationManage.ChangeAnimation(_skeleton, animationName);
        }
    }
}
