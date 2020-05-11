using EpicAlgo.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EpicAlgo.Timer
{
    public class TreeTimer<T> : ITreeComparison<T>
    {
        List<ICollection<T>> Tree = new List<ICollection<T>>();
        Dictionary<ICollection<T>, Stopwatch> InsertDictionary = new Dictionary<ICollection<T>, Stopwatch>();
        Dictionary<ICollection<T>, Stopwatch> RemoveDictionary = new Dictionary<ICollection<T>, Stopwatch>();

        public TreeTimer(List<ICollection<T>> tree)
        {
            Tree = tree;
        }

        public TreeTimer(ICollection<T> tree)
        {
            Tree.Add(tree);
        }
        public void InsertTime(T t)
        {
            foreach (ICollection<T> tree in Tree)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                tree.Add(t);
                InsertDictionary.Add(tree, stopwatch);
                stopwatch.Stop();

                
            }
        }

        public void InsertTime(List<T> t)
        {
            foreach (ICollection<T> tree in Tree)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                foreach (var item in t)
                {
                    tree.Add(item);
                }
                InsertDictionary.Add(tree, stopwatch);
                stopwatch.Stop();


            }
        }

        public void RemoveTime(T t)
        {
            foreach (ICollection<T> tree in Tree)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                tree.Remove(t);
                RemoveDictionary.Add(tree, stopwatch);
                stopwatch.Stop();


            }
        }

        public void RemoveTime(List<T> t)
        {
            foreach (ICollection<T> tree in Tree)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                foreach (var item in t)
                {
                    tree.Remove(item);
                }
                RemoveDictionary.Add(tree, stopwatch);
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

                    Console.WriteLine("HashTable: " + item.Key + " Time: " + seconds + " Seconds, " + miliseconds + " Miliseconds");
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

                    Console.WriteLine("HashTable: " + item.Key + " Time: " + seconds + " Seconds, " + miliseconds + " Miliseconds");
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
