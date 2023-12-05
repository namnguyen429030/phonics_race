using Assets.Scripts.Abtractions.Singletons.Managers;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Concretes.Singletons.Managers
{
    public abstract class SlidersManager<T> : Manager<T> where T : class
    {
        [SerializeField] protected GameObject[] Sliders;
        protected Slider[] _sliders;
        protected void Start()
        {
            _sliders = new Slider[Sliders.Length];
            for(int i = 0; i< Sliders.Length; i++)
            {
                _sliders[i] = Sliders[i].GetComponent<Slider>();
            }
            Init();
        }
        public abstract void Init();
        public float GetVolumeValue(int index)
        {
            return MathF.Log10(_sliders[index].value) * 20;
        }
        protected void SetSliderValue(int index, float value)
        {
            _sliders[index].value = MathF.Pow(10, (value / 20));
        }
    }
}
