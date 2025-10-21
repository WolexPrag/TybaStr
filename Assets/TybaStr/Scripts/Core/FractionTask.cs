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
        [SerializeField] private ITarget _target;
        public ITarget Target => _target;

        public FractionTask(Brain brain,TypeTask type, ITarget target = null)
        {
            _brain = brain;
            _type = type;
            _target = target;
        }
    }
    public interface ITarget
    {
        public Vector2 Position { get; }
    }
    public class MovableTarget : ITarget
    {
        private Transform _transform;
        public MovableTarget(Transform transform)
        {
            _transform = transform;
        }
        public Vector2 Position => _transform.position;
    }
    public class PointTarget : ITarget
    {
        private Vector2 _position;
        public PointTarget(Vector2 position)
        {
            _position = position;
        }
        public Vector2 Position => _position;
    }
    }
}
