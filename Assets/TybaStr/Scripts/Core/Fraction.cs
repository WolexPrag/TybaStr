using System;
using System.Collections.Generic;
using UnityEngine;

namespace TybaStr.Core
{
    [Serializable]
    public class Fraction
    {
        [SerializeField] private string _name;
        public string Name => _name;
        [SerializeField] private List<Brain> _brains;
        public IReadOnlyList<Brain> Brains => _brains;
        public Fraction(string name)
        {
            _name = name;
            _brains = new List<Brain>();
        }
        public void AssignTask(Brain brain,FractionTask task)
        {
            if (!_brains.Contains(brain))
            {
                throw new Exception("Brain is not part of this fraction");
            }
            brain.AssignTask(task);
        }
        private Brain AddBrain(Brain brain)
        {
            _brains.Add(brain);
            return brain;
        }
        public Brain GetBrain(Unit unit) 
        {
            return AddBrain(new Brain(this)); 
        }
    }
}

