using EpicAlgo.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EpicAlgo.Timer
{
    class HashTimer<K,T> : IHashComparison<K,T>
    {
        List<IHashTableCollection<K, T>> HashTable = new List<IHashTableCollection<K, T>>();
        Dictionary<IHashTableCollection<K, T>, Stopwatch> InsertDictionary = new Dictionary<IHashTableCollection<K, T>, Stopwatch>();
        Dictionary<IHashTableCollection<K, T>, Stopwatch> RemoveDictionary = new Dictionary<IHashTableCollection<K, T>, Stopwatch>();

        public HashTimer(List<IHashTableCollection<K, T>> hashtable)
        {
            HashTable = hashtable;
        }

        public HashTimer(IHashTableCollection<K, T> hashtable)
        {
            HashTable.Add(hashtable);
        }

        public void InsertTime(K k, T t)
        {
            foreach (IHashTableCollection<K, T> hashtable in HashTable)
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
            foreach (IHashTableCollection<K, T> hashtable in HashTable)
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


            foreach (IHashTableCollection<K, T> hashtable in HashTable)
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
            foreach (IHashTableCollection<K, T> hashtable in HashTable)
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
            foreach (IHashTableCollection<K, T> hashtable in HashTable)
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


            foreach (IHashTableCollection<K, T> hashtable in HashTable)
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
