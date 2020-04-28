using EpicAlgo.HashTables;
using EpicAlgo.Trees.BinaryTree;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EpicAlgo.Timers
{
    public class CompareTimer<T>
    {
        private Stopwatch stopWatch = new Stopwatch();

        public CompareTimer()
        {
        }

        public void TestTimer(List<T> list, Action method )
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

          
            
            Console.WriteLine(watch.ElapsedMilliseconds);





        }

        public static void taTid(List<T> eksempelListe) {

            
            var watch = System.Diagnostics.Stopwatch.StartNew();

            //myMethodName();

            Console.WriteLine(watch.ElapsedMilliseconds);
        
        
        
        }
    
    }
}
