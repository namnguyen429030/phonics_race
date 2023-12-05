using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Dictionaries;
using Assets.Scripts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Abtractions.Singletons.Managers.MovingManagers
{
    public abstract class CarManager<T> : NonPresetAnimatedObjectManager<T> where T:class
    {
        public IReadOnlyDictionary<ECarAnimation, string> Animations { get; private set; }
        public override void SetObject(GameObject _gameObject)
        {
            base.SetObject(_gameObject);
            Animations = CarAnimation.Init(ManagedObject.name.Split(" ")[0]);
        }
    }
}
