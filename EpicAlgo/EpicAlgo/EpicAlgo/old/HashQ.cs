﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EpicAlgo.Interfaces;

namespace EpicAlgo.HashTables
{
    sealed class HashQ<K, T> : IHashTableCollection<K, T>
    {

        private List<KeyValuePair<K, T>> table;
        private double loadFactor { get { if (Count == 0) return 0; else return table.Count / Count; } }
        public int Count { private set; get; }

        public bool IsReadOnly => throw new NotImplementedException();

        public HashQ()
        {
            table = new List<KeyValuePair<K, T>>();
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            

            return GetEnumerator();

        }

        public void Add(KeyValuePair<K, T> item)
        {
            Add(item.Key, item.Value);
        }

        public bool Contains(KeyValuePair<K, T> item)
        {
            return Contains(item.Key);
        }

        public void CopyTo(KeyValuePair<K, T>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<K, T> item)
        {
            return Remove(item.Key);
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
            table = new List<KeyValuePair<K, T>>();
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

            /*
            var dictionary = new Dictionary<K, T>();
            foreach (var item in this)
            {
                dictionary.Add(item.Key, item.Value);
            }
            //return new Enumerator(this, Enumerator.KeyValuePair);
            //return (IEnumerator)this;
            //return default(IEnumerator);
            return (IEnumerator)dictionary;
           // return GetEnumerator();
           */
            /*
             KeyValuePair<K,T>[] kvpArray = new KeyValuePair<K,T>[table.Length];


             foreach (KeyValuePair<K, T> p in kvpArray)
             {
                 yield return p;
             }
             */
            return default;
            //return table.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

        }

        public int GetIndex(K key, int attempt)
        {
            return Convert.ToInt32(Math.Abs((key.GetHashCode() + Math.Pow(attempt, 2)) % table.Count));
        }

        public bool Remove(K key)
        {
            if (!Contains(key))
            {
                return false;
                
            }
            
            int index = FindIndexOfKey(key);
            table[index] = default(KeyValuePair<K, T>);
            Count--;
            return true;
        }

        private void ResizeIfRequires()
        {
            if (loadFactor < 0.75)
            {
                table.AddRange(new KeyValuePair<K,T>[table.Count * 2 - table.Count]);
            }
            

        }

        public void Print() {

            foreach (var element in this) {

                Console.WriteLine("Key:" + " " + element.Key
                    + "\n" + "Value:" + " " + element.Value + "\n");
            
            }
        
        
        }

    }
}