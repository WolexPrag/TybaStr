using TMPro;
using UnityEngine;
using R3;
using UnityEngine.UI;
namespace TybaStr.MVVM.MainScene
{
    public class ViewMainSceneSettings : MonoBehaviour,IView
    {
        [SerializeField] private ViewModelMainScene _viewModel;
        [SerializeField] private Button _toMainButton;
        [SerializeField] private TMP_InputField _inputField;
        public void Init(ViewModelMainScene viewModel)
        {
            _viewModel = viewModel;
            _viewModel.OnUpdateUserName.Subscribe(_=>_inputField.text = _);
            _toMainButton.onClick.AddListener(OnMain);
            _inputField.onEndEdit.AddListener(OnUserNameChange);
        }
        public void OnMain()
        {
            _viewModel.OnMain();
        }
        public void OnUserNameChange(string value)
        {
            _viewModel.OnUserNameChange(value);
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
