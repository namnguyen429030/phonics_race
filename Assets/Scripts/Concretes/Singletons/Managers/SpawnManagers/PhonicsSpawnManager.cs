using Assets.Scripts.Abtractions.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers;
using Assets.Scripts.Datas.ScriptableObjects;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers
{
    public class PhonicsSpawnManager : SpawnManager<PhonicsSpawnManager>
    {
        private int currentPhonicIndex = 0;
        public Vector3 CurrentPhonicPosition { get; private set; }
        public override void SpawnObject()
        {
            int laneIndex = Random.Range(0,2);
            GameObject spawned = BeSpawnObjects[currentPhonicIndex];
            spawned.SetActive(true);
            CurrentPhonicPosition = spawned.transform.position = SpawnPlaces[laneIndex].transform.position;
        }
        public void SetWord(Word word)
        {
            GameObject[] words = word.GetPhonics();
            for(int i = 0; i < words.Length; i++)
            {
                BeSpawnObjects[i] = Instantiate(words[i]);
                BeSpawnObjects[i].SetActive(false);
            }
            WordBoxManager.Instance.SetWordBox(word);
        }
        public int NextIndex()
        {
            return ++currentPhonicIndex;
        }
        public int GetCurrentPhonicIndex()
        {
            return currentPhonicIndex;
        }
    }
}
