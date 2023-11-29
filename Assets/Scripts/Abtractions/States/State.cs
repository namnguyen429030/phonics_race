using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Abtractions.States
{
    public abstract class State : MonoBehaviour
    {
        protected void Start()
        {
            StartCoroutine(Sequence());
        }
        protected abstract IEnumerator Sequence();
    }
}
