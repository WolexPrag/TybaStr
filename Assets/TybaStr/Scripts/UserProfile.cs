using System;
using UnityEngine;
using UnityEngine.UI;

namespace TybaStr
{
    [Serializable]
    public class UserProfile
    {
        [SerializeField] private string _name;
        public string Name { get { return _name; } set { _name = value; OnChange?.Invoke(); } }

        [SerializeField] private Image _icon;
        public Image Icon { get { return _icon; } set { _icon = value; OnChange?.Invoke(); } }
        
        public event Action OnChange;
        
        public UserProfile(string name = null, Image icon = null)
        {
            _name = name;
            _icon = icon;
        }
    }
}