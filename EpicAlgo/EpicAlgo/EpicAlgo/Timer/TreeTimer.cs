﻿using EpicAlgo.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EpicAlgo.Timer
{
    public class TreeTimer<T> : ITreeComparison<T>
    {
        /// <summary>The tree</summary>
        private List<ICollection<T>> Tree = new List<ICollection<T>>();
        
        /// <summary>Making global dictionaries with time stamps.</summary>
        private Dictionary<ICollection<T>, Stopwatch> InsertDictionary { get; set; } = new Dictionary<ICollection<T>, Stopwatch>();
        
        /// <summary>Making global dictionaries with time stamps.</summary>
        private Dictionary<ICollection<T>, Stopwatch> RemoveDictionary { get; set; } = new Dictionary<ICollection<T>, Stopwatch>();

        /// <summary>Initializes a new instance of the <see cref="TreeTimer{T}" /> class.</summary>
        /// <param name="tree">The tree.</param>
        public TreeTimer(List<ICollection<T>> tree)
        {
            Tree = tree;
        }

        /// <summary>Initializes a new instance of the <see cref="TreeTimer{T}" /> class.</summary>
        /// <param name="tree">The tree.</param>
        public TreeTimer(ICollection<T> tree)
        {
            Tree.Add(tree);
        }

        public TreeTimer()
        {

        }

        public void AddCollection(ICollection<T> tree)
        {
            Tree.Add(tree);
        }

        public void AddCollection(List<ICollection<T>> tree)
        {
            foreach (var item in tree)
            {
                Tree.Add(item);
            }

        }

        /// <summary>Takes the time of inserting items.</summary>
        /// <param name="t">The t.</param>
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

        /// <summary>Takes the time of inserting items to a list.</summary>
        /// <param name="t">The t.</param>
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

        /// <summary>Takes the time to removing items.</summary>
        /// <param name="t">The t.</param>
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

        /// <summary>Takes the time to removing items of a list.</summary>
        /// <param name="t">The t.</param>
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

        /// <summary>Prints the insert time.</summary>
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

        /// <summary>Prints the remove time.</summary>
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

        /// <summary>Prints this instance.</summary>
        public void Print()
        {
            PrintInsert();
            PrintRemove();
        }
    }
}
