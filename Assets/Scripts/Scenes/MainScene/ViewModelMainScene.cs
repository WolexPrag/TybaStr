using System;
using TybaStr.SaveLoad;
using UnityEngine;
using UnityEngine.SceneManagement;
using R3;

namespace TybaStr.MVVM.MainScene
{
    [Serializable]
    public class ViewModelMainScene
    {
        [SerializeField] private ModelMainScene _model;
        private ISaveLoadService _saveLoadService;
        private IView _viewSettings;
        private IView _viewMain;
        private string _key = "Profile";

        public Observable<string> OnUpdateUserName => _model.Profile.OnChangeName;

        public void Init(ModelMainScene model,ViewMainScene viewMain,ViewMainSceneSettings viewSettings,ISaveLoadService saveLoadService)
        {
            _model = model;
            _viewMain = viewMain;
            _viewSettings = viewSettings;
            _saveLoadService = saveLoadService;
        }
        public void LoadPlayScene()
        {
            SceneManager.LoadScene(1);
            Debug.LogWarning("TODO: Refactor How Load Scene");
        }
        public void OnMain()
        {
            _saveLoadService.Save("Profile",_model.Profile);

            _viewMain.Show();
            _viewSettings.Hide();
        }
        public void OnSetting()
        {
            _saveLoadService.TryLoad(_key, isExist => {
                if (isExist)
                {
                    _saveLoadService.Load<UserProfile>(_key, _ => _model.Profile = _);
                }
            });
            
            _viewMain.Hide();
            _viewSettings.Show();
        }
        public void OnUserNameChange(string value)
        {
            _model.Profile.Name = value;
        }

    }
}