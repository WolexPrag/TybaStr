using Newtonsoft.Json;
using System;
using System.IO;
using UnityEngine;

namespace TybaStr.SaveLoad
{
    public class JsonToFileSaveLoadService : ISaveLoadService
    {

        public void Save(string key, object data, Action<bool> callback = null)
        {
            string path = BuildPath(key);
            string json = JsonConvert.SerializeObject(data);

            using(var fileStream = new StreamWriter(path))
            {
                fileStream.Write(json);
            }

            callback?.Invoke(true);
        }
        public void Load<T>(string key, Action<T> callback)
        {
            string path = BuildPath(key);

            using (var fileStream = new StreamReader(path))
            {
                string json = fileStream.ReadToEnd();
                T data = JsonConvert.DeserializeObject<T>(json);

                callback?.Invoke(data);
            }
        }
        private string BuildPath(string key)
        {
            return Path.Combine(Application.persistentDataPath, key);
        }
    }
}
