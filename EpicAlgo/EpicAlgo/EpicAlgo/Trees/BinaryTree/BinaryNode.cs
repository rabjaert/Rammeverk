﻿using System;
using System.Collections.Generic;
using System.Text;
using EpicAlgo.Interfaces;

namespace EpicAlgo.Trees.BinaryTree
{
    sealed class BinaryNode<T> : IBinaryNode<T>
    {
        private T Data;
        private BinaryNode<T> Left, Right;

        public BinaryNode(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public T GetData()
        {
            return Data;
        }

        public IBinaryNode<T> GetLeftNode()
        {
            return Left;
        }

        public int GetNumberOfNodes()
        {
            throw new NotImplementedException();
        }

        public IBinaryNode<T> GetRightNode()
        {
            return Right;
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
            this.Data = data;
        }

        public void SetLeftNode(IBinaryNode<T> left)
        {
            this.Left = (BinaryNode<T>)left;
        }

        public void SetRightNode(IBinaryNode<T> right)
        {
            this.Right = (BinaryNode<T>)right;
        }
    }
}
