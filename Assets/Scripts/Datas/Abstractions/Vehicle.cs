﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Datas.Abstractions
{
    public abstract class Vehicle : ScriptableObject
    {
        [SerializeField] GameObject GameObject;
        [SerializeField] GameObject UIGameObject;
        public GameObject GetGameObject()
        {
            return GameObject;
        }
        public GameObject GetUIGameObject()
        {
            return UIGameObject;
        }
    }
}