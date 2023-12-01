using Assets.Scripts.Abtractions.Singletons.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers.HomePage
{
    public class HomePanelsManager : Manager<HomePanelsManager>
    {
        [SerializeField] GameObject settingPanel;
        public void ShowSetting(bool status)
        {
            settingPanel.SetActive(status);
        }
    }
}
