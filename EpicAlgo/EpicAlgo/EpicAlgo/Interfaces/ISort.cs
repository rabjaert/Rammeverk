using System;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Interfaces
{
    public interface ISort
    {
        int[] QuickSort(int[] A, int min, int max);
        int FindPartition(int[] A, int min, int max);
        int[] MergeSort(int[] A, int min, int max);
        int[] InsertionSort(int[] A);
        int[] CountSort(int[] A, int n, int exp);
        int[] RadixSort(int[] A, int n);
        int GetMax(int[] A, int n);
     
    }
}
