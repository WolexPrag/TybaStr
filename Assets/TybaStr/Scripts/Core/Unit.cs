using System;
 using UnityEngine;

namespace TybaStr.Core
{
    public class Unit : MonoBehaviour
    {
        [SerializeField] private UnitStats _stats;
        public event Action OnUnitStatsChanged;
        public void Move(Vector2 direction,float deltaTime)
        {
            float speed = _stats.Speed * deltaTime;
            if (direction.magnitude <= speed)
            {
                transform.Translate(direction);
            }
            else
            {
                transform.Translate(direction.normalized * speed);
            }
            
        }
#if UNITY_EDITOR
        private void OnValidate()
        {
            OnUnitStatsChanged?.Invoke();
        }
#endif


    }

}