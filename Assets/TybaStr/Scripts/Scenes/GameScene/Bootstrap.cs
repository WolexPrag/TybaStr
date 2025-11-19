using TybaStr.InputActions;
using TybaStr.SaveLoad;
using UnityEngine;

namespace TybaStr.Scenes.GameScene
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private GameInputActions _inputActions;
        [SerializeField] private PlayerCamera _playerCamera;

        [SerializeField] private View _view;
        private ViewModel _viewModel;
        private Model _model;

        private void Awake()
        {
            Init();
            Activate();
        }
        private void Init()
        {
            InitMVVM();
            _inputActions = new GameInputActions();
        }
        private void InitMVVM()
        {
            _model = new Model();
            _viewModel = new ViewModel(new JsonToFileSaveLoadService());
            _viewModel.Init(_model);
            _view.Init(_viewModel);
        }
        private void Activate()
        {
            _inputActions.Enable();
            _playerCamera.SetInput(_inputActions.Camera.Hold, _inputActions.Camera.Point);
        }
    }
}