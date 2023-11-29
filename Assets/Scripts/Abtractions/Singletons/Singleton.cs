using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Abtractions.Singletons
{
    public abstract class Singleton<T> : MonoBehaviour where T : class
    {
        public static T Instance { get; private set; }
        protected void Awake()
        {
            Instance = this as T;
        }
    }
}
