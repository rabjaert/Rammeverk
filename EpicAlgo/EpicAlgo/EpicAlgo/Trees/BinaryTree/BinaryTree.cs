using EpicAlgo.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Trees.BinaryTree
{
    public class BinaryTree<T> : AbstractBinaryTree<T>, ITree<T>
    {

        public BinaryTree(Comparer<T> comparer)
        {
            base.Root = null;
            base.Comparer = comparer;

        }
        
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            AddData(item);
        }

        public void AddArray(T[] data)
        {
            for (var i = 0; i < data.Length; i++)
            {
                AddData(data[i]);
            }
        }

        public void AddList(List<T> data)
        {
            for (var i = 0; i < data.Count; i++)
            {
                AddData(data[i]);
            }
        }
        public T FindData(T data)
        {
            return base.FindNode(Root, data).GetData();
        }

        public void Clear()
        {
            DeleteTree(Root);
        }

        public bool Contains(T item)
        {
            return RContains(Root, item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void PrintInOrder()
        {
            base.PrintInOrder(Root);
        }

        public void PrintPostOrder()
        {
            base.PrintPostOrder(Root);
        }

        public void PrintPreOrder()
        {
            base.PrintPreOrder(Root);
        }

        public bool Remove(T item)
        {
            if (DeleteNode(Root, item).GetData().Equals(item))
            {
                return true;
            }
            else return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
