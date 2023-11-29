using Assets.Scripts.Abtractions.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Concretes.Behaviours.MoveBehaviours
{
    public class NonBackgroundMoveBehaviour : MoveBehaviour
    {
        GameObject TargetLane;
        protected override void Move()
        {
            transform.position += Velocity * Direction * Time.deltaTime;
        }
        public override void MoveToTarget()
        {
            if (TargetLane != null)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, TargetLane.transform.position.y), Velocity * Time.deltaTime * 2);
            }
        }
        public void SetDestination(GameObject targetLane)
        {
            TargetLane = targetLane;
        }
    }
}
