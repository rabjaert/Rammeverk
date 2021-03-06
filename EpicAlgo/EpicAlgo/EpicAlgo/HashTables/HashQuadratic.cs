﻿using EpicAlgo.HashTables.Abstract;
using EpicAlgo.HashTables.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace EpicAlgo.HashTables
{
    public class HashQuadratic<K, T> : AbstractHashQuadratic<K,T>, IHashTableCollection<K, T>
    {
        public HashQuadratic()
        {
            Table = new KeyValuePair<K, T>[16];
            base.Count = Count;
        }

        public int Count => base.Count;

        public bool IsReadOnly => base.IsReadOnly;

        public void Add(KeyValuePair<K, T> item)
        {
            base.Add(item);
        }

        public void Clear()
        {
            base.Clear();
        }

        public bool Contains(KeyValuePair<K, T> item)
        {
            return base.Contains(item);
        }
        public bool Contains(K item)
        {
            return base.Contains(item);
        }

        public void CopyTo(KeyValuePair<K, T>[] array, int arrayIndex)
        {
            base.CopyTo(array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            return base.GetEnumerator();
        }

        public bool Remove(KeyValuePair<K, T> item)
        {
            return base.Remove(item.Key);
        }

        public bool Remove(K item)
        {
            return base.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return base.GetEnumerator();
        }

        public void Print()
        {
            base.Print();
        }
    }
}
