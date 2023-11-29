using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Dictionaries;
using Assets.Scripts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Abtractions.Singletons.Managers.MovingManagers
{
    public abstract class CarManager<T> : NonPresetAnimatedObjectManager<T> where T:class
    {
        public IReadOnlyDictionary<ECarAnimation, string> Animations { get; private set; }
        protected override void Start()
        {
            base.Start();
            Animations = CarAnimation.Init(ManagedObject.name.Split(" ")[0]);
        }
    }
}
