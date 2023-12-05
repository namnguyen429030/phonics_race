using Assets.Scripts.Abtractions.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Abtractions.Singletons.Managers
{
    public abstract class MovingManager<T> : Manager<T> where T : class
    {
        [SerializeField] protected GameObject ManagedObject;
        protected MoveBehaviour ObjectMovement;
        protected virtual void Start()
        {
            if (ManagedObject != null)
            {
                ObjectMovement = ManagedObject.GetComponent<MoveBehaviour>();
            }
        }
        public GameObject GetObject() 
        {
            return ManagedObject; 
        }
        public void SetVelocity(float velocity)
        {
            ObjectMovement.SetVelocity(velocity);
        }
        public void SetDirection(Vector3 direction)
        {
            ObjectMovement.SetDirection(direction);
        }
    }
}
