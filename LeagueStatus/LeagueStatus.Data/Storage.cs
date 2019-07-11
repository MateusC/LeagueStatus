using Cloudcrate.AspNetCore.Blazor.Browser.Storage;
using System;

namespace LeagueStatus.Data
{
    public class Storage : IStorage
    {
        private readonly LocalStorage _localStorage;

        public Storage(LocalStorage localStorage)
        {
            _localStorage = localStorage;
        }

        public T Get<T>(String key)
        {
            var data = _localStorage.GetItem<T>(key);

            return data ?? default(T);
        }

        public void Set<T>(String key, T data)
        {
            _localStorage.SetItem(key, data);
        }

        public void Clear()
        {
            _localStorage.Clear();
        }
    }
}
