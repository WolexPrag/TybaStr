using System;
using UnityEngine;

namespace TybaStr.Scenes.MainScene
{
    [Serializable]
    public class Model
    {
        [SerializeField] private UserProfile _profile = new();
        public UserProfile Profile { get { return _profile; } set { _profile = value; } }

    }
}