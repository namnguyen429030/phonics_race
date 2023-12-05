using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Datas.ScriptableObjects;
using Assets.Scripts.Enums;
using Assets.Scripts.Implementations;
using Assets.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.Audio;

namespace Assets.Scripts.Concretes.Singletons.Managers
{
    public class SoundManager : Manager<SoundManager>
    {
        [SerializeField] protected Sound[] Sounds;
        [SerializeField] protected AudioMixer mixerGroup;
        protected Sound[] Phonics;
        protected AudioSource[] sources;
        protected AudioSource[] phonicsSources;
        protected IDataManage<PlayerSoundSettings> settingDataManage;
        public PlayerSoundSettings Setting {  get; private set; }

        public const string MIXER_MAIN = "MainVolume";
        public const string MIXER_MUSIC = "Music";
        public const string MIXER_SFX = "Sfx";
        public const string MIXER_VOICE = "Voice";
        private void Start()
        {
            Init();
            DontDestroyOnLoad(this);
        }
        public virtual void Init()
        {
            settingDataManage = new SettingDataManage();
            LoadSoundSetting();

            SetMixerVolume(MIXER_MAIN, Setting.MainVolume);
            SetMixerVolume(MIXER_VOICE, Setting.VoiceVolume);
            SetMixerVolume(MIXER_MUSIC, Setting.MusicVolume);
            SetMixerVolume(MIXER_SFX, Setting.SfxVolume);

            sources = new AudioSource[Sounds.Length];
            for (int i = 0; i < Sounds.Length; i++)
            {
                Sound sound = Sounds[i];
                AudioSource source = gameObject.AddComponent<AudioSource>();
                source.clip = sound.GetAudioClip();
                source.outputAudioMixerGroup = sound.GetMixer();
                source.loop = sound.IsLoop();
                if (sound.PlayOnAwake())
                {
                    source.Play();
                }
                sources[i] = source;
            }
            
        }
        public void PlaySound(ESound sound)
        {
            sources[(int)(object)sound].Play();
        }
        public void Pause()
        {
            foreach(AudioSource source in sources)
            {
                if (source.outputAudioMixerGroup.name != "BGM")
                {
                    source.Pause();
                }
            }
        }
        public void Resume()
        {
            foreach (AudioSource source in sources)
            {
                if (source.outputAudioMixerGroup.name != "BGM")
                {
                    source.UnPause();
                }
            }
        }
        public void StopAll()
        {
            foreach (AudioSource source in sources)
            {
                source.Stop();
            }
        }
        public void SetMixerVolume(string name, float volume)
        {
            mixerGroup.SetFloat(name, volume);
        }

        public void PlayPhonic(int index)
        {
            phonicsSources[index].Play();
        }
        public void SetWord(Word word)
        {
            Phonics = word.GetPhonicsSound();
            phonicsSources = new AudioSource[Phonics.Length];
            for (int i = 0; i < Phonics.Length; i++)
            {
                Sound sound = Phonics[i];
                AudioSource source = gameObject.AddComponent<AudioSource>();
                source.clip = sound.GetAudioClip();
                source.outputAudioMixerGroup = sound.GetMixer();
                source.loop = sound.IsLoop();
                source.playOnAwake = sound.PlayOnAwake();
                phonicsSources[i] = source;
            }
        }
        public void SaveSoundSettings()
        {
            settingDataManage.Save(Setting);
        }
        public void LoadSoundSetting()
        {
            Setting = settingDataManage.Load();
        }
    }
}
