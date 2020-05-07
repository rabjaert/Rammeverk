using EpicAlgo.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EpicAlgo.Timer
{
    public class TreeTimer<T> : ITreeComparison<T>
    {
        List<ITree<T>> Tree = new List<ITree<T>>();
        Dictionary<ITree<T>, Stopwatch> Dict = new Dictionary<ITree<T>, Stopwatch>();

        public TreeTimer(List<ITree<T>> tree)
        {
            Tree = tree;
        }

        public TreeTimer(ITree<T> tree)
        {
            Tree.Add(tree);
        }
        public void TakeTime(T t)
        {
            foreach (ITree<T> tree in Tree)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                tree.Add(t);
                Dict.Add(tree, stopwatch);
                stopwatch.Stop();

                
            }
        }

        public void TakeTimeList(List<T> t)
        {
            foreach (ITree<T> tree in Tree)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                tree.AddList(t);
                Dict.Add(tree, stopwatch);
                stopwatch.Stop();


            }
        }

        public void Print()
        {
            foreach (var item in Dict)
            {
                int seconds = item.Value.Elapsed.Seconds;
                int miliseconds = item.Value.Elapsed.Milliseconds;

                Console.WriteLine("HashTable: " + item.Key + " Time: " + seconds + " Seconds, " + miliseconds + " Miliseconds");
            }
        }
    }
}
