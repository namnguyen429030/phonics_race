using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.Singletons.StateMachines;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Concretes.States.GameStates
{
    public class TutorialState : GameState
    {
        protected override IEnumerator Sequence()
        {
            yield return new WaitForSeconds(3);
            GameStateMachine.Instance.HandleSpawnPhonicState();
        }
    }
}
