using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Interfaces
{
    public interface ITimeComparison<K,T>
    {
        public void TakeTime(K k, T t);

    }
}
