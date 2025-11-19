using UnityEngine;
using UnityEngine.UI;

namespace TybaStr.Scenes.MainScene
{
    public class View : MonoBehaviour, IView
    {
        [SerializeField] private ViewModel _viewModel;

        [SerializeField] private Button _settingButton;
        [SerializeField] private Button _playButton;

        public void Init(ViewModel viewModel)
        {
            _viewModel = viewModel;
            _settingButton.onClick.AddListener(_viewModel.OnSettings);
            _playButton.onClick.AddListener(_viewModel.OnPlay);
        }
        public void Show()
        {
            gameObject.SetActive(true);
        }
        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}
