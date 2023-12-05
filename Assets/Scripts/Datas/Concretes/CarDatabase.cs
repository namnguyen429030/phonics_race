using Assets.Scripts.Datas.Abstractions;
using Assets.Scripts.Datas.ScriptableObjects;
using UnityEngine;

namespace Assets.Scripts.Datas.Concretes
{
    [CreateAssetMenu(fileName = "CarDatabase", menuName = "ScriptableObjects/Database/CarDatabase", order = 1)]
    public class CarDatabase : VehicleDatabase<Car>
    {
        
    }
}
