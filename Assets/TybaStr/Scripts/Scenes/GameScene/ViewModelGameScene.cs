using TybaStr.SaveLoad;

namespace TybaStr.MVVM.GameScene
{
    public class ViewModelGameScene
    {
        private ModelGameScene _model;

        private ISaveLoadService _saveLoadService;
        private string _key = "Profile";

        public ViewModelGameScene(ISaveLoadService saveLoadService)
        {
            _saveLoadService = saveLoadService;
        }
        public void Init(ModelGameScene model)
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