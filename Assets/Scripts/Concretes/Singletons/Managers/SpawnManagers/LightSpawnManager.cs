using Assets.Scripts.Abtractions.Singletons.Managers;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers
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
