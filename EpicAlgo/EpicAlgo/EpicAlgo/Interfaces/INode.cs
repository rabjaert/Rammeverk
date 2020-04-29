using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Interfaces
{
    public interface INode<T>
    {
        T GetData();
        void SetData(T data);
        int GetNumberOfNodes();
    }
}
