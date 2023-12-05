using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.Singletons.Managers;
using Assets.Scripts.Concretes.Singletons.StateMachines;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Concretes.States.GameStates
{
    public class PhonicSpawnState : GameState
    {
        protected override IEnumerator Sequence()
        {
            PhonicsSpawnManager.Instance.SpawnObject();
            yield return new WaitForSeconds(5f);
            if (GameStateMachine.Instance.GetCurrentState() is PhonicSpawnState)
            {
                GameStateMachine.Instance.HandleMissPhonicState();
            }
        }
    }
}
