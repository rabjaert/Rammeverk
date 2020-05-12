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
            /*
            Console.WriteLine("Scenario 1:\n");
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
            /*
            Console.WriteLine("Scenario 2:\n");
            BinaryTree<Actor> ActorTre2 = new BinaryTree<Actor>(AgeComparer);
            ActorTre2.Add(person1);
            ActorTre2.Add(person2);
            ActorTre2.Add(person4);
            ActorTre2.Remove(person2);
            Console.WriteLine("Checking if" + " " + person2 + " " + "is in the binarytree" + " : " + ActorTre2.Contains(person2));
            Console.WriteLine("Checking if" + " " + person4 + " " + "is in the binarytree" + " : " + ActorTre2.Contains(person4) + "\n");
            ActorTre2.PrintInOrder();

            /*
           * 
           * SCENARIO 3:
           * 
           * Fill the binary tree with alot of elements and clear it.

           * 
           * 
          */
            /*
             Console.WriteLine("Scenario 3:\n");
             var IntComparer = Comparer<double>.Create((x, y) => -x.CompareTo(y));
             BinaryTree<double> IntTree = new BinaryTree<double>(IntComparer);
             List<double> IntList = new List<double>();
             Random random = new Random();
             for (var i = 0; i < 10000; i++) {
                 IntList.Add(random.NextDouble());
             }
             IntTree.AddList(IntList);
             IntTree.Clear();
             IntTree.PrintInOrder();

             /*
           * 
           * SCENARIO 4:
           * 
           * Make a HashQuadratic table and add some data to the table.

           * 
           * 
          */
            /*
            Console.WriteLine("Scenario 4:\n");
            HashQuadratic<int, string> HashString = new HashQuadratic<int, string>();
            HashString.Add(new KeyValuePair<int, string>(1, "Peter"));
            HashString.Add(new KeyValuePair<int, string>(2, "Steve"));
            HashString.Add(new KeyValuePair<int, string>(3, "Dave"));
            HashString.Print();

          /*
         * 
         * SCENARIO 5:
         * 
         * Make a HashQuadratic table and add some data to the table.

         * 
         * 
        */
            /*
            Console.WriteLine("Scenario 5:\n");
            HashLinear<int, Actor> HashActor = new HashLinear<int, Actor>();
            HashActor.Add(new KeyValuePair<int, Actor>(1, person1));
            HashActor.Add(new KeyValuePair<int, Actor>(2, person2));
            HashActor.Add(new KeyValuePair<int, Actor>(3, person3));
            HashActor.Print();

            /*
          * 
          * SCENARIO 6:
          * 
          * Use the hashtables to remove an item, and search for another item.

          * 
          * 
          */

            /*
            Console.WriteLine("Scenario 6:\n");
            HashString.Remove(1);
            HashString.Remove(2);
            Console.WriteLine("Checking if" + " " + "Dave" + " " + "is in the table" + " : " + HashString.Contains(3) + "\n");
            HashString.Print();

            HashActor.Remove(1);
            HashActor.Remove(2);
            Console.WriteLine("Checking if" + " " + "Zelda" + " " + "is in the table" + " : " + HashActor.Contains(3) + "\n");
            HashActor.Print();


            /*
          * 
          * SCENARIO 7:
          * 
          * Take the time of a binary tree.

          * 
          * 
          */
          /*
            Console.WriteLine("Scenario 7:\n");
            var intComparer = Comparer<double>.Create((x, y) => -y.CompareTo(x));
            BinaryTree<double> intTre = new BinaryTree<double>(intComparer);

            List<double> intList = new List<double>();
            Random ran = new Random();
            for (int i = 0; i < 1000; i++)
            {

                intList.Add(ran.NextDouble());
            }

            TreeTimer<double> TreeTimer = new TreeTimer<double>(intTre);
            TreeTimer.InsertTime(intList);
            TreeTimer.RemoveTime(intList);
            TreeTimer.Print();

            /*
          * 
          * SCENARIO 8:
          * 
          * Take the time of a hashtable.

          * 
          * 
          */
          /*
            Console.WriteLine("Scenario 8:\n");
            HashQuadratic<int, int> HashQuadraticTimer = new HashQuadratic<int, int>();
            HashTimer<int, int> HashTimer  = new HashTimer<int, int>(HashQuadraticTimer);
            
            KeyValuePair<int, int> KvpArrayTest = new KeyValuePair<int, int>();
            for (int i = 0; i < 100000; i++)
            {
                KeyValuePair<int, int> temp = new KeyValuePair<int, int>(i, i / 2);
                
            }
            
           
            HashTimer.InsertTime(KvpArrayTest);
            HashTimer.RemoveTime(KvpArrayTest);
            HashTimer.PrintInsert();
            HashTimer.PrintRemove();

            /*
           * 
           * SCENARIO 9:
           * 
           * Take the time of two collections.

           * 
           * 
           */
           
            var DoubleComparerToCompare = Comparer<double>.Create((x, y) => -y.CompareTo(x));
            BinaryTree<double> IntTreeComparer = new BinaryTree<double>(DoubleComparerToCompare);
            List<double> DoubleList = new List<double>();

            List<double> DoubleCollection = new List<double>();
            
            
            Random RandomDouble = new Random();
            for (int i = 0; i < 100000; i++)
            {

                DoubleCollection.Add(RandomDouble.NextDouble());
            }

            List<ICollection<double>> SaveCollection = new List<ICollection<double>>();
            SaveCollection.Add(IntTreeComparer);
            SaveCollection.Add(DoubleList);

            TreeTimer<double> CollectionTimer = new TreeTimer<double>(SaveCollection);
            CollectionTimer.InsertTime(DoubleCollection);
            CollectionTimer.RemoveTime(DoubleCollection);
            CollectionTimer.Print();




            //var pizza = Comparer<Actor>.Create((x, y) => -y.Fornavn.CompareTo(x.Fornavn));
            /*
            //BinaryTree Example
            BinaryTree<Actor> testTre = new BinaryTree<Actor>(pizza);

            BinaryTree<Actor> testTre1 = new BinaryTree<Actor>(pizza);


            KeyValuePair<int, Double>[] kvpArray = new KeyValuePair<int, double>[50];
            /*
                        for (int i = 0; i < 50; i++)
                        {

                            hash2.Add(i, i / 2);
                        }

                        List<IHashTableDict<int, Double>> testa = new List<IHashTableDict<int, double>>();

                        testa.Add(hash);
                        testa.Add(hash1);
                        testa.Add(hash2);

                        HashTimer<int, Double> hashtimer = new HashTimer<int, double>(testa);

                        HashQ<int, int> test = new HashQ<int, int>();

                        test.Add(1, 1);
                        test.Add(2, 2);
                        test.Add(3, 3);
                        test.Add(4, 4);

                        var ad = test[4];

                        /*
                        testTre1.AddList(ikkeAvføring);

                        testTre1.PrintInOrder();
                        */
            //var pizza = Comparer<Actor>.Create((x, y) => y.Fornavn.CompareTo(x.Fornavn));

            /*

            Console.WriteLine("");
            var intComparer = Comparer<Double>.Create((x, y) => -y.CompareTo(x));


            HashQuadratic<int, Double> hashtable = new HashQuadratic<int, Double>();
            HashQuadratic<int, Double> hashtable1 = new HashQuadratic<int, Double>();

            BinaryTree<Double> intTre = new BinaryTree<Double>(intComparer);
            BinaryTree<Double> intTre1 = new BinaryTree<Double>(intComparer);



            List<ITree<Double>> myList = new List<ITree<Double>>();



            KeyValuePair<int, Actor> t = new KeyValuePair<int, Actor>();
            
   */
            /*
            KeyValuePair<int, Double>[] kvpArraytest = new KeyValuePair<int, double>[100000];
            for (int i = 0; i < 100000; i++)
            {
                KeyValuePair<int, Double> temp = new KeyValuePair<int, Double>(i, i/2);
                kvpArraytest[i] = temp;
            }

            HashQ<int, Double> hah1 = new HashQ<int, double>();
            HashQ<int, Double> hah2 = new HashQ<int, double>();
            HashQ<int, Double> hah3 = new HashQ<int, double>();

            HashTimer<int, Double> navn = new HashTimer<int, double>(hah1);

            navn.TakeTime(kvpArraytest);
            navn.Print();

            *//*
            var intComparer = Comparer<Double>.Create((x, y) => -y.CompareTo(x));
            BinaryTree<double> intTre = new BinaryTree<double>(intComparer);
            BinaryTree<double> intTre1 = new BinaryTree<double>(intComparer);
            BinaryTree<double> intTre2 = new BinaryTree<double>(intComparer);

            List<ITreeCollection<double>> treelist = new List<ITreeCollection<double>>();
            treelist.Add(intTre);
            treelist.Add(intTre1);
            treelist.Add(intTre2);
            List<double> intList = new List<double>();
            Random ran = new Random();
            for (int i = 0; i < 1000000; i++)
            {
              
                intList.Add(ran.NextDouble());
            }

            /*TreeTimer<double> treeTimer = new TreeTimer<double>(treelist);
            treeTimer.InsertTime(intList);
            treeTimer.RemoveTime(intList);
            treeTimer.Print();
            */

            //*****************************************/


            //HashQuadratic Example


            //*****************************************//
            /*
            HashQuadratic<int, Actor> table = new HashQuadratic<int, Actor>();
            table.Add(1, person1);
            table.Add(2, person2);
            table.Add(3, person3);
            table.Add(4, person4);
            table.Add(5, person5);
            table.Print();
            Console.WriteLine("\n");
            Console.WriteLine("Fjerner en person");
            Console.WriteLine("\n");
            table.Remove(5);
            table.Print();
            */
            /*
            var comparer = Comparer<double>.Create((x, y) => -y.CompareTo(x));
            List<double> intList1 = new List<double>();
           
            Random ran1 = new Random();
            for (int i = 0; i < 10000; i++)
            {

                intList.Add(ran.NextDouble());
            }

            BinaryTree<double> bin = new BinaryTree<double>(comparer);
            bin.AddList(intList);

            List<double> heiIgjen = new List<double>(0);

            /*
            for (var i = 0; i < 500000; i++) {

                
                
            }*/
            /*
            heiIgjen.AddRange(intList);
            bin.AddList(intList);
            List<ICollection<double>> collections = new List<ICollection<double>>();

            collections.Add(bin);
            collections.Add(heiIgjen);
            //Console.WriteLine(bin.FindData(5));
            TreeTimer<double> halla = new TreeTimer<double>(collections);
            halla.RemoveTime(intList);
            halla.PrintRemove();
            *//*
            var fornavn = Comparer<Actor>.Create((x, y) => y.Fornavn.CompareTo(x.Fornavn));
            BinaryTree<Actor> actorTre = new BinaryTree<Actor>(fornavn);
            actorTre.Add(person1);
            actorTre.Add(person2);
            Console.WriteLine(actorTre.FindData(person1));

            */














        }
    }
}
