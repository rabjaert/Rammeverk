using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Interfaces
{
    public interface IBinaryTree<T>
    {

        public IBinaryNode<T> DeleteNode(IBinaryNode<T> root, T data);

        public T MinValue(IBinaryNode<T> node);

        public IBinaryNode<T> InsertNode(IBinaryNode<T> node, T data);

        public void InsertItem(T word);

        public void InsertItemIntoArray(T[] word);

        public void InsertItemIntoList(List<T> data);

        public Boolean Contains(IBinaryNode<T> root, T data);

        public void PrintInOrder(IBinaryNode<T> root);

        public void PrintPreOrder(IBinaryNode<T> root);

        public void PrintPostOrder(IBinaryNode<T> root);




        }
}
