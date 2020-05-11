﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Interfaces
{
    public interface ITree<T> : ICollection<T>
    {
        public void AddArray(T[] data);
        public void AddList(List<T> data);
        public void PrintInOrder();
        public void PrintPostOrder();
        public void PrintPreOrder();

    }
}
