using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Interfaces
{
    public interface IContainerTimer<T>
    {
        void TakeTime();
        void ListTime(List<T> list);
        void InsertTime(T item);
        void ReadTime(T item);
        void DeleteTime(T item);
    }
}
