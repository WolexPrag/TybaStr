using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TybaStr.SaveLoad
{
    public interface ISaveLoadService
    {
        void Save(string key,object data, Action<bool> callback = null);
        void Load<T>(string key,Action<T> callback);
        void TryLoad(string key, Action<bool> callback);
    }
}
