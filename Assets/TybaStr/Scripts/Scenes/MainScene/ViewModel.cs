using System;
using TybaStr.SaveLoad;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TybaStr.Scenes.MainScene
{
    [Serializable]
    public class ViewModel
    {
        [SerializeField] private Model _model;
        public string Name { get { return _model.Profile.Name; } set { _model.Profile.Name = value; } }
        public event Action OnChangeProfile;

        private IView _viewSettings;
        private IView _viewMain;

        private ISaveLoadService _saveLoadService;
        private string _key => "Profile";


        public ViewModel(ISaveLoadService saveLoadService)
        {
            _saveLoadService = saveLoadService;
        }
        public void Init(Model model, IView viewMain, IView viewSettings)
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
            _model.Profile.OnChange += () => { OnChangeProfile?.Invoke(); };
            OnChangeProfile += () => { _saveLoadService.Save(_key, Name); };
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