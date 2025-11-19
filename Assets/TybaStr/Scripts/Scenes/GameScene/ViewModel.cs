using TybaStr.SaveLoad;

namespace TybaStr.Scenes.GameScene
{
    public class ViewModel
    {
        private Model _model;

        private ISaveLoadService _saveLoadService;
        private string _key = "Profile";

        public ViewModel(ISaveLoadService saveLoadService)
        {
            _saveLoadService = saveLoadService;
        }
        public void Init(Model model)
        {
            _model = model;
            _saveLoadService.TryLoad(_key, _ =>
            {
                if (_)
                {
                    _saveLoadService.Load<string>(_key, v =>
                    {
                        _model.Profile.Name = v;
                    });
                }

            });
        }

    }
}