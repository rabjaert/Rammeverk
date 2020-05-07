using EpicAlgo.Models;
using EpicAlgo.Trees.BinaryTree;
using System;
using EpicAlgo.HashTables;
using System.Collections;
using System.Collections.Generic;

using EpicAlgo.Interfaces;
using EpicAlgo.Timer;

namespace EpicAlgo
{
    class Program
    {
        static void Main(string[] args)
        {




            
            //Actor Objects
            Actor person1 = new Actor("Roger", "Knutsen", 20);
            Actor person2 = new Actor("Robert", "Lundeby", 32);
            Actor person3 = new Actor("Robert", "Lundeby", 31);
            Actor person4 = new Actor("Snoop", "Dog", 40);
            Actor person5 = new Actor("Zelda", "Hambeg", 20);
            Actor person6 = new Actor("Niklas", "Berby", 31);
            Actor person7 = new Actor("Satan", "Satansen", 69);
            Actor person8 = new Actor("Juda", "Judasen", 40);

            
            //Actor List
            List<Actor> ikkeAvføring = new List<Actor>();
            ikkeAvføring.Add(person1);
            ikkeAvføring.Add(person2);
            ikkeAvføring.Add(person3);
            ikkeAvføring.Add(person4);
            ikkeAvføring.Add(person5);
            ikkeAvføring.Add(person6);
            ikkeAvføring.Add(person7);
            ikkeAvføring.Add(person8);

            // Comparer<Actor>.Create((x, y) => -x.Fornavn.CompareTo(y.Fornavn));
            var pizza = Comparer<Actor>.Create((x, y) => -y.Fornavn.CompareTo(x.Fornavn));

            //BinaryTree Example
            BinaryTree<Actor> testTre = new BinaryTree<Actor>(pizza);

            TestBinaryTree<Actor> testTre1 = new TestBinaryTree<Actor>(pizza);


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

            /*
            var intComparer = Comparer<Double>.Create((x, y) => -y.CompareTo(x));
            TestBinaryTree<double> intTre = new TestBinaryTree<double>(intComparer);
            TestBinaryTree<double> intTre1 = new TestBinaryTree<double>(intComparer);
            TestBinaryTree<double> intTre2 = new TestBinaryTree<double>(intComparer);

            List<ITree<double>> treelist = new List<ITree<double>>();
            treelist.Add(intTre);
            treelist.Add(intTre1);
            treelist.Add(intTre2);
            List<double> intList = new List<double>();
            Random ran = new Random();
            for (int i = 0; i < 50000; i++)
            {
              
                intList.Add(ran.NextDouble());
            }

            TreeTimer<double> treeTimer = new TreeTimer<double>(treelist);
            treeTimer.TakeTimeList(intList);
            treeTimer.Print();*/

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
            foreach (var element in table)
            {
                Console.WriteLine(element.Key + "   " + element.Value);
            }
            table.Remove(5);
            foreach (var element in table)
            {
                Console.WriteLine(element.Key + "   " + element.Value);
            }
            */

        }
    }
}
