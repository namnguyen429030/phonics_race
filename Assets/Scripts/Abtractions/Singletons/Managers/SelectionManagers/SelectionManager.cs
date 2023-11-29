using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Datas.Abstractions;
using Assets.Scripts.Datas.Concretes;
using Assets.Scripts.Datas.ConcretesConcretes;
using Assets.Scripts.Datas.ScriptableObjects;
using UnityEngine;

namespace Assets.Scripts.Abtractions.Singletons.Managers.SelectionManagers
{
    public abstract class SelectionManager<T1,T2> : Manager<T1> where T1 : class where T2 : Vehicle
    {
        [SerializeField] protected WordDatabase Words;
        [SerializeField] protected VehicleDatabase<T2> Vehicles;
        protected abstract void Start();
    }
}
