using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers.Abstractions
{
    public abstract class ButtonsManager<T> : Manager<T> where T : class
    {
        [SerializeField] protected GameObject[] Buttons;
        protected Button[] _buttons;
        protected void Start()
        {
            _buttons = new Button[Buttons.Length];
            for (int i = 0; i < Buttons.Length; i++)
            {
                _buttons[i] = Buttons[i].GetComponent<Button>();
            }
            Init();
        }
        protected abstract void Init();
        public void ShowButton(Enum eSelectPageButton, bool status)
        {
            Buttons[(int)(object)eSelectPageButton].SetActive(status);
        }
    }
}
