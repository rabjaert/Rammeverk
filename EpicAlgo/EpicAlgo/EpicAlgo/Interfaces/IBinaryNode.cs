using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Interfaces
{
    public interface IBinaryNode<T>
    {
        T GetData();
        void SetData(T data);
        IBinaryNode<T> GetLeftNode();
        void SetLeftNode(IBinaryNode<T> left);
        IBinaryNode<T> GetRightNode();
        void SetRightNode(IBinaryNode<T> right);
        Boolean HasLeftNode();
        Boolean HasRightNode();
        int GetNumberOfNodes();

    }
}
