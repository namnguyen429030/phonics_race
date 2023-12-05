using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

namespace Assets.Scripts.Abtractions.Behaviours
{
    public abstract class MoveBehaviour : MonoBehaviour
    {
        [SerializeField] protected float Velocity;
        [SerializeField] protected Vector3 Direction;
        protected GameObject Target;
        protected virtual void Update()
        {
            Move();
            MoveToTarget();
        }
        protected abstract void Move();
        public void MoveToTarget()
        {
            if (Target != null)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, Target.transform.position.y), Velocity * Time.deltaTime * 2);
            }
        }
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
