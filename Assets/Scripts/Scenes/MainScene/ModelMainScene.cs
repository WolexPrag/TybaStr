using System;
using UnityEngine;
using R3;
using UnityEngine.SceneManagement;

namespace TybaStr.MVVM.MainScene
{
    [Serializable]
    public class ModelMainScene
    {
        [SerializeField]private UserProfile _profile;
        public UserProfile Profile => _profile;
        public ModelMainScene()
        {
            _profile = new UserProfile();
        }
    }
}