using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TybaStr.MVVM.MainScene
{
    [Serializable]
    public class ViewModelMainScene
    {
        [SerializeField] private ModelMainScene _model;

        public void Init(ModelMainScene model)
        {
            _model = model;
        }
        public void LoadPlayScene()
        {
            SceneManager.LoadScene(_model.PlayScene.name);
        }
    }
}