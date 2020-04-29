using System;
using System.Collections.Generic;
using System.Text;
using EpicAlgo.Interfaces;

namespace EpicAlgo.Trees.BinaryTree
{
    class BinaryTree<T> : IBinaryTree<T>, ICompareTimer<T>
    {

        private IBinaryNode<T> Root;
        private Comparer<T> Comparer;

        public BinaryTree(Comparer<T> comparer)
        {
            Root = null;
            Comparer = comparer;

        }

        public void SetRoot(IBinaryNode<T> root)
        {
            Root = root;
        }

        public IBinaryNode<T> GetRoot()
        {
            return Root;
        }

        public void AddData(T data)
        {
            SetRoot(InsertNode(Root, data));
        }

        public void AddDataArray(T[] data)
        {
            for (var i = 0; i < data.Length; i++)
            {
                AddData(data[i]);
            }
        }

        public void AddDataList(List<T> data)
        {
            for (var i = 0; i < data.Count; i++)
            {
                AddData(data[i]);
            }
        }

        public bool Contains(IBinaryNode<T> root, T data)
        {
            if (root == null)
                return false;
            if (root.GetData().Equals(data))
                return true;
            return (Contains(root.GetLeftNode(), data) || Contains(root.GetRightNode(), data));
        }

        public IBinaryNode<T> DeleteNode(IBinaryNode<T> node, T data)
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

        public IBinaryNode<T> InsertNode(IBinaryNode<T> node, T data)
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

        public T MinValue(IBinaryNode<T> root)
        {
            if (root.GetLeftNode() != null)
            {
                return MinValue(root.GetLeftNode());
            }
            return root.GetData();
        }

        public void PrintInOrder(IBinaryNode<T> root)
        {
            if (root != null)
            {
                PrintInOrder(root.GetLeftNode());
                Console.WriteLine(root.GetData().ToString() + " \n");
                PrintInOrder(root.GetRightNode());
            }
        }

        public void PrintPostOrder(IBinaryNode<T> root)
        {
            throw new NotImplementedException();
        }

        public void PrintPreOrder(IBinaryNode<T> root)
        {
            throw new NotImplementedException();
        }

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
    }
}
