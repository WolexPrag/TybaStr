using System.Collections;
using System.Collections.Generic;
using TybaStr.MVVM.MainScene;
using UnityEngine;
using TybaStr;

public class BootstrapMainMenu : MonoBehaviour
{
    [SerializeField] private ViewModelMainScene _viewModel;
    [SerializeField] private ViewMainScene _view;
    [SerializeField] private ModelMainScene _model;
    private void Awake()
    {
        _model = new ModelMainScene();
        _viewModel = new ViewModelMainScene();
        _viewModel.Init(_model);
        _view.Init(_viewModel);
    }

}
