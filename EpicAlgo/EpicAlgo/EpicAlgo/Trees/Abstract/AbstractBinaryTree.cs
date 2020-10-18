using EpicAlgo.Trees.BinaryTree.Internal;
using EpicAlgo.Trees.Interfaces.Internal;
using System;
using System.Collections.Generic;

namespace EpicAlgo.Trees.Abstract
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

        protected IBinaryNode<T> FindNode(IBinaryNode<T> node, T data)
        {
            if (node == null) return node;
            if (node.GetData().Equals(data)) return node;

            if (Comparer.Compare(data, node.GetData()) < 0)
            {
                return FindNode(node.GetLeftNode(), data);
            }
            else if (Comparer.Compare(data, node.GetData()) > 0)
            {
                return FindNode(node.GetRightNode(), data);
            }
            else
            {
                // node with no leaf nodes
                if (node.GetLeftNode() == null && node.GetRightNode() == null)
                {

                    return null;
                }
                else if (node.GetLeftNode() == null)
                {
                    // node with one node (no left node)

                    return node.GetRightNode();
                }
                else if (node.GetRightNode() == null)
                {
                    // node with one node (no right node)

                    return node.GetLeftNode();
                }
                else
                {
                    // nodes with two nodes
                    // search for min number in right sub tree
                    T minValues = MinValue(node.GetRightNode());
                    node.SetData(minValues);
                    node.SetRightNode(FindNode(node.GetRightNode(), minValues));

                }
                return node;

            }
        }

        protected IBinaryNode<T> DeleteNode(IBinaryNode<T> node, T data)
        {
            try
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

                        return null;
                    }
                    else if (node.GetLeftNode() == null)
                    {
                        // node with one node (no left node)

                        return node.GetRightNode();
                    }
                    else if (node.GetRightNode() == null)
                    {
                        // node with one node (no right node)

                        return node.GetLeftNode();
                    }
                    else
                    {
                        // nodes with two nodes
                        // search for min number in right sub tree
                        T minValues = MinValue(node.GetRightNode());
                        node.SetData(minValues);
                        node.SetRightNode(DeleteNode(node.GetRightNode(), minValues));

                    }
                }

                return node;
            }
                        
            catch (NullReferenceException ex)
            {

                throw ex;
            }
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

        private T MinValue(IBinaryNode<T> root)
        {
            if (root.GetLeftNode() != null)
            {
                return MinValue(root.GetLeftNode());
            }
            return root.GetData();
        }

        protected static IBinaryNode<T> DeleteTree(IBinaryNode<T> root)
        {
            try
            {
                if (root != null)
                {
                    root.SetLeftNode(DeleteTree(root.GetLeftNode()));
                    root.SetRightNode(DeleteTree(root.GetRightNode()));
                    root = null;

                    return null;
                }
                return null;
            }
            catch (NullReferenceException nre)
            {

                return root;
            }

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
            if (root != null)
            {
                PrintPostOrder(root.GetLeftNode());
                PrintPostOrder(root.GetRightNode());
                Console.WriteLine(root.GetData().ToString() + " \n");
            }
        }

        protected void PrintPreOrder(IBinaryNode<T> root)
        {
            if (root != null)
            {
                Console.WriteLine(root.GetData().ToString() + " \n");
                PrintPreOrder(root.GetLeftNode());
                PrintPreOrder(root.GetRightNode());
                
            }
        }

    }
}
