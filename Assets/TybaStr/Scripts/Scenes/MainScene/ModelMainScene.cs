using System;
using UnityEngine;

namespace TybaStr.MVVM.MainScene
{
    [Serializable]
    public class ModelMainScene
    {
        [SerializeField] private UserProfile _profile = new();
        public UserProfile Profile { get { return _profile; } set { _profile = value; } }

    }
}