using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.SelectionManagers;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers.Abstractions;
using Assets.Scripts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers.MainGame
{
    public class MainGameButtonsManager : ButtonsManager<MainGameButtonsManager>
    {
        protected override void Init()
        {
            _buttons[(int)EGameButton.PauseButton].onClick.AddListener(Pause);
            _buttons[(int)EGameButton.ResumeButton].onClick.AddListener(Resume);
            _buttons[(int)EGameButton.ReplayButton].onClick.AddListener(Replay);
            _buttons[(int)EGameButton.BackToHomeButton].onClick.AddListener(BackToHome);
            _buttons[(int)EGameButton.NextPhonicButton].onClick.AddListener(NextPhonic);
        }
        private void Pause()
        {
            Time.timeScale = 0;
            MainGamePanelsManager.Instance.ShowPanel(EHomePanel.SettingPanel, true);
            SoundManager.Instance.Pause();
        }
        private void Resume()
        {
            Time.timeScale = 1;
            MainGamePanelsManager.Instance.ShowPanel(EHomePanel.SettingPanel, false);
            SoundManager.Instance.Resume();
        }
        private void Replay()
        {
            SceneManager.LoadSceneAsync("MainGame");
        }
        private void BackToHome()
        {
            Destroy(SoundManager.Instance.gameObject);
            SceneManager.LoadSceneAsync("HomePage");
        }
        private void NextPhonic()
        {
            CarRaceSelectionManager.Instance.SelectWord();
            SceneManager.LoadSceneAsync("MainGame");
        }
    }
}
