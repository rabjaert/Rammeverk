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
        Dictionary<IHashTableCollection<K, T>, Stopwatch> dict = new Dictionary<IHashTableCollection<K, T>, Stopwatch>();

        public HashTimer(List<IHashTableCollection<K, T>> hashtable)
        {
            HashTable = hashtable;
        }

        public HashTimer(IHashTableCollection<K, T> hashtable)
        {
            HashTable.Add(hashtable);
        }


        public void TakeTime(K k, T t)
        {

            foreach (IHashTableCollection<K, T> hashtable in HashTable)
            {
                KeyValuePair<K, T> kvp = new KeyValuePair<K, T>(k, t);
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                hashtable.Add(kvp);
                dict.Add(hashtable, stopwatch);
                stopwatch.Stop();

                
                
            }

        }

        public void TakeTime(Dictionary<K,T> kvp)
        {

            foreach (IHashTableCollection<K, T> hashtable in HashTable)
            {

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                foreach (var item in kvp)
                {
                    hashtable.Add(item);
                }
                dict.Add(hashtable, stopwatch);
                stopwatch.Stop();

                
            }

        }

        public void Print()
        {
            foreach (var item in dict)
            {
                int seconds = item.Value.Elapsed.Seconds;
                int miliseconds = item.Value.Elapsed.Milliseconds;

                Console.WriteLine("HashTable: " + item.Key + " Time: " + seconds + " Seconds, " + miliseconds + " Miliseconds");
            }
        }
    }
}
