using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Interfaces
{   public interface IHashComparison<K,T>
    {
        public void InsertTime(K k, T t);
        public void InsertTime(Dictionary<K, T> dict);
        public void InsertTime(List<KeyValuePair<K, T>> kvp);
        public void RemoveTime(K k, T t);
        public void RemoveTime(Dictionary<K, T> dict);
        public void RemoveTime(List<KeyValuePair<K, T>> kvp);
        public void PrintInsert();
        public void PrintRemove();
        public void Print();

    }
}
