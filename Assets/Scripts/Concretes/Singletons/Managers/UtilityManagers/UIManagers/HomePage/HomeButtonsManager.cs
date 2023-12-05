using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers.Abstractions;
using Assets.Scripts.Enums;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers.HomePage
{
    public class HomeButtonsManager : ButtonsManager<HomeButtonsManager>
    {
        protected override void Init()
        {
            _buttons[(int)EHomeButton.PlayButton].onClick.AddListener(Play);
            _buttons[(int)EHomeButton.QuitButton].onClick.AddListener(Quit);
            _buttons[(int)EHomeButton.SettingButton].onClick.AddListener(() => ShowSetting(true));
            _buttons[(int)EHomeButton.QuitSettingButton].onClick.AddListener(() => ShowSetting(false));
            _buttons[(int)EHomeButton.HideUIButton].onClick.AddListener(() => ShowUI(false));
            _buttons[(int)EHomeButton.ShowUIButton].onClick.AddListener(() => ShowUI(true));
        }
        private void Play()
        {
            SceneManager.LoadSceneAsync("SelectPage");
            SoundManager.Instance.StopAll();
        }
        private void Quit()
        {
            Application.Quit();
        }
        private void ShowSetting(bool status)
        {
            HomePanelsManager.Instance.ShowPanel(EHomePanel.SettingPanel,status);
        }
        private void ShowUI(bool status)
        {
            for (int i = 0; i < Buttons.Length; i++)
            {
                if (i == (int)EHomeButton.ShowUIButton)
                {
                    Buttons[i].SetActive(!status);
                }
                else
                {
                    Buttons[i].SetActive(status);
                }
            }
        }
    }
}
