using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Interfaces
{
    interface IHashTable<Key, Type> : IEnumerable<KeyValuePair<Key, Type>>
    {
        //nice
        void ResizeIfRequires();

        int GetIndex();
        void Add();
        int FindIndexOfKey();
        bool Contains();
        void Remove();
        void Clear();

    }
}
