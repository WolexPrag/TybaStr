using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TybaStr.MVVM.GameScene
{
    public class ViewGameScene : MonoBehaviour
    {
        private ViewModelGameScene _viewModel;
        public void Init(ViewModelGameScene viewModel)
        {
            _viewModel = viewModel;
        }
    }
}