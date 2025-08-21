using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using R3;
using TybaStr.MVVM.GameScene;


public class BootstrapPlayScene<T> :MonoBehaviour
{
    [SerializeField] private ViewGameScene _view;
    [SerializeField] private ViewModelGameScene _viewModel;
    [SerializeField] private ModelGameScene _model;
    private void Awake()
    {
        _viewModel.Init(_model);
        _view.Init(_viewModel);
    }
    //IDEA: Example: class ViewModel<T> where T : Model {...}
    //class ViewModel3<Model3> {...}
    //class Model{...}
    //class Model3: Model{...}
}
