using UnityEngine;

namespace TybaStr.Scenes.GameScene
{
    [AddComponentMenu("GameScene/View")]
    public class View : MonoBehaviour
    {
        private ViewModel _viewModel;
        public void Init(ViewModel viewModel)
        {
            _viewModel = viewModel;
        }
    }
}