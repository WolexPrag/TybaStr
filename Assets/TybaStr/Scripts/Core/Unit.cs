using System;
 using UnityEngine;

namespace TybaStr.Core
{
    public class Unit : MonoBehaviour
    {
        [SerializeField] private UnitStats _stats;
        public event Action OnUnitStatsChanged;
        [SerializeField] private Brain _brain;
        public Vector2 Position => transform.position;
        public Brain Brain
        {
            get
            {
                return _brain;
            }
            set
            {
                _brain = value;
                _brain.Bind(this);
            }
        }
        private void FixedUpdate()
        {
            if (Brain != null)
            {
                Brain.Tick(Time.fixedDeltaTime);
            }
        }
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