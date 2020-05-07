using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Interfaces
{
    public interface IHashTableCollection<K, T> : ICollection<KeyValuePair<K, T>>, IEnumerable<KeyValuePair<K, T>>
    {


    }
}
