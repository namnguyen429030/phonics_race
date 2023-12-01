using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Datas.Abstractions
{
    public abstract class Database<T> : ScriptableObject where T : ScriptableObject
    {
        [SerializeField] protected T[] Objects;
        public int Count
        {
            get { return Objects.Length; }
        }
        public T SelectObject(int index)
        {
            return Objects[index];
        }
        public T[] GetObjects()
        {
            return (T[])Objects.Clone();
        }
    }
}
