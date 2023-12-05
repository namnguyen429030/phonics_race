using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers.Abstractions
{
    public abstract class PanelsManager<T> : Manager<T> where T : class
    {
        [SerializeField] protected GameObject[] panels;
        public void ShowPanel(EHomePanel ePanel, bool status)
        {
            panels[(int)ePanel].SetActive(status);
        }
    }
}
