/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using EpicAlgo.Interfaces;

namespace EpicAlgo.Trees.BinaryTree
{
    public class BinaryTree<T>
    {

        private IBinaryNode<T> Root;
        private Comparer<T> Comparer;

        public BinaryTree(Comparer<T> comparer)
        {
            Root = null;
            Comparer = comparer;

        }

        //*******************************************************************************\\
        //                                                                                \\
        //         PUBLIC METHODS THAT THE USER WILL INTERACT WITH                        \\
        //                                                                                \\
        //********************************************************************************\\ 



        //Adds an item to the binary tree
        public void Add(T data)
        {
            SetRoot(InsertNode(Root, data));
        }

        //Adds the content of the array to the BinaryTree
        public void AddArray(T[] data)
        {
            for (var i = 0; i < data.Length; i++)
            {
                AddData(data[i]);
            }
        }

        //Adds the content of the list to the BinaryTree
        public void AddList(List<T> data)
        {
            for (var i = 0; i < data.Count; i++)
            {
                AddData(data[i]);
            }
        }

       //Removes an element from the binary tree
        public bool Remove(T data)
        {
            if (DeleteNode(Root, data).GetData().Equals(data))
            {
                return true;
            }
            else return false;
        }

        //Prints the binary tree
        public void Print()
        {
            PrintInOrder(Root);
        }

       //Clears the content of the binary tree
        public void Clear()
        {
            throw new NotImplementedException();
        }

        //Counting number of nodes
        public int Count => throw new NotImplementedException();

        //Checks for an item in the binary tree
        public bool Contains(T item)
        {
            return RContains(Root, item);
        }

        //Not implemented, but should be public
        private void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        //Gets the minimum value in the binary tree
        private T MinValue(IBinaryNode<T> root)
        {
            if (root.GetLeftNode() != null)
            {
                return MinValue(root.GetLeftNode());
            }
            return root.GetData();
        }


        //*******************************************************************************\\
        //                                                                                \\
        //         PRIVATE METHODS THAT USER IS NOT GOING TO USE                          \\
        //                                                                                \\
        //********************************************************************************\\        


        private void AddData(T data)
        {
            SetRoot(InsertNode(Root, data));
        }

        private void SetRoot(IBinaryNode<T> root)
        {
            Root = root;
        }

        private IBinaryNode<T> GetRoot()
        {
            return Root;
        }

        private bool IsReadOnly => throw new NotImplementedException();

        private bool RContains(IBinaryNode<T> root, T data)
        {
            if (root == null)
                return false;
            if (root.GetData().Equals(data))
                return true;
            return (RContains(root.GetLeftNode(), data) || RContains(root.GetRightNode(), data));
        }

        private IBinaryNode<T> DeleteNode(IBinaryNode<T> node, T data)
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

        private IBinaryNode<T> InsertNode(IBinaryNode<T> node, T data)
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

        private void PrintInOrder(IBinaryNode<T> root)
        {
            if (root != null)
            {
                PrintInOrder(root.GetLeftNode());
                Console.WriteLine(root.GetData().ToString() + " \n");
                PrintInOrder(root.GetRightNode());
            }
        }

        private void PrintPostOrder(IBinaryNode<T> root)
        {
            throw new NotImplementedException();
        }

        private void PrintPreOrder(IBinaryNode<T> root)
        {
            throw new NotImplementedException();
        }

        private void PrintInOrder(INode<T> root)
        {
            throw new NotImplementedException();
        }

        /*
        public void TakeTime(List<T> list)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (var item in list)
            {
                AddData(item);
            }
            watch.Stop();
            Console.WriteLine("Sekunder:" + watch.ElapsedMilliseconds / 1000 + "\nMillisekunder:" + watch.ElapsedMilliseconds);

        }
        */

/*

    }
}
*/