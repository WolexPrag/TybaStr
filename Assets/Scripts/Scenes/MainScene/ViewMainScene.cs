using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;

namespace TybaStr.MVVM.MainScene
{
    public class ViewMainScene : MonoBehaviour,IView
    {
        [SerializeField] private ViewModelMainScene _viewModel;

        [SerializeField] private Button _settingButton;
        [SerializeField] private Button _playButton;

        public void Init(ViewModelMainScene viewModel)
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
