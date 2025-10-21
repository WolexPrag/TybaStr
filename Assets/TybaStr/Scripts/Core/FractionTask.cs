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
        [SerializeReference] private Brain _brain;
        public Brain Brain => _brain;
        [SerializeField] private TypeTask _type;
        public TypeTask Type => _type;
        [SerializeField] private Transform _target;
        public Transform Target => _target;

        public FractionTask(Brain brain,TypeTask type,Transform target = null)
        {
            _brain = brain;
            _type = type;
            _target = target;
        }
    }
}
