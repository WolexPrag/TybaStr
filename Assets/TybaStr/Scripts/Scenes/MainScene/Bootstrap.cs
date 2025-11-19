using TybaStr.SaveLoad;
using TybaStr.Scenes.MainScene;
using UnityEngine;

namespace TybaStr.Scenes.MainScene
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private ViewModel _viewModel;
        [SerializeField] private Model _model;

        [SerializeField] private View _view;
        [SerializeField] private ViewSettings _viewSettings;

        private void Awake()
        {
            _model = new Model();
            _viewModel = new ViewModel(new JsonToFileSaveLoadService());
            _viewModel.Init(_model, _view, _viewSettings);

            _viewSettings.Init(_viewModel);
            _view.Init(_viewModel);
        }

    }
}