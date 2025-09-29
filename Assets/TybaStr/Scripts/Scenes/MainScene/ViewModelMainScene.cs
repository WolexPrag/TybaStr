using R3;
using System;
using TybaStr.SaveLoad;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TybaStr.MVVM.MainScene
{
    [Serializable]
    public class ViewModelMainScene
    {
        [SerializeField] private ModelMainScene _model;
        public Observable<string> OnChangeUserName => _model.Profile.OnChangeName;
        public string Name { get { return _model.Profile.Name; } set { _model.Profile.Name = value; _saveLoadService.Save(_key, _model.Profile.Name); } }

        private IView _viewSettings;
        private IView _viewMain;

        private ISaveLoadService _saveLoadService;
        private string _key => "Profile";


        public ViewModelMainScene(ISaveLoadService saveLoadService)
        {
            _saveLoadService = saveLoadService;
        }
        public void Init(ModelMainScene model, IView viewMain, IView viewSettings)
        {
            _model = model;
            _saveLoadService.TryLoad(_key, _ =>
            {
                if (!_)
                {
                    _model.Profile = new UserProfile();
                    return;
                }
                _saveLoadService.Load<string>(_key, v =>
                {
                    _model.Profile.Name = v;
                });
            });
            _viewMain = viewMain;
            _viewSettings = viewSettings;
        }
        public void OnPlay()
        {
            SceneManager.LoadScene(1);
        }
        public void OnMain()
        {
            _viewMain.Show();
            _viewSettings.Hide();
        }
        public void OnSettings()
        {
            _viewMain.Hide();
            _viewSettings.Show();
        }

    }
}