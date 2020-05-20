using EpicAlgo.HashTables;
using EpicAlgo.Models;
using EpicAlgo.Timers.Timer;
using EpicAlgo.Trees.BinaryTree;
using EpicAlgo.Trees.Interfaces;
using System;
using System.Collections.Generic;


namespace EpicAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Actor Objects
            Actor person1 = new Actor("Roger", "Knutsen", 67);
            Actor person2 = new Actor("Snoop", "Dog", 40);
            Actor person3 = new Actor("Zelda", "Hambeg", 20);
            Actor person4 = new Actor("Barrack", "Obama", 100);

            /*
             * 
             * SCENARIO 1:
             * 
             * Make a binarytree and add some data to the tree.

             * 
             * 
            */
            
            Console.WriteLine("Scenario 1: Make a binarytree and add some data to the tree.\n");
            var AgeComparer = Comparer<Actor>.Create((x, y) => -x.Alder.CompareTo(y.Alder));
            BinaryTree<Actor> ActorTree = new BinaryTree<Actor>(AgeComparer);
            ActorTree.Add(person1);
            ActorTree.Add(person2);
            ActorTree.Add(person3);
            ActorTree.PrintInOrder();

            /*
            * 
            * SCENARIO 2:
            * 
            * Use the binarytree to remove an item, and search for another item.

            * 
            * 
           */
            
            Console.WriteLine("Scenario 2: Use the binarytree to remove an item, and search for another item.\n");
            BinaryTree<Actor> ActorTre2 = new BinaryTree<Actor>(AgeComparer);
            ActorTre2.Add(person1);
            ActorTre2.Add(person2);
            ActorTre2.Add(person4);
            ActorTre2.Remove(person2);
            Console.WriteLine("Checking if" + " " + person2 + " " + "is in the binarytree" + " : " + ActorTre2.Contains(person2));
            Console.WriteLine("Checking if" + " " + person4 + " " + "is in the binarytree" + " : " + ActorTre2.Contains(person4) + "\n");
            ActorTre2.PrintInOrder();

            
           /*
           * SCENARIO 3:
           * 
           * Fill the binary tree with alot of elements and clear it.

           * 
           * 
          */
            
             Console.WriteLine("Scenario 3: Fill the binary tree with alot of elements and clear it.\n");
             var IntComparer = Comparer<double>.Create((x, y) => -x.CompareTo(y));
             BinaryTree<double> IntTree = new BinaryTree<double>(IntComparer);
             List<double> IntList = new List<double>();
             Random random = new Random();
             for (var i = 0; i < 1000; i++) {
                 IntList.Add(random.NextDouble());
             }
             IntTree.AddList(IntList);
             IntTree.Clear();
             IntTree.PrintInOrder();

             
           /* 
           * SCENARIO 4:
           * 
           * Make a HashQuadratic table and add some data to the table.

           * 
           * 
          */
            
            Console.WriteLine("Scenario 4: Make a HashQuadratic table and add some data to the table.\n");
            HashQuadratic<int, string> HashString = new HashQuadratic<int, string>();
            HashString.Add(new KeyValuePair<int, string>(1, "Peter"));
            HashString.Add(new KeyValuePair<int, string>(2, "Steve"));
            HashString.Add(new KeyValuePair<int, string>(3, "Dave"));
            HashString.Print();

          /*
         * 
         * SCENARIO 5:
         * 
         * Make a HashLinear table and add some data to the table.

         * 
         * 
        */
            
            Console.WriteLine("Scenario 5: Make a HashLinear table and add some data to the table.\n");
            HashLinear<int, Actor> HashActor = new HashLinear<int, Actor>();
            HashActor.Add(new KeyValuePair<int, Actor>(1, person1));
            HashActor.Add(new KeyValuePair<int, Actor>(2, person2));
            HashActor.Add(new KeyValuePair<int, Actor>(3, person3));
            HashActor.Print();

            
          /* 
          * SCENARIO 6:
          * 
          * Use the hashtables to remove an item, and search for another item.

          * 
          * 
          */

            
            Console.WriteLine("Scenario 6: Use the hashtables to remove an item, and search for another item.\n");
            HashString.Remove(1);
            HashString.Remove(2);
            Console.WriteLine("Checking if" + " " + "Dave" + " " + "is in the table" + " : " + HashString.Contains(3) + "\n");
            HashString.Print();

            HashActor.Remove(1);
            HashActor.Remove(2);
            Console.WriteLine("Checking if" + " " + "Zelda" + " " + "is in the table" + " : " + HashActor.Contains(3) + "\n");
            HashActor.Print();


            
          /* 
          * SCENARIO 7:
          * 
          * Take the time of a binary tree.

          * 
          * 
          */
            
              Console.WriteLine("Scenario 7: Take the time of a binary tree.\n");
              var intComparer = Comparer<double>.Create((x, y) => -y.CompareTo(x));
              BinaryTree<double> intTre = new BinaryTree<double>(intComparer);

              List<double> intList = new List<double>();
              Random ran = new Random();
              for (int i = 0; i < 1000; i++)
              {

                  intList.Add(ran.NextDouble());
              }

              TreeTimer<double> TreeTimer = new TreeTimer<double>(intTre);
              TreeTimer.TakeTimeOfInsert(intList);
              TreeTimer.TakeTimeOfRemove(intList);
              TreeTimer.Print();

              
            /* 
            * SCENARIO 8:
            * 
            * Take the time of a hashtable.

            * 
            * 
            */
            
              Console.WriteLine("\nScenario 8: Take the time of a hashtable.\n");
              HashQuadratic<int, int> HashQuadraticTimer = new HashQuadratic<int, int>();
              HashTimer<int, int> HashTimer  = new HashTimer<int, int>(HashQuadraticTimer);

              KeyValuePair<int, int> KvpArrayTest = new KeyValuePair<int, int>();
              for (int i = 0; i < 10000; i++)
              {
                  KeyValuePair<int, int> temp = new KeyValuePair<int, int>(i, i / 2);

              }


              HashTimer.TakeTimeOfInsert(KvpArrayTest);
              HashTimer.TakeTimeOfRemove(KvpArrayTest);
              HashTimer.PrintTimeOfInsert();
              HashTimer.PrintTimeOfRemove();


            /* 
            * SCENARIO 9:
            * 
            * Take the time of two collections.

            * 
            * 
            */
            Console.WriteLine("\nScenario 9: Take the time of two collections.\n");
            var DoubleComparerToCompare = Comparer<double>.Create((x, y) => -y.CompareTo(x));
             BinaryTree<double> IntTreeComparer = new BinaryTree<double>(DoubleComparerToCompare);
             List<double> DoubleList = new List<double>();

             List<double> DoubleCollection = new List<double>();


             Random RandomDouble = new Random();
             for (int i = 0; i < 10000; i++)
             {

                 DoubleCollection.Add(RandomDouble.NextDouble());
             }

             List<ICollection<double>> SaveCollection = new List<ICollection<double>>();
             SaveCollection.Add(IntTreeComparer);
             SaveCollection.Add(DoubleList);

             TreeTimer<double> CollectionTimer = new TreeTimer<double>(SaveCollection);
             CollectionTimer.TakeTimeOfInsert(DoubleCollection);
             CollectionTimer.TakeTimeOfRemove(DoubleCollection);
             CollectionTimer.Print();


            /*
            * 
            * SCENARIO 10:
            * 
            * Take the time of two keyvaluepair collections.

            * 
            * 
            */
            Console.WriteLine("\nScenario 10: Take the time of two keyvaluepair collections.\n");
            HashLinear<int, int> hl = new HashLinear<int, int>();
            HashQuadratic<int, int> hq = new HashQuadratic<int, int>();

            List<KeyValuePair<int, int>> KVPCollection = new List<KeyValuePair<int, int>>();

           
            
            for (int i = 0; i < 10000; i++)
            {

                KVPCollection.Add(new KeyValuePair<int, int>(i, i));
            }

            List<ICollection<KeyValuePair<int, int>>> collection = new List<ICollection<KeyValuePair<int, int>>>();
            collection.Add(hl);
            collection.Add(hq);
            HashTimer<int, int> ht = new HashTimer<int, int>(collection);
            ht.TakeTimeOfInsert(KVPCollection);
            ht.TakeTimeOfRemove(KVPCollection);
            ht.Print();
            
           

        }
    }
}
