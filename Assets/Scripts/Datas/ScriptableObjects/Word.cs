using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Datas.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Word", menuName = "ScriptableObjects/Objects/Word", order = 2)]
    public class Word : ScriptableObject
    {
        [SerializeField] GameObject[] Phonics;
        [SerializeField] Sound[] PhonicsSound;
        [SerializeField] GameObject WordBox;
        public GameObject[] GetPhonics()
        {
            return Phonics;
        }
        public Sound[] GetPhonicsSound()
        {
            return PhonicsSound;
        }
        public GameObject GetWordBox()
        {
            return WordBox;
        }
    }
}
