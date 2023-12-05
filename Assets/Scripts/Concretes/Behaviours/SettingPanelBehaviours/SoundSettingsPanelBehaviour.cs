using Assets.Scripts.Abtractions.Behaviours;
using Assets.Scripts.Concretes.Singletons.Managers;
using Assets.Scripts.Enums.UIs;

namespace Assets.Scripts.Concretes.Behaviours
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
