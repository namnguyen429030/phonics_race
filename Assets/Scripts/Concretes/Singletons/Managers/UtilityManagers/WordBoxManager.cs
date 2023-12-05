using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Datas.ScriptableObjects;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers
{
    public class WordBoxManager : Manager<WordBoxManager>
    {
        [SerializeField] GameObject WordBox;
        [SerializeField] GameObject[] WhitePhonics;
        [SerializeField] GameObject[] TruePhonics;
        private int currentIndex;
        Animator _animator;
        private void Start()
        {
            _animator = WordBox.GetComponent<Animator>();
        }
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
                WhitePhonics[i].transform.parent = WordBox.transform;
                TruePhonics[i] = WordBox.transform.GetChild(i + 3).gameObject;
                TruePhonics[i].transform.parent = WordBox.transform;
            }
        }
        public IEnumerator RevealEnding()
        {
            for(int i = 0; i < 3; i++)
            {
                WhitePhonics[i].SetActive(false);
                TruePhonics[i].SetActive(true);
                SoundManager.Instance.PlayPhonic(i);
                yield return new WaitForSeconds(2f);
            }
            SoundManager.Instance.PlayPhonic(3);
        }
        public void ShowWordBox()
        {
            for (int i = 0; i < 3; i++)
            {
                WhitePhonics[i].SetActive(true);
                TruePhonics[i].SetActive(false);
            }
            _animator.enabled = true;
        }
    }
}
