using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts.Abtractions.Behaviours
{
    public abstract class MoveBehaviour : MonoBehaviour
    {
        [SerializeField] protected float Velocity;
        [SerializeField] protected Vector3 Direction;
        protected virtual void Update()
        {
            Move();
            MoveToTarget();
        }
        protected abstract void Move();
        public abstract void MoveToTarget();
        public float GetVelocity()
        {
            return Velocity;
        }
        public void SetVelocity(float velocity)
        {
            Velocity = velocity;
        }
        public void SetDirection(Vector3 direction)
        {
            Direction = direction;
        }
        public Vector3 GetDirection()
        {
            return Direction;
        }

    }
}
