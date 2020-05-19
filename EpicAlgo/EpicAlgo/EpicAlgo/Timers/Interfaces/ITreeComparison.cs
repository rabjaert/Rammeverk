using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Timers.Interfaces
{
    public interface ITreeComparison<T>
    {
        public void TakeTimeOfInsert(T t);
        public void TakeTimeOfInsert(List<T> t);
        public void TakeTimeOfRemove(T t);
        public void TakeTimeOfRemove(List<T> t);
        public void PrintTimeOfInsert();
        public void PrintTimeOfRemove();
        public void Print();

    }
}
