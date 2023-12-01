using Assets.Scripts.Abtractions.Singletons.Managers.SelectionManagers;
using Assets.Scripts.Datas.ScriptableObjects;
using Assets.Scripts.Implementations;
using Assets.Scripts.Interfaces;
using System;

namespace Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.SelectionManagers
{
    public class CarRaceSelectionManager : SelectionManager<CarRaceSelectionManager, Car>
    {
        IDataManage<PlayerData> playerDataManager;
        protected override void SelectVehicles()
        {
            Car[] cars = Vehicles.GetObjects();
            for(int i = cars.Length - 1; i > -1; i--)
            {
                int index = UnityEngine.Random.Range(0, i - 1);
                Car car = cars[index];
                cars[i] = cars[index];
                cars[index] = car;
            }
            Array.Copy(cars, SelectedVehicles, 3);
        }

        protected override void SelectWord()
        {
            playerDataManager = new PlayerDataManage();
            PlayerData playerData = playerDataManager.Load();
            if(playerData.currentWordIndex != -1)
            {
                SelectedWord = Words.SelectObject(playerData.currentWordIndex);
            }
            else
            {
                SelectedWord = Words.SelectObject(0);
            }
        }

    }
}
