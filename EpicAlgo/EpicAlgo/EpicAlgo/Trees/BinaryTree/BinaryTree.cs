using System;
using System.Text;
using System.Collections.Generic;

namespace EpicAlgo.Trees.BinaryTree
{
    public class BinaryTree<T>
    {

        public Node<T> root;
        private Comparer<T> comparator;

        public BinaryTree(Comparer<T> comparator)
        {
            this.root = null;
            this.comparator = comparator;

        }


        public Node<T> deleteNode(Node<T> root, T data)
        {
            
            if (root == null) return root;

            if (comparator.Compare(data, root.data) < 0)
            {
                root.setLeft(deleteNode(root.getLeft(), data));
            }
            else if (comparator.Compare(data, root.data) > 0)
            {
                root.setRight(deleteNode(root.getRight(), data));
            }
            else
            {
                // node with no leaf nodes
                if (root.getLeft() == null && root.getRight() == null)
                {
                    Console.WriteLine("deleting " + data);
                    return null;
                }
                else if (root.getLeft() == null)
                {
                    // node with one node (no left node)
                    Console.WriteLine("deleting " + data);
                    return root.getRight();
                }
                else if (root.getRight() == null)
                {
                    // node with one node (no right node)
                    Console.WriteLine("deleting " + data);
                    return root.getLeft();
                }
                else
                {
                    // nodes with two nodes
                    // search for min number in right sub tree
                    T minValues = minValue(root.getRight());
                    root.setData(minValues);
                    root.setRight(deleteNode(root.getRight(), minValues));
                    Console.WriteLine("deleting " + data);
                }
            }

            return root;
        }


        private T minValue(Node<T> node)
        {

            if (node.getLeft() != null)
            {
                return minValue(node.getLeft());
            }
            return node.data;
        }

        public Node<T> insertNode(Node<T> node, T data)
        {

            if (node == null)
            {
                node = new Node<T>(data);
            }


            else if (comparator != null && comparator.Compare(data, node.data) < 0)
            {
                node.left = insertNode(node.left, data);
            }
            else
            {
                node.right = insertNode(node.right, data);
            }

            return node;
        }
        public void insertItem(T word)
        {
            root = insertNode(root, word);
        }

        public void insertItemArray(T[] word)
        {
            for (var i = 0; i < word.Length; i++)
            {
                insertItem(word[i]);
            }
        }

        public void insertItemList(List<T> data)
        {
            for (var i = 0; i < data.Count; i++)
            {
                insertItem(data[i]);
            }
        }


        public void inOrder(Node<T> root)
        {
            if (root != null)
            {
                inOrder(root.left);
                Console.WriteLine(root.data.ToString() + " \n");
                inOrder(root.right);
            }
        }

        public void preOrder(Node<T> root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data.ToString() + " \n");
                preOrder(root.left);
                preOrder(root.right);
            }
        }

        public void postOrder(Node<T> root)
        {
            if (root != null)
            {
                postOrder(root.left);
                postOrder(root.right);
               Console.WriteLine(root.data.ToString() + " \n");
            }
        }


        public Boolean contains(Node<T> root, T data)
        {
            // Searches for value x in binary tree rooted at root

            if (root == null)
                return false;
            if (root.data.Equals(data))
                return true;
            return (contains(root.left, data) || contains(root.right, data));
        }

    }
}
