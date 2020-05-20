using EpicAlgo.Timers.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EpicAlgo.Timers.Timer
{
    public class HashTimer<K,T> : IHashComparison<K,T>
    {
        /// <summary>The hash table</summary>
        private List<ICollection<KeyValuePair<K, T>>> HashTable = new List<ICollection<KeyValuePair<K, T>>>();
        public Dictionary<ICollection<KeyValuePair<K, T>>, Stopwatch> InsertDictionary {  get; private set; } = new Dictionary<ICollection<KeyValuePair<K, T>>, Stopwatch>();
        public Dictionary<ICollection<KeyValuePair<K, T>>, Stopwatch> RemoveDictionary { get; private set; } = new Dictionary<ICollection<KeyValuePair<K, T>>, Stopwatch>();

        /// <summary>Initializes a new instance of the <see cref="HashTimer{K, T}" /> class.</summary>
        /// <param name="hashtable">The hashtable.</param>
        public HashTimer(List<ICollection<KeyValuePair<K, T>>> hashtable)
        {
            HashTable = hashtable;
        }

        /// <summary>Initializes a new instance of the <see cref="HashTimer{K, T}" /> class.</summary>
        /// <param name="hashtable">The hashtable.</param>
        public HashTimer(ICollection<KeyValuePair<K, T>> hashtable)
        {
            HashTable.Add(hashtable);
        }

        public HashTimer()
        {

        }

        public void AddCollection(ICollection<KeyValuePair<K, T>> hashtable)
        {
            HashTable.Add(hashtable);
        }

        public void AddCollection(List<ICollection<KeyValuePair<K, T>>> hashtable)
        {
            foreach (var item in hashtable)
            {
                HashTable.Add(item);
            }

        }

        /// <summary>Takes the time of inserting items.</summary>
        /// <param name="k">The k.</param>
        /// <param name="t">The t.</param>
        public void TakeTimeOfInsert(KeyValuePair<K,T> item)
        {
            foreach (ICollection<KeyValuePair<K, T>> hashtable in HashTable)
            {
                
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                hashtable.Add(item);
                InsertDictionary.Add(hashtable, stopwatch);
                stopwatch.Stop();
            }
        }

        /// <summary>Takes the time of inserting items of a dictionary.</summary>
        /// <param name="dict">The dictionary.</param>
        public void TakeTimeOfInsert(Dictionary<K, T> dict)
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

        /// <summary>Takes the time of inserting items of a list.</summary>
        /// <param name="kvp">The KVP.</param>
        public void TakeTimeOfInsert(List<KeyValuePair<K, T>> kvp)
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

        /// <summary>Takes the time of removing items.</summary>
        /// <param name="k">The k.</param>
        /// <param name="t">The t.</param>
        public void TakeTimeOfRemove(KeyValuePair<K, T> item)
        {
            foreach (ICollection<KeyValuePair<K, T>> hashtable in HashTable)
            {
               
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                hashtable.Remove(item);
                RemoveDictionary.Add(hashtable, stopwatch);
                stopwatch.Stop();
            }
        }

        /// <summary>Takes the time of removing items of a dictionary.</summary>
        /// <param name="dict">The dictionary.</param>
        public void TakeTimeOfRemove(Dictionary<K, T> dict)
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

        /// <summary>Takes the time of removing items of a list.</summary>
        /// <param name="kvp">The KVP.</param>
        public void TakeTimeOfRemove(List<KeyValuePair<K, T>> kvp)
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

        /// <summary>Prints the amount of time it takes to insert.</summary>
        public void PrintTimeOfInsert()
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

        /// <summary>Prints the amount of time it takes to remove.</summary>
        public void PrintTimeOfRemove()
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

        /// <summary>Prints this instance.</summary>
        public void Print()
        {
            PrintTimeOfInsert();
            PrintTimeOfRemove();
        }
    }
}
