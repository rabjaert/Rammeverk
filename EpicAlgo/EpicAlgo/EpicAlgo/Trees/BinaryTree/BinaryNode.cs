using System;
using System.Collections.Generic;
using System.Text;
using EpicAlgo.Interfaces;

namespace EpicAlgo.Trees.BinaryTree
{
    sealed class BinaryNode<T> : IBinaryNode<T>
    {
        private T data;
        private BinaryNode<T> left, right;

        public BinaryNode(T data)
        {
            this.data = data;
            left = null;
            right = null;
        }

        public T GetData()
        {
            return data;
        }

        public IBinaryNode<T> GetLeftNode()
        {
            return left;
        }

        public int GetNumberOfNodes()
        {
            throw new NotImplementedException();
        }

        public IBinaryNode<T> GetRightNode()
        {
            return right;
        }

        public bool HasLeftNode()
        {
            throw new NotImplementedException();
        }

        public bool HasRightNode()
        {
            throw new NotImplementedException();
        }

        public void SetData(T data)
        {
            this.data = data;
        }

        public void SetLeftNode(IBinaryNode<T> left)
        {
            this.left = (BinaryNode<T>)left;
        }

        public void SetRightNode(IBinaryNode<T> right)
        {
            this.right = (BinaryNode<T>)right;
        }
    }
}
