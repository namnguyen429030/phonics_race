using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Enums;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers
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
