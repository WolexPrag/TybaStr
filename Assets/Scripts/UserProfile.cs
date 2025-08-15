using R3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TybaStr
{

    public class UserProfile
    {
        [SerializeField] private ReactiveProperty<string> _name;
        public Observable<string> OnChangeName => _name;
        public string Name { get { return _name.Value; } set { _name.Value = value; } }

        [SerializeField] private ReactiveProperty<Image> _Icon;
        public Observable<Image> OnChangeIcon => _Icon;
        public Image Icon { get { return _Icon.Value; } set { _Icon.Value = value; } }
    }
}