using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Datas.Abstractions;
using Assets.Scripts.Datas.Concretes;
using Assets.Scripts.Datas.ConcretesConcretes;
using Assets.Scripts.Datas.ScriptableObjects;
using System;
using UnityEngine;

namespace Assets.Scripts.Abtractions.Singletons.Managers
{
    public abstract class SelectionManager<T1,T2> : Manager<T1> where T1 : class where T2 : ScriptableObject
    {
        [SerializeField] protected Database<T2> database;
        public T2 SelectedObject { get; protected set; }
        public int SelectedIndex { get;private set; }
        public abstract void SelectObject();
        public void SelectObject(int index)
        {
            SelectedIndex = index;
        }
    }
}
