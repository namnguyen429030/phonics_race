using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Audio;

namespace Assets.Scripts.Datas.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Sound", menuName = "ScriptableObjects/Utilities/Sound", order = 1)]
    public class Sound : ScriptableObject
    {
        [SerializeField] AudioClip audioClip;
        [SerializeField] AudioMixerGroup mixer;
        [SerializeField] bool isLoop;
        [SerializeField] bool playOnAwake;
        public AudioClip GetAudioClip() { return audioClip; }
        public AudioMixerGroup GetMixer() {  return mixer; }
        public bool IsLoop() { return isLoop; }
        public bool PlayOnAwake() { return playOnAwake; }
    }
}
