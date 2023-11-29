using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Abtractions.Behaviours
{
    public abstract class CollideBehaviour : MonoBehaviour
    {
        protected abstract void OnTriggerEnter2D(Collider2D collider);
    }
}
