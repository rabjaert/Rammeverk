using System;
using System.Collections.Generic;


namespace EpicAlgo.Interfaces
{
    public interface IBinaryTree<T> : ITree<T>
    {

        IBinaryNode<T> DeleteNode(IBinaryNode<T> node, T data);

        T MinValue(IBinaryNode<T> root);

        IBinaryNode<T> InsertNode(IBinaryNode<T> node, T data);

        Boolean RContains(IBinaryNode<T> root, T data);

        void PrintInOrder(IBinaryNode<T> root);

        void PrintPreOrder(IBinaryNode<T> root);

        void PrintPostOrder(IBinaryNode<T> root);

    }
}
