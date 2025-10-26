using System;
using UnityEngine;

namespace TybaStr.Core
{
    public enum TypeTask
    {
        Use,
        Move,
        Attack,
        Follow,
        Defence,
    }
    [Serializable]
    public struct FractionTask
    {
        [SerializeField] private Unit _unit;
        public Unit Unit => _unit;
        [SerializeField] private TypeTask _type;
        public TypeTask Type => _type;
        [SerializeField] private Transform _target;
        public Transform Target => _target;

        public FractionTask(Unit unit,TypeTask type,Transform target = null)
        {
            _unit = unit;
            _type = type;
            _target = target;
        }
    }
}
