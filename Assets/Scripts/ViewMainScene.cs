using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;

namespace TybaStr.MVVM.MainScene
{
    public class ViewMainScene : MonoBehaviour
    {
        [SerializeField] private ViewModelMainScene _viewModel;
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _settingButton;
        public void Init(ViewModelMainScene viewModel)
        {
            _viewModel = viewModel; 
            _playButton.onClick.AddListener(OnPlay);
            _settingButton.onClick.AddListener(OnSetting);
        }
        private void OnPlay()
        {
            _viewModel.LoadPlayScene();
        }
        private void OnSetting()
        {

        }
    }
}
