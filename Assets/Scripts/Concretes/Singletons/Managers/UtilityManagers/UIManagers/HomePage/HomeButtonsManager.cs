using Assets.Scripts.Abtractions.Singletons.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers.HomePage
{
    public class HomeButtonsManager : Manager<HomeButtonsManager>
    {
        [SerializeField] GameObject PlayButton, SettingButton, QuitSettingButton, QuitButton, HideUIButton, ShowUIButton;
        Button playButton, settingButton, quitSettingButton, quitButton, hideUIButton, showUIButton;
        private void Start()
        {
            playButton = PlayButton.GetComponent<Button>();
            settingButton = SettingButton.GetComponent<Button>();
            quitSettingButton = QuitSettingButton.GetComponent<Button>();
            quitButton = QuitButton.GetComponent<Button>();
            hideUIButton = HideUIButton.GetComponent<Button>();
            showUIButton = ShowUIButton.GetComponent<Button>();
            playButton.onClick.AddListener(() => Play());
            quitButton.onClick.AddListener(() => Quit());
            settingButton.onClick.AddListener(() => ShowSetting(true));
            quitSettingButton.onClick.AddListener(() => ShowSetting(false));
            hideUIButton.onClick.AddListener(() => ShowUI(false));
            showUIButton.onClick.AddListener(()=> ShowUI(true));
        }
        public void Play()
        {
            SceneManager.LoadSceneAsync("SelectPage");
        }
        public void Quit()
        {
            Application.Quit();
        }
        public void ShowSetting(bool status)
        {
            HomePanelsManager.Instance.ShowSetting(status);
        }
        public void ShowUI(bool status)
        {
            PlayButton.SetActive(status);
            SettingButton.SetActive(status);
            QuitButton.SetActive(status);
            HideUIButton.SetActive(status);
            ShowUIButton.SetActive(!status);
        }
    }
}
