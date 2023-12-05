using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Datas.ScriptableObjects;
using System;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers
{
    public class CarSelectionManager : SelectionManager<CarSelectionManager, Car>
    {
        [SerializeField] protected int totalCars;
        public Car[] SelectedCars { get; private set; }
        [HideInInspector]public bool isSelectable;
        private void Start()
        {
            SelectedCars = new Car[totalCars];
        }
        public override void SelectObject()
        {
            Car[] cars = database.GetObjects();
            for (int i = cars.Length - 1; i > -1; i--)
            {
                int index = UnityEngine.Random.Range(0, i - 1);
                (cars[i], cars[index]) = (cars[index], cars[i]);
            }
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].GetSelectPageGameObject().name = cars[i].name + "_" + i;
            }
            Array.Copy(cars, SelectedCars, 3);
        }
        public void ConfirmSelection()
        {
            if (SelectedIndex != 0)
            {
                Car vehicle = SelectedCars[0];
                SelectedCars[0] = SelectedCars[SelectedIndex];
                SelectedCars[SelectedIndex] = vehicle;
            }
        }
    }
}
