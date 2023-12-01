using Assets.Scripts.Abtractions.Singletons.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers.UIManagers.HomePage
{
    public class HomeSlidersManager : Manager<HomeSlidersManager>
    {
        [SerializeField] GameObject MainVolumeSlider, MusicSlider, SfxSlider, VoiceSlider;
        Slider mainVolumeSlider, musicSlider, sfxSlider, voiceSlider;
        AudioMixerGroup mainVolumeMixer, musicMixer, sfxMixer, voiceMixer;
        private void Start()
        {
            
        }
    }
}
