using EpicAlgo.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EpicAlgo.Timer
{
    class HashTimer<K,T> : ITimeComparison<K,T>
    {
        List<IHashTableDict<K, T>> HashTable;
        Dictionary<IHashTableDict<K, T>, Stopwatch> dict = new Dictionary<IHashTableDict<K, T>, Stopwatch>();

        public HashTimer(List<IHashTableDict<K, T>> hashtable)
        {
            HashTable = hashtable;
        }

        public HashTimer(IHashTableDict<K, T> hashtable)
        {
            HashTable.Add(hashtable);
        }


        public void TakeTime(K k, T t)
        {

            foreach (IHashTableDict<K, T> hashtable in HashTable)
            {

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                hashtable.Add(k, t);
                stopwatch.Stop();

                dict.Add(hashtable, stopwatch);
                
            }

        }

        public void TakeTime(KeyValuePair<K,T>[] kvp)
        {

            foreach (IHashTableDict<K, T> hashtable in HashTable)
            {

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                foreach (var item in kvp)
                {
                    hashtable.Add(item);
                }
                stopwatch.Stop();

                dict.Add(hashtable, stopwatch);
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
