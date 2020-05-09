
using System.Collections.Generic;


namespace EpicAlgo.Interfaces
{
    public interface IHashTableCollection<K, T> : ICollection<KeyValuePair<K, T>>, IEnumerable<KeyValuePair<K, T>>
    {
    }
}
