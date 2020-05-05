using EpicAlgo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Timer
{
    public interface ITestCollection<K, T> : IHashTable<K, T>, ITree<T>
    {
        void Add(IHashTable<K, T> hashtable, K k,T t);
        ITree<T> Add(ITree<T> Tree, T data);
        
    }
}
