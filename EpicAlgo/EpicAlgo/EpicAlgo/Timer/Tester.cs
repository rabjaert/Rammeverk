using EpicAlgo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Timer
{
    public class Tester<K,T> : TestClass<K,T>
    {
        List<ITree<T>> itArray;
        List<IHashTable<K, T>> htArray;
        public Tester(List<ITree<T>> tre, List<IHashTable<K, T>> ht)
        {
            this.itArray = tre;
            this.htArray = ht;
        }

        public void Add(T item)
        {
            base.Add(itArray[0], item);
        }

        public void print()
        {
            foreach (ITree<T> it in itArray)
            {
                Console.WriteLine(it.ToString());
            }
        }



    }
}
