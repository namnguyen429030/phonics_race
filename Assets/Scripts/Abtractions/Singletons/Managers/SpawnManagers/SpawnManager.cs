using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Abtractions.Singletons.Managers
{
    public abstract class SpawnManager<T> : Manager<T> where T : class
    {
        [SerializeField] protected GameObject[] BeSpawnObjects;
        [SerializeField] protected GameObject[] SpawnPlaces;
        public virtual void SpawnObject()
        {
            for (int i = 0; i < BeSpawnObjects.Length; i++)
            {
                GameObject spawned = BeSpawnObjects[i];
                spawned.SetActive(true);
                spawned.transform.position = SpawnPlaces[i].transform.position;
            }
        }
        public virtual void RecallObject()
        {
            for (int i = 0; i < BeSpawnObjects.Length; i++)
            {
                GameObject spawned = BeSpawnObjects[i];
                spawned.SetActive(false);
            }
        }
    }
}
