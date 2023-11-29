using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Abtractions.Behaviours
{
    public abstract class BeTouchBehaviour : MonoBehaviour
    {
        public abstract void OnTouch();
    }
}
