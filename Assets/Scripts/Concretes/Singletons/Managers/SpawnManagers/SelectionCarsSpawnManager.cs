using Assets.Scripts.Abtractions.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Datas.ScriptableObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers
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
