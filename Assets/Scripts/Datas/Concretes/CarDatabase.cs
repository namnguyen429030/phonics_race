using Assets.Scripts.Datas.Abstractions;
using Assets.Scripts.Datas.ScriptableObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Datas.Concretes
{
    [CreateAssetMenu(fileName = "CarDatabase", menuName = "ScriptableObjects/Database/CarDatabase", order = 1)]
    public class CarDatabase : VehicleDatabase<Car>
    {
        
    }
}
