using System;
using UnityEngine;

namespace TybaStr.Core
{
    [Serializable]
    public class UnitStats
    {
        [SerializeField] private float _health;
        public float Health
        {
            get { return _health; }
            set { _health = value;}
        }
        [SerializeField] private float _midHealth;
        public float MidHealth
        {
            get { return _midHealth; }
        }
        public float HealthBonus
        {
            get
            {
                float cofficient = Health / MidHealth;
                if (cofficient >= 1.5)
                {
                    return 1.5f;
                }
                else if(cofficient < 0.5)
                {
                    return 0f;
                }
                return cofficient;
            }
        }
        [SerializeField] private float _midSpeed;
        public float Speed
        {
            get
            {
                return _midSpeed * HealthBonus;
            }
        }
    }
}
