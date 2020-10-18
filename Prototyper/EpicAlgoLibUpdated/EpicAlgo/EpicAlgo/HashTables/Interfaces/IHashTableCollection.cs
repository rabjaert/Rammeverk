using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.HashTables.Interfaces
{
    public interface IHashTableCollection<K, T> : ICollection<KeyValuePair<K, T>>
    {
        public void Print();
    }
}
