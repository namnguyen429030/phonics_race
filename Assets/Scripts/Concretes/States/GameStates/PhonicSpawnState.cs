using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Concretes.Singletons.StateMachines;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
