using UnityEngine;

namespace TybaStr.MVVM.GameScene
{
    public class ViewModelGameScene
    {
        private ModelGameScene _model;
        public void Init(ModelGameScene model)
        {
            _model = model;
        }
    }
}