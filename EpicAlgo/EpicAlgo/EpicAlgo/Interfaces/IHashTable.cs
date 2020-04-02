using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Interfaces
{
    interface IHashTable<Key, Type> : IEnumerable<KeyValuePair<Key, Type>>
    {
        //nice
        void ResizeIfRequires();
        int GetIndex(Key key, int attempt);
        void Add(Key key, Type value);
        int FindIndexOfKey(Key key);
        bool Contains(Key key);
        void Remove(Key key);
        void Clear();

    }
}
