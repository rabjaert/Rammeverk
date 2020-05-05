using EpicAlgo.Models;
using EpicAlgo.Trees.BinaryTree;
using System;
using EpicAlgo.HashTables;
using System.Collections;
using System.Collections.Generic;
using EpicAlgo.Timers;
using EpicAlgo.Timer;
using EpicAlgo.Interfaces;

namespace EpicAlgo
{
    class Program
    {
        static void Main(string[] args)
        {




            /*
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
            testTre.AddDataList(ikkeAvføring);
            
            testTre.PrintInOrder(testTre.GetRoot());
            */
            //var pizza = Comparer<Actor>.Create((x, y) => y.Fornavn.CompareTo(x.Fornavn));



            Console.WriteLine("");
            var intComparer = Comparer<Double>.Create((x, y) => -y.CompareTo(x));


            HashQuadratic<int, Double> hashtable = new HashQuadratic<int, Double>();
            HashQuadratic<int, Double> hashtable1 = new HashQuadratic<int, Double>();

            BinaryTree<Double> intTre = new BinaryTree<Double>(intComparer);
            BinaryTree<Double> intTre1 = new BinaryTree<Double>(intComparer);



            List<ITree<Double>> myList = new List<ITree<Double>>();

            myList.Add(intTre);
            myList.Add(intTre1);

            List<IHashTable<int, Double>> hashlist = new List<IHashTable<int, Double>>();

            hashlist.Add(hashtable);
            hashlist.Add(hashtable1);


            Tester<int, Double> test = new Tester<int, Double>(myList, hashlist);

            double d = 2.1;
            test.Add(d);
            Console.WriteLine();

            test.print();

            /*

            List<Double> intList = new List<Double>();
            Random ran = new Random();
            for (int i = 0; i < 50000; i++)
            {
              
                intList.Add(ran.NextDouble());
            }
            intTre.AddDataList(intList);
            intTre.PrintInOrder(intTre.GetRoot());
            Console.WriteLine("Test av timer:");
            intTre.TakeTime(intList);
            /*


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
