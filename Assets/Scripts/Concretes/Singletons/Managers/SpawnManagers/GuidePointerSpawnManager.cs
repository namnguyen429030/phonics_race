using Assets.Scripts.Abtractions.Singletons.Managers.SpawnManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers
{
    public class GuidePointerSpawnManager : SpawnManager<GuidePointerSpawnManager>
    {
        [HideInInspector]public bool isPointerTouch;

        public void SpawnObject(Vector3 destination)
        {
            GameObject spawned = BeSpawnObjects[0];
            spawned.SetActive(true);
            spawned.transform.position = destination;
        }
    }
}
