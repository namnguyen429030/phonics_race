using Assets.Scripts.Abtractions.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Abtractions.Singletons.Managers
{
    public abstract class Manager<T> : Singleton<T> where T : class
    {
        
    }
}
