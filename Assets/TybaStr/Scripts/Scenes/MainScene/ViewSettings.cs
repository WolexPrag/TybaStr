using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TybaStr.Scenes.MainScene
{
    public class ViewSettings : MonoBehaviour, IView
    {
        [SerializeField] private ViewModel _viewModel;
        [SerializeField] private TMP_InputField _inputField;
        [SerializeField] private Button _toMainButton;

        public void Init(ViewModel viewModel)
        {
            _viewModel = viewModel;
            _viewModel.OnChangeProfile += () => { SetTextInputField(_viewModel.Name); };
            _inputField.onEndEdit.AddListener(v => _viewModel.Name = v);
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
