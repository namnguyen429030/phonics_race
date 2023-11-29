using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Concretes.Singletons.Managers.UtilityManagers;
using Assets.Scripts.Concretes.Singletons.StateMachines;
using Assets.Scripts.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Concretes.States.GameStates
{
    public class MissPhonicState : GameState
    {
        public static int missCount = 0;
        protected override IEnumerator Sequence()
        {
            missCount++;
            DisappointedCrewSpawnManager.Instance.SpawnObject();
            SoundManager.Instance.PlaySound(ESound.CrowdDisappointing);
            PhonicsSpawnManager.Instance.RecallObject();
            yield return new WaitForSeconds(5f);
            GameStateMachine.Instance.HandleSpawnPhonicState();
            DisappointedCrewSpawnManager.Instance.RecallObject();
            if(missCount == 3)
            {
                GameStateMachine.Instance.HandleGuidingState();
            }
        }
    }
}
