/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using EpicAlgo.Interfaces;

namespace EpicAlgo.HashTables
{
    public class HashQuadratic<K,T> : IHashTableDict<K,T>
    {
        public HashQuadratic()
        {
            table = new KeyValuePair<K, T>[16];
            Count = 0;
        }

        private KeyValuePair<K, T>[] table;
        private double loadFactor { get { if (Count == 0) return 0; else return table.Length / Count; } }
        public int Count { private set; get; }

        public ICollection<K> Keys => (from kvp in table select kvp.Key).Distinct().ToList();

        public ICollection<T> Values => (from kvp in table select kvp.Value).Distinct().ToList();

        public bool IsReadOnly => throw new NotImplementedException();

        T IDictionary<K, T>.this[K key]
        {
            get
            {
                if (!ContainsKey(key))
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
            set => throw new NotImplementedException(); }

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


        public int FindIndexOfKey(K key)
        {
            if (!ContainsKey(key))
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
            foreach (var entry in table)
            {
                if (!entry.Equals(default(KeyValuePair<K, T>)))
                {
                    yield return entry;
                }
            }
        }

        public int GetIndex(K key, int attempt)
        {
            return Convert.ToInt32(Math.Abs((key.GetHashCode() + Math.Pow(attempt, 2)) % table.Length));
        }
        

        private void ResizeIfRequires()
        {
            if (loadFactor < 0.50)
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

        public bool ContainsKey(K key)
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

        bool IDictionary<K, T>.Remove(K key)
        {
            if (!ContainsKey(key))
            {
                throw new ArgumentOutOfRangeException("There is no such element in the table!");
                return false;
            }
            int index = FindIndexOfKey(key);
            table[index] = default(KeyValuePair<K, T>);
            Count--;
            return true;
        }

        public bool TryGetValue(K key, [MaybeNullWhen(false)] out T value)
        {
            throw new NotImplementedException();
        }

        public void Add(KeyValuePair<K, T> item)
        {
            var key = item.Key;
            var value = item.Value;
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

        public bool Contains(KeyValuePair<K, T> item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<K, T>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<K, T> item)
        {
            var k = item.Key;

            if (base.Remove(k))
            {
                return true;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        /*
IEnumerator IEnumerable.GetEnumerator()
{
   return ((IEnumerable<KeyValuePair<K, T>>)this).GetEnumerator();
}
    }
}*/
