using System;
using System.Threading.Tasks;
using UnityEngine;

namespace TybaStr.Core
{
    public class Unit : MonoBehaviour
    {
        [SerializeField] private UnitStats _stats;
        public event Action OnUnitStatsChanged;
        [SerializeField] private Vector2 _to;
        
        public Vector2 FindDirection(Vector2 pos,Vector2 to)
        {
            return (to - pos).normalized;
        }
        public async Task MoveTo(Vector2 toLine)
        {
            _to = toLine;
            Vector2 way = FindDirection(transform.position, _to);
            while (true)
            {
                Move(way);
                await Task.Yield();
            }

        }
        public void Move(Vector2 input)
        {
            transform.Translate(input * _stats.Speed * Time.deltaTime);
        }
#if UNITY_EDITOR
        private void OnValidate()
{
            OnUnitStatsChanged?.Invoke();
}
#endif


    }

}