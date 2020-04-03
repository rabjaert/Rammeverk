using System;
using System.Collections.Generic;


namespace EpicAlgo.Interfaces
{
    public interface IBinaryTree<T>
    {
        public IBinaryNode<T> DeleteNode(IBinaryNode<T> node, T data);

        public T MinValue(IBinaryNode<T> root);

        public IBinaryNode<T> InsertNode(IBinaryNode<T> node, T data);
        
        public void AddData(T data);

        public void AddDataArray(T[] data);

        public void AddDataList(List<T> data);

        public Boolean Contains(IBinaryNode<T> root, T data);

        public void PrintInOrder(IBinaryNode<T> root);

        public void PrintPreOrder(IBinaryNode<T> root);

        public void PrintPostOrder(IBinaryNode<T> root);

        }
}
