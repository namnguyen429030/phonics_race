using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers.Abstractions;
using Assets.Scripts.Concretes.Singletons.StateMachines;
using Assets.Scripts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers.SelectPage
{
    public class SelectPageButtonsManager : ButtonsManager<SelectPageButtonsManager>
    {
        protected override void Init()
        {
            _buttons[(int)ESelectPageButton.ConfirmButton].onClick.AddListener(() => Confirm());
        }
        private void Confirm()
        {
            SelectionPageStateMachine.Instance.HandleConfirmState();
        }
    }
}
