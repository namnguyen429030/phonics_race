using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Datas.ScriptableObjects;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers
{
    public class SelectionCarsSpawnManager : SpawnManager<SelectionCarsSpawnManager>
    {
        public void SetCars(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                GameObject car = cars[i].GetSelectPageGameObject();
                BeSpawnObjects[i] = car;
                BeSpawnObjects[i].name = car.name;
            }
        }
        public override void SpawnObject()
        {
            for (int i = 0; i < BeSpawnObjects.Length; i++)
            {
                GameObject spawned = Instantiate(BeSpawnObjects[i], SpawnPlaces[i].transform.position, Quaternion.identity);
                spawned.transform.parent = SpawnPlaces[i].transform.parent;
                spawned.name = BeSpawnObjects[i].name;
            }
        }
    }
}
