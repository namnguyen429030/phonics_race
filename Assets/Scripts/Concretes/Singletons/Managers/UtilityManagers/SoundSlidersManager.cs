using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers.Abstractions;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers.HomePage;
using Assets.Scripts.Enums.UIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Audio;

namespace Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers
{
    public class SoundSlidersManager : SlidersManager<SoundSlidersManager>
    {
        public override void Init()
        {
            _sliders[(int)ESoundSlider.MainVolume].onValueChanged.AddListener(SetMainVolume);
            _sliders[(int)ESoundSlider.Music].onValueChanged.AddListener(SetMusicVolume);
            _sliders[(int)ESoundSlider.Sfx].onValueChanged.AddListener(SetSfxVolume);
            _sliders[(int)ESoundSlider.Voice].onValueChanged.AddListener(SetVoiceVolume);
        }
        public void Load()
        {
            SetSliderValue((int)ESoundSlider.MainVolume, SoundManager.Instance.Setting.MainVolume);
            SetSliderValue((int)ESoundSlider.Music, SoundManager.Instance.Setting.MusicVolume);
            SetSliderValue((int)ESoundSlider.Sfx, SoundManager.Instance.Setting.SfxVolume);
            SetSliderValue((int)ESoundSlider.Voice, SoundManager.Instance.Setting.VoiceVolume);
        }
        protected void SetMainVolume(float volume)
        {
            SoundManager.Instance.SetMixerVolume(SoundManager.MIXER_MAIN, MathF.Log10(volume) * 20);
        }

        protected void SetMusicVolume(float volume)
        {
            SoundManager.Instance.SetMixerVolume(SoundManager.MIXER_MUSIC, MathF.Log10(volume) * 20);
        }

        protected void SetSfxVolume(float volume)
        {
            SoundManager.Instance.SetMixerVolume(SoundManager.MIXER_SFX, MathF.Log10(volume) * 20);
        }

        protected void SetVoiceVolume(float volume)
        {
            SoundManager.Instance.SetMixerVolume(SoundManager.MIXER_VOICE, MathF.Log10(volume) * 20);
        }
    }
}