using EpicAlgo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Trees.BinaryTree
{
    public abstract class AbstractBinaryTree<T> 
    {

        protected IBinaryNode<T> Root;
        protected Comparer<T> Comparer;

        protected void AddData(T data)
        {
            SetRoot(InsertNode(Root, data));
        }

        protected void SetRoot(IBinaryNode<T> root)
        {
            Root = root;
        }

        protected IBinaryNode<T> GetRoot()
        {
            return Root;
        }

        protected bool IsReadOnly => throw new NotImplementedException();

        protected bool RContains(IBinaryNode<T> root, T data)
        {
            if (root == null)
                return false;
            if (root.GetData().Equals(data))
                return true;
            return (RContains(root.GetLeftNode(), data) || RContains(root.GetRightNode(), data));
        }

        protected IBinaryNode<T> DeleteNode(IBinaryNode<T> node, T data)
        {
            if (node == null) return node;

            if (Comparer.Compare(data, node.GetData()) < 0)
            {
                node.SetLeftNode(DeleteNode(node.GetLeftNode(), data));
            }
            else if (Comparer.Compare(data, node.GetData()) > 0)
            {
                node.SetRightNode(DeleteNode(node.GetRightNode(), data));
            }
            else
            {
                // node with no leaf nodes
                if (node.GetLeftNode() == null && node.GetRightNode() == null)
                {
                    Console.WriteLine("deleting " + data);
                    return null;
                }
                else if (node.GetLeftNode() == null)
                {
                    // node with one node (no left node)
                    Console.WriteLine("deleting " + data);
                    return node.GetRightNode();
                }
                else if (node.GetRightNode() == null)
                {
                    // node with one node (no right node)
                    Console.WriteLine("deleting " + data);
                    return node.GetLeftNode();
                }
                else
                {
                    // nodes with two nodes
                    // search for min number in right sub tree
                    T minValues = MinValue(node.GetRightNode());
                    node.SetData(minValues);
                    node.SetRightNode(DeleteNode(node.GetRightNode(), minValues));
                    Console.WriteLine("deleting " + data);
                }
            }

            return node;
        }

        protected IBinaryNode<T> InsertNode(IBinaryNode<T> node, T data)
        {


            if (node == null)
            {
                node = new BinaryNode<T>(data);
            }



            else if (Comparer != null && Comparer.Compare(data, node.GetData()) < 0)
            {

                node.SetLeftNode(InsertNode(node.GetLeftNode(), data));
            }
            else
            {
                node.SetRightNode(InsertNode(node.GetRightNode(), data));
            }

            return node;
        }



        protected T MinValue(IBinaryNode<T> root)
        {
            if (root.GetLeftNode() != null)
            {
                return MinValue(root.GetLeftNode());
            }
            return root.GetData();
        }
        protected void PrintInOrder(IBinaryNode<T> root)
        {
            if (root != null)
            {
                PrintInOrder(root.GetLeftNode());
                Console.WriteLine(root.GetData().ToString() + " \n");
                PrintInOrder(root.GetRightNode());
            }
        }
        protected void PrintPostOrder(IBinaryNode<T> root)
        {
            throw new NotImplementedException();
        }

        protected void PrintPreOrder(IBinaryNode<T> root)
        {
            throw new NotImplementedException();
        }

    }
}
