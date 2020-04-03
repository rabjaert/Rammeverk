using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Interfaces
{
    interface IHashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        //nice
        void ResizeIfRequires();
        int GetIndex(K key, int attempt);
        void Add(K key, T value);
        int FindIndexOfKey(K key);
        bool Contains(K key);
        void Remove(K key);
        void Clear();

    }
}
