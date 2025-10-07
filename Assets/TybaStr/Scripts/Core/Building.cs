using UnityEngine;

namespace TybaStr.Core
{
    public abstract class Building : MonoBehaviour
    {
        private Fraction _belong;
        public Fraction Belong => _belong;
    }
}
