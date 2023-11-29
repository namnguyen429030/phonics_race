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
    public abstract class PresetAnimatedObjectManager<T> : AnimatedObjectManager<T> where T : class
    {
        protected override void Start()
        {
            base.Start();
            _skeleton = ManagedObject.GetComponent<SkeletonAnimation>();
        }
    }
}
