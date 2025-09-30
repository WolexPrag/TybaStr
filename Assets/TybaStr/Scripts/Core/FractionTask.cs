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
        public Unit Unit { get { return _unit; } }
        [SerializeField] private TypeTask _type;
        public TypeTask Type { get { return _type; } }

        public FractionTask(Unit unit,TypeTask type)
        {
            _unit = unit;
            _type = type;
        }
    }
}
