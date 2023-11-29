using Assets.Scripts.Abtractions.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Concretes.Behaviours.MoveBehaviours
{
    public class BackgroundMoveBehaviour : MoveBehaviour
    {
        Renderer _renderer;
        protected void Start()
        {
            _renderer = GetComponent<Renderer>();
        }
        protected override void Move()
        {
            _renderer.material.mainTextureOffset += new Vector2(Time.deltaTime * Velocity, 0f);
        }
        public override void MoveToTarget()
        {
            
        }
    }
}
