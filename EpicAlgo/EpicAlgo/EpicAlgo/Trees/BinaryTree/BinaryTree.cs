using System;
using System.Collections.Generic;
using System.Text;
using EpicAlgo.Interfaces;

namespace EpicAlgo.Trees.BinaryTree
{
    class BinaryTree<T> : IBinaryTree<T>
    {

        public BinaryNode<T> Root;
        private Comparer<T> Comparer;

        public BinaryTree(Comparer<T> comparer)
        {
            this.Root = null;
            this.Comparer = comparer;

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

        public bool Contains(IBinaryNode<T> root, T data)
        {
            throw new NotImplementedException();
        }

        public IBinaryNode<T> DeleteNode(IBinaryNode<T> node, T data)
        {
            throw new NotImplementedException();
        }

        public IBinaryNode<T> InsertNode(IBinaryNode<T> node, T data)
        {
            throw new NotImplementedException();
        }

        public T MinValue(IBinaryNode<T> root)
        {
            throw new NotImplementedException();
        }

        public void PrintInOrder(IBinaryNode<T> root)
        {
            throw new NotImplementedException();
        }

        public void PrintPostOrder(IBinaryNode<T> root)
        {
            throw new NotImplementedException();
        }

        public void PrintPreOrder(IBinaryNode<T> root)
        {
            throw new NotImplementedException();
        }
    }
}
