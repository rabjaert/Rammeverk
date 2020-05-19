using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Trees.Interfaces.Internal
{
    public interface IBinaryNode<T> : INode<T>
    {
        IBinaryNode<T> GetLeftNode();
        void SetLeftNode(IBinaryNode<T> left);
        IBinaryNode<T> GetRightNode();
        void SetRightNode(IBinaryNode<T> right);
        bool HasLeftNode();
        bool HasRightNode();

    }
}
