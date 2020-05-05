using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Interfaces
{
    public interface ITree<T> : IEnumerable<T>
    {
        public void AddData(T data);

        public void AddDataArray(T[] data);

        public void AddDataList(List<T> data);
    }
}
