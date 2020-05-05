using EpicAlgo.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Timer
{
    public abstract class TestClass<K,T> : ITestCollection<K, T>
    {

        public void Add(IHashTable<K,T> kt, K item, T item2)
        {
            kt.Add(item, item2);
        }

        public ITree<T> Add(ITree<T> tree, T item)
        {
            tree.AddData(item);
            return tree;
        }

        public void Add(K key, T value)
        {
            throw new NotImplementedException();
        }

        public void AddData(T data)
        {
            throw new NotImplementedException();
        }

        public void AddDataArray(T[] data)
        {
            throw new NotImplementedException();
        }

        public void AddDataList(List<T> data)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(K key)
        {
            throw new NotImplementedException();
        }

        public int FindIndexOfKey(K key)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int GetIndex(K key, int attempt)
        {
            throw new NotImplementedException();
        }

        public void PrintInOrder(INode<T> root)
        {
            throw new NotImplementedException();
        }

        public void PrintInOrder(ITree<T> Tree, INode<T> data)
        {
            Tree.PrintInOrder(data);
        }

        public void PrintInOrder(IBinaryNode<T> root)
        {
            throw new NotImplementedException();
        }

        public void Remove(K key)
        {
            throw new NotImplementedException();
        }

        public void ResizeIfRequires()
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
