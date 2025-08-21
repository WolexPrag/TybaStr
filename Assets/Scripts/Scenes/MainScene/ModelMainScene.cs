using System;
using UnityEngine;
using R3;
using UnityEngine.SceneManagement;

namespace TybaStr.MVVM.MainScene
{
    [Serializable]
    public class ModelMainScene
    {
        [SerializeField]private UserProfile _profile = new();
        public UserProfile Profile { get { return _profile; }set { _profile = value; } }
        
    }
}