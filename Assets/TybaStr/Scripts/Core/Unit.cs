using System;
using System.Threading.Tasks;
using UnityEngine;

namespace TybaStr.Core
{
    public class Unit : MonoBehaviour
    {
        [SerializeField] private UnitStats _stats;
        public event Action OnUnitStatsChanged;

#if UNITY_EDITOR
        private void OnValidate()
{
            OnUnitStatsChanged?.Invoke();
}
#endif


    }

}