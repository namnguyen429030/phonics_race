using Assets.Scripts.Abtractions.Singletons.Managers;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers
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
