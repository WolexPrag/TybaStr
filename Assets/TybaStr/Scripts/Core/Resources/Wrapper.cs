
using UnityEngine;

namespace TybaStr.Core.Resources
{
    [System.Serializable]
    public abstract class Wrapper : ScriptableObject
    {
        public abstract IResourceType Type { get; }
        public abstract int Amount { get; }
    }
}
