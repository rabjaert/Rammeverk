using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Trees.BinaryTree
{
    public class Node<T>
    {
        public T data;
        public Node<T> left, right;
        //public int counter;

        public Node(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }


        /**
         * @return the left
         */
        public Node<T> getLeft()
        {
            return left;
        }
        /**
         * @param left the left to set
         */
        public void setLeft(Node<T> left)
        {
            this.left = left;
        }
        /**
         * @return the right
         */
        public Node<T> getRight()
        {
            return right;
        }
        /**
         * @param right the right to set
         */
        public void setRight(Node<T> right)
        {
            this.right = right;
        }

        /**
         * @param data the data to set
         */
        public void setData(T data)
        {
            this.data = data;
        }
    }

}
