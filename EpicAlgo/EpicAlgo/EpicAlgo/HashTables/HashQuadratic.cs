using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using EpicAlgo.Interfaces;

namespace EpicAlgo.HashTables
{
    sealed class HashQuadratic<K,T> : IHashTable<K,T>
    {

        private KeyValuePair<K, T>[] table;
        private double loadFactor { get { if (Count == 0) return 0; else return table.Length / Count; } }
        public int Count { private set; get; }

        public HashQuadratic(){
            table = new KeyValuePair<K, T>[16];
            Count = 0;
        }

        public T this[K key]
        {
            get
            {
                if (!Contains(key))
                {
                    throw new ArgumentOutOfRangeException("There is no such element in the table!");
                }
                int attempt = 0;
                while (attempt <= Count)
                {
                    if (table[GetIndex(key, attempt)].Key.Equals(key))
                    {
                        return table[GetIndex(key, attempt)].Value;
                    }
                    attempt++;
                }
                return default(T);
            }
        }

        public void Add(K key, T value)
        {
            ResizeIfRequires();
            int attempt = 0;
            int index;
            while (true)
            {
                index = GetIndex(key, attempt);
                if (table[index].Equals(default(KeyValuePair<K, T>)))
                {
                    table[index] = new KeyValuePair<K, T>(key, value);
                    Count++;
                    return;
                }
                attempt++;
            }
        }

        public void Clear()
        {
            table = new KeyValuePair<K, T>[16];
            Count = 0;
        }

        public bool Contains(K key)
        {
            int attempt = 0;
            while (attempt <= Count)
            {
                if (table[GetIndex(key, attempt)].Key.Equals(key))
                {
                    return true;
                }
                attempt++;
            }
            return false;
        }

        public int FindIndexOfKey(K key)
        {
            if (!Contains(key))
            {
                throw new ArgumentOutOfRangeException("There is no such element in the table!");
            }
            int attempt = 0;
            while (attempt <= Count)
            {
                if (table[GetIndex(key, attempt)].Key.Equals(key))
                {
                    return GetIndex(key, attempt);
                }
                attempt++;
            }
            return default(Int32);
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int GetIndex(K key, int attempt)
        {
            return Convert.ToInt32(Math.Abs((key.GetHashCode() + Math.Pow(attempt, 2)) % table.Length));
        }

        public void Remove(K key)
        {
            if (!Contains(key))
            {
                throw new ArgumentOutOfRangeException("There is no such element in the table!");
            }
            int index = FindIndexOfKey(key);
            table[index] = default(KeyValuePair<K, T>);
            Count--;
        }

        public void ResizeIfRequires()
        {
            if (loadFactor < 0.75)
            {
                return;
            }
            KeyValuePair<K, T>[] newTable = new KeyValuePair<K, T>[table.Length * 2];
            for (int i = 0; i < table.Length; i++)
            {
                newTable[i] = table[i];
            }
            table = newTable;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
