using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Interfaces
{
    public interface ITreeComparison<T>
    {
        public void InsertTime(T t);
        public void InsertTime(List<T> t);
        public void RemoveTime(T t);
        public void RemoveTime(List<T> t);
        public void PrintInsert();
        public void PrintRemove();
        public void Print();

    }
}
