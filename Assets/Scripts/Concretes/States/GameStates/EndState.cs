using Assets.Scripts.Abtractions.States;
using Assets.Scripts.Concretes.Singletons.Managers.MovingManagers;
using Assets.Scripts.Concretes.Singletons.Managers.MovingManagers.AnimatedObjectManagers;
using Assets.Scripts.Concretes.Singletons.Managers.SpawnManagers;
using Assets.Scripts.Dictionaries;
using Assets.Scripts.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using UnityEngine;

namespace Assets.Scripts.Concretes.States.GameStates
{
    public class EndState : GameState
    {
        protected override IEnumerator Sequence()
        {
            yield return new WaitForSeconds(2f);
            EnergyBoostSpawnManager.Instance.SpawnObject();
            yield return new WaitForSeconds(3f);
            MainGameManager.Instance.SetVelocity(15f);
            yield return new WaitForSeconds(2f);
            FinishLineSpawnManager.Instance.SpawnObject();
            HappyCrewSpawnManager.Instance.SpawnObject();
            RefereeManager.Instance.SetAnimation(RefereeAnimation.RefereeAnimations[ERefereeAnimation.Finish]);
            yield return new WaitForSeconds(1f);
            MountainManager.Instance.SetVelocity(0);
            RoadManager.Instance.SetVelocity(0);
            TreesManager.Instance.SetVelocity(0f);
            MainGameManager.Instance.SetVelocity(0);
        }
    }
}
