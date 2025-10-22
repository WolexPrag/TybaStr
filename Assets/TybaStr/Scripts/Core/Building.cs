using UnityEngine;

namespace TybaStr.Core
{
    public abstract class Building : MonoBehaviour
    {
        private Fraction _belong;
        public Fraction Belong { get { return _belong; } set { _belong = value; } }
    }
}
