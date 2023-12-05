using Assets.Scripts.Abtractions.Singletons.Managers.SelectionManagers;
using Assets.Scripts.Datas.ConcretesConcretes;
using Assets.Scripts.Datas.ScriptableObjects;
using Assets.Scripts.Implementations;
using Assets.Scripts.Interfaces;
using System;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.SelectionManagers
{
    public class CarRaceSelectionManager : SelectionManager<CarRaceSelectionManager, Car>
    {
        IDataManage<PlayerGameData> playerDataManager;
        protected override void SelectVehicles()
        {
            Car[] cars = Vehicles.GetObjects();
            for (int i = cars.Length - 1; i > -1; i--)
            {
                int index = UnityEngine.Random.Range(0, i - 1);
                (cars[i], cars[index]) = (cars[index], cars[i]);
            }
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].GetSelectPageGameObject().name = cars[i].name + "_" + i;
            }
            Array.Copy(cars, SelectedVehicles, 3);
        }

        public override void SelectWord()
        {
            playerDataManager = new PlayerDataManage();
            PlayerGameData playerData = playerDataManager.Load();
            selectedWordIndex = playerData.currentWordIndex + 1;
            if(selectedWordIndex == Words.Count)
            {
                selectedWordIndex = 0;
            }
            SelectedWord = Words.SelectObject(selectedWordIndex);
        }
    }
}
