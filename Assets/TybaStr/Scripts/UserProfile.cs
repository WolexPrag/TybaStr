using R3;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TybaStr
{
    [Serializable]
    public class UserProfile
    {
        [SerializeField] private readonly ReactiveProperty<string> _name = new();
        public Observable<string> OnChangeName => _name;
        public string Name { get { return _name.Value; } set { _name.Value = value; } }

        [SerializeField] private readonly ReactiveProperty<Image> _Icon = new();
        public Observable<Image> OnChangeIcon => _Icon;
        public Image Icon { get { return _Icon.Value; } set { _Icon.Value = value; } }
    }
}