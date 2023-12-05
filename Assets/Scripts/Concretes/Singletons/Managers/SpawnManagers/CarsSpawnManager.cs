using Assets.Scripts.Abtractions.Singletons.Managers;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers
{
    public class CarsSpawnManager : SpawnManager<CarsSpawnManager>
    {
        public void SetCars(GameObject selected, GameObject car2, GameObject car3)
        {
            BeSpawnObjects[0] = Instantiate(selected);
            BeSpawnObjects[1] = Instantiate(car2);
            BeSpawnObjects[2] = Instantiate(car3);
            SelectedCarManager.Instance.SetObject(BeSpawnObjects[0]);
            SecondCarManager.Instance.SetObject(BeSpawnObjects[1]);
            ThirdCarManager.Instance.SetObject(BeSpawnObjects[2]);
        }
    }
}
