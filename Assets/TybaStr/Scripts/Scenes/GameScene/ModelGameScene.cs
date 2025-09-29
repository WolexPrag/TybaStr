using UnityEngine;

namespace TybaStr.MVVM.GameScene
{
    public class ModelGameScene
    {
        [SerializeField] private UserProfile _profile = new();
        public UserProfile Profile { get { return _profile; } set { _profile = value; } }
    }
}