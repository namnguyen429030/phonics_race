using Assets.Scripts.Abtractions.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Concretes.Behaviours
{
    public class NonBackgroundMoveBehaviour : MoveBehaviour
    {
        protected override void Move()
        {
            transform.position += Velocity * Direction * Time.deltaTime;
        }
        public void SetDestination(GameObject targetLane)
        {
            Target = targetLane;
        }
    }
}
