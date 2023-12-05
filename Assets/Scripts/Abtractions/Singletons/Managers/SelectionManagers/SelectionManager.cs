using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Datas.Abstractions;
using Assets.Scripts.Datas.Concretes;
using Assets.Scripts.Datas.ConcretesConcretes;
using Assets.Scripts.Datas.ScriptableObjects;
using System;
using UnityEngine;

namespace Assets.Scripts.Abtractions.Singletons.Managers.SelectionManagers
{
    public abstract class SelectionManager<T1,T2> : Manager<T1> where T1 : class where T2 : Vehicle
    {
        [SerializeField] protected WordDatabase Words;
        [SerializeField] protected VehicleDatabase<T2> Vehicles;
        [SerializeField] protected int totalVehicles;
        public Word SelectedWord { get; protected set; }
        public T2[] SelectedVehicles { get; protected set; }
        public bool isSelectable;
        protected int selectedWordIndex;
        protected int selectedIndex;
        protected void Start()
        {
            SelectedVehicles = new T2[totalVehicles];
            SelectVehicles();
            SelectWord();
        }
        public abstract void SelectWord();
        protected abstract void SelectVehicles();
        public void SelectVehicle(int index)
        {
            selectedIndex = index;
        }
        public void ConfirmSelection()
        {
            if (selectedIndex != 0)
            {
                T2 vehicle = SelectedVehicles[0];
                SelectedVehicles[0] = SelectedVehicles[selectedIndex];
                SelectedVehicles[selectedIndex] = vehicle;
            }
        }
        public int GetCurrentWordIndex()
        {
            return selectedWordIndex;
        }
    }
}
