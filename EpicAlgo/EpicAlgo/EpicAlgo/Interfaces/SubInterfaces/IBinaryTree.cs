using System;
using System.Collections.Generic;


namespace EpicAlgo.Interfaces
{
    public interface IBinaryTree<T> : ITree<T>
    {
        public IBinaryNode<T> DeleteNode(IBinaryNode<T> node, T data);

        public T MinValue(IBinaryNode<T> root);

        public IBinaryNode<T> InsertNode(IBinaryNode<T> node, T data);
        
        public Boolean Contains(IBinaryNode<T> root, T data);

        public void PrintInOrder(IBinaryNode<T> root);

        public void PrintPreOrder(IBinaryNode<T> root);

        public void PrintPostOrder(IBinaryNode<T> root);

        }
}
