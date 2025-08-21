using System.Collections;
using System.Collections.Generic;
using TybaStr;
using UnityEngine;

namespace TybaStr.MVVM.GameScene
{
    public class ModelGameScene
    {
        private UserProfile _userProfile;
        public UserProfile UserProfile => _userProfile;
        public ModelGameScene(UserProfile userProfile)
        {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
            _userProfile = userProfile;
        }
    }
}