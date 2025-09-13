using System.Collections;
using System.Collections.Generic;
using TybaStr.MVVM.MainScene;
using TybaStr.SaveLoad;
using UnityEngine;

public class BootstrapMainMenu : MonoBehaviour
{
    [SerializeField] private ViewModelMainScene _viewModel;
    [SerializeField] private ModelMainScene _model;

    [SerializeField] private ViewMainScene _view;
    [SerializeField] private ViewMainSceneSettings _viewSettings;

    private void Awake()
    {
        _model = new ModelMainScene();
        _viewModel = new ViewModelMainScene(new JsonToFileSaveLoadService());
        _viewModel.Init(_model,_view,_viewSettings);

        _viewSettings.Init(_viewModel);
        _view.Init(_viewModel);
    }

}
