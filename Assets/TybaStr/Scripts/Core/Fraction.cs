using System.Collections.Generic;
using UnityEngine;

namespace TybaStr.Core
{
    public class Fraction
    {
        [SerializeField] private List<Brain> _brains;
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

