using Assets.Scripts.Datas.Abstractions;
using Assets.Scripts.Datas.ScriptableObjects;
using UnityEngine;

namespace Assets.Scripts.Datas.ConcretesConcretes
{
    [CreateAssetMenu(fileName = "WordDatabase", menuName = "ScriptableObjects/Database/WordDatabase", order = 2)]
    public class WordDatabase : Database<Word>
    {

    }
}
