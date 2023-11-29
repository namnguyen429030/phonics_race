using Assets.Scripts.Abtractions.Singletons.Managers;
using Assets.Scripts.Datas.ScriptableObjects;
using Assets.Scripts.Enums;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

namespace Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers
{
    public class SoundManager : Manager<SoundManager>
    {
        [SerializeField] private Sound[] Sounds;
        [SerializeField] private Sound[] phonics;
        [SerializeField] private AudioSource[] sources;
        [SerializeField] private AudioSource[] phonicsSources;
        private void Start()
        {
            sources = new AudioSource[Sounds.Length];
            phonicsSources = new AudioSource[4];
            for(int i = 0; i < Sounds.Length; i++)
            {
                Sound sound = Sounds[i];
                AudioSource source = gameObject.AddComponent<AudioSource>();
                source.clip = sound.GetAudioClip();
                source.outputAudioMixerGroup = sound.GetMixer();
                source.loop = sound.IsLoop();
                source.playOnAwake = sound.PlayOnAwake();
                sources[i] = source;
            }
            for (int i = 0; i < phonics.Length; i++)
            {
                Sound phonic = phonics[i];
                AudioSource source = gameObject.AddComponent<AudioSource>();
                source.clip = phonic.GetAudioClip();
                source.outputAudioMixerGroup = phonic.GetMixer();
                source.loop = phonic.IsLoop();
                phonicsSources[i] = source;
            }
            PlaySound(ESound.MainGameBGM);
            PlaySound(ESound.CrowDefault);
        }
        public void PlaySound(ESound eSound)
        {
            sources[(int)eSound].Play();
        }
        public void SetWord(Word word)
        {
            phonics = word.GetPhonicsSound();
        }
        public void PlayPhonic(int index)
        {
            phonicsSources[index].Play();
        }
    }
}
