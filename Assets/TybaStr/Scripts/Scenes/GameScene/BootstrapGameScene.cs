using TybaStr.InputActions;
using TybaStr.MVVM.GameScene;
using TybaStr.SaveLoad;
using UnityEngine;


public class BootstrapGameScene : MonoBehaviour
{
    [SerializeField] private GameInputActions _inputActions;
    [SerializeField] private PlayerCamera _playerCamera;


    [SerializeField] private ViewGameScene _view;
    private ViewModelGameScene _viewModel;
    private ModelGameScene _model;


    private void Awake()
    {
        Init();
        Activate();
    }
    private void Init()
    {
        _model = new ModelGameScene();
        _viewModel = new ViewModelGameScene(new JsonToFileSaveLoadService());
        _inputActions = new GameInputActions();
        _viewModel.Init(_model);
        _view.Init(_viewModel);
    }
    private void Activate()
    {
        _inputActions.Enable();
        _playerCamera.SetInput(_inputActions.Camera.Hold, _inputActions.Camera.Point);
    }
}
