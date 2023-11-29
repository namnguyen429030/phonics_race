using Assets.Scripts.Datas.Abstractions;
using Assets.Scripts.Datas.ScriptableObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Datas.ConcretesConcretes
{
    [CreateAssetMenu(fileName = "WordDatabase", menuName = "ScriptableObjects/Database/WordDatabase", order = 2)]
    public class WordDatabase : Database<Word>
    {

    }
}
