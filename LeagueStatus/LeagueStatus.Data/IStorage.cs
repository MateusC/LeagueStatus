using System;

namespace LeagueStatus.Data
{
    public interface IStorage
    {
        void Set<T>(String key, T data);

        T Get<T>(String key);

        void Clear();
    }
}