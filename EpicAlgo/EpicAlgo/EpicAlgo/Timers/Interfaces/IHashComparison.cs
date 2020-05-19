using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Timers.Interfaces
{
    public interface IHashComparison<K,T>
    {
        public void TakeTimeOfInsert(KeyValuePair<K, T> item);
        public void TakeTimeOfInsert(Dictionary<K, T> dict);
        public void TakeTimeOfInsert(List<KeyValuePair<K, T>> kvp);
        public void TakeTimeOfRemove(KeyValuePair<K, T> item);
        public void TakeTimeOfRemove(Dictionary<K, T> dict);
        public void TakeTimeOfRemove(List<KeyValuePair<K, T>> kvp);
        public void PrintTimeOfInsert();
        public void PrintTimeOfRemove();
        public void Print();

    }
}
