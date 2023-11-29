using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Datas.ScriptableObjects;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers
{
    public class WordBoxManager : Manager<WordBoxManager>
    {
        [SerializeField] GameObject WordBox;
        [SerializeField] GameObject[] WhitePhonics;
        [SerializeField] GameObject[] TruePhonics;
        private int currentIndex;
        public void Reveal()
        {
            WhitePhonics[currentIndex].SetActive(false);
            TruePhonics[currentIndex].SetActive(true);
            currentIndex++;
        }
        public void SetWordBox(Word word)
        {
            WordBox = Instantiate(word.GetWordBox(), WordBox.transform);
            for(int i = 0; i < 3; i++)
            {
                WhitePhonics[i] = WordBox.transform.GetChild(i).gameObject;
                TruePhonics[i] = WordBox.transform.GetChild(i + 3).gameObject;
            }
        }
    }
}
