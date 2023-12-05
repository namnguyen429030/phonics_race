using Assets.Scripts.Abtractions.Singletons.Managers.SpawnManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers
{
    public class LightSpawnManager : SpawnManager<LightSpawnManager>
    {
        public void SpawnObject(Vector3 destination)
        {
            for (int i = 0; i < BeSpawnObjects.Length; i++)
            {
                GameObject spawned = BeSpawnObjects[i];
                spawned.SetActive(true);
                spawned.transform.position = destination;
            }
        }
    }
}
