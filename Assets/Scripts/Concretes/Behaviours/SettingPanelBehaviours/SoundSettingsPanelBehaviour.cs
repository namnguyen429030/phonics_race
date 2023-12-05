using Assets.Scripts.Abtractions.Behaviours;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers;
using Assets.Scripts.Enums.UIs;
using Assets.Scripts.Implementations;
using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Concretes.Behaviours.SettingPanelBehaviours
{
    public class SoundSettingsPanelBehaviour : SettingsPanelBehaviour
    {
        protected override void OnDisable()
        {
            PlayerSoundSettings setting = SoundManager.Instance.Setting;
            setting.MainVolume = SoundSlidersManager.Instance.GetVolumeValue((int)ESoundSlider.MainVolume);
            setting.MusicVolume = SoundSlidersManager.Instance.GetVolumeValue((int)ESoundSlider.Music);
            setting.SfxVolume = SoundSlidersManager.Instance.GetVolumeValue((int)ESoundSlider.Sfx);
            setting.VoiceVolume = SoundSlidersManager.Instance.GetVolumeValue((int)ESoundSlider.Voice);
            SoundManager.Instance.SaveSoundSettings();
        }

        protected override void OnEnable()
        {
            SoundSlidersManager.Instance.Load();
        }
    }
}
