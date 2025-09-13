using TMPro;
using UnityEngine;
using R3;
using UnityEngine.UI;
namespace TybaStr.MVVM.MainScene
{
    public class ViewMainSceneSettings : MonoBehaviour,IView
    {
        [SerializeField] private ViewModelMainScene _viewModel;
        [SerializeField] private TMP_InputField _inputField;
        [SerializeField] private Button _toMainButton;

        public void Init(ViewModelMainScene viewModel)
        {
            _viewModel = viewModel;
            _viewModel.OnChangeUserName.Subscribe(SetTextInputField);
            _inputField.onEndEdit.AddListener(v =>_viewModel.Name = v);
            _toMainButton.onClick.AddListener(_viewModel.OnMain);
        }
        
        private void SetTextInputField(string value)
        {
            _inputField.text = value;
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
