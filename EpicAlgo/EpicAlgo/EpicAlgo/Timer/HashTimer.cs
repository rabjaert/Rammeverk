using EpicAlgo.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EpicAlgo.Timer
{
    class HashTimer<K,T> : IHashComparison<K,T>
    {
        List<ICollection<KeyValuePair<K, T>>> HashTable = new List<ICollection<KeyValuePair<K, T>>>();
        Dictionary<ICollection<KeyValuePair<K, T>>, Stopwatch> InsertDictionary = new Dictionary<ICollection<KeyValuePair<K, T>>, Stopwatch>();
        Dictionary<ICollection<KeyValuePair<K, T>>, Stopwatch> RemoveDictionary = new Dictionary<ICollection<KeyValuePair<K, T>>, Stopwatch>();

        public HashTimer(List<ICollection<KeyValuePair<K, T>>> hashtable)
        {
            HashTable = hashtable;
        }

        public HashTimer(ICollection<KeyValuePair<K, T>> hashtable)
        {
            HashTable.Add(hashtable);
        }

        public void InsertTime(K k, T t)
        {
            foreach (ICollection<KeyValuePair<K, T>> hashtable in HashTable)
            {
                KeyValuePair<K, T> kvp = new KeyValuePair<K, T>(k, t);
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                hashtable.Add(kvp);
                InsertDictionary.Add(hashtable, stopwatch);
                stopwatch.Stop();
            }
        }

        public void InsertTime(Dictionary<K, T> dict)
        {
            foreach (ICollection<KeyValuePair<K, T>> hashtable in HashTable)
            {

                
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                foreach (var item in dict)
                {
                    KeyValuePair<K, T> kvp = new KeyValuePair<K, T>(item.Key, item.Value);
                    hashtable.Add(kvp);
                }
                InsertDictionary.Add(hashtable, stopwatch);
                stopwatch.Stop();
            }
        }

        public void InsertTime(List<KeyValuePair<K, T>> kvp)
        {


            foreach (ICollection<KeyValuePair<K, T>> hashtable in HashTable)
            {

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                foreach (var item in kvp)
                {

                    hashtable.Add(item);
                }
                InsertDictionary.Add(hashtable, stopwatch);
                stopwatch.Stop();


            }
        }

        public void RemoveTime(K k, T t)
        {
            foreach (ICollection<KeyValuePair<K, T>> hashtable in HashTable)
            {
                KeyValuePair<K, T> kvp = new KeyValuePair<K, T>(k, t);
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                hashtable.Remove(kvp);
                RemoveDictionary.Add(hashtable, stopwatch);
                stopwatch.Stop();
            }
        }

        public void RemoveTime(Dictionary<K, T> dict)
        {
            foreach (ICollection<KeyValuePair<K, T>> hashtable in HashTable)
            {


                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                foreach (var item in dict)
                {
                    KeyValuePair<K, T> kvp = new KeyValuePair<K, T>(item.Key, item.Value);
                    hashtable.Remove(kvp);
                }
                RemoveDictionary.Add(hashtable, stopwatch);
                stopwatch.Stop();
            }
        }

        public void RemoveTime(List<KeyValuePair<K, T>> kvp)
        {


            foreach (ICollection<KeyValuePair<K, T>> hashtable in HashTable)
            {

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                foreach (var item in kvp)
                {

                    hashtable.Remove(item);
                }
                RemoveDictionary.Add(hashtable, stopwatch);
                stopwatch.Stop();


            }
        }

        public void PrintInsert()
        {
            if (InsertDictionary.Count != 0)
            {
                foreach (var item in InsertDictionary)
                {
                    int seconds = item.Value.Elapsed.Seconds;
                    int miliseconds = item.Value.Elapsed.Milliseconds;

                    Console.WriteLine("Inserted in HashTable in: \n" + "HashTable: " + item.Key + " Time: " + seconds + " Seconds, " + miliseconds + " Miliseconds\n");
                }
            }
        }

        public void PrintRemove()
        {
            if (RemoveDictionary.Count != 0)
            {
                foreach (var item in RemoveDictionary)
                {
                    int seconds = item.Value.Elapsed.Seconds;
                    int miliseconds = item.Value.Elapsed.Milliseconds;

                    Console.WriteLine("Removed from HashTable in: \n" + "HashTable: " + item.Key + " Time: " + seconds + " Seconds, " + miliseconds + " Miliseconds\n");
                }
            }
        }

        public void Print()
        {
            PrintInsert();
            PrintRemove();
        }
    }
}
