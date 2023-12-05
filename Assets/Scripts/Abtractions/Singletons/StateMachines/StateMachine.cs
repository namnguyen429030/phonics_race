using Assets.Scripts.Abtractions.States;
using System;
using UnityEngine;

namespace Assets.Scripts.Abtractions.Singletons
{
    public abstract class StateMachine<T1, T2> : Singleton<T1> where T1 : class where T2 : State
    {
        [SerializeField] protected GameObject CurrentState;
        public State GetCurrentState()
        {
            return CurrentState.GetComponent<State>();
        }
    }
}
