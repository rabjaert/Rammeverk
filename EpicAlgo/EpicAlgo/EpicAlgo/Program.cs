﻿using EpicAlgo.Models;
using EpicAlgo.Trees.BinaryTree;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EpicAlgo
{
    class Program
    {
        static void Main(string[] args)
        {


            Actor person1 = new Actor("Roger", "Knutsen", 20);
            Actor person2 = new Actor("Robert", "Lundeby", 32);
            Actor person3 = new Actor("Robert", "Lundeby", 31);
            Actor person4 = new Actor("Snoop", "Dog", 40);
            Actor person5 = new Actor("Zelda", "Hambeg", 20);
            Actor person6 = new Actor("Niklas", "Berby", 31);
            Actor person7 = new Actor("Satan", "Satansen", 69);
            Actor person8 = new Actor("Juda", "Judasen", 40);


            // Comparer<Actor>.Create((x, y) => -x.Fornavn.CompareTo(y.Fornavn));
            var pizza = Comparer<Actor>.Create((x, y) => -y.Fornavn.CompareTo(x.Fornavn));

        //BinaryTree<Actor> actorTre = new BinaryTree<Actor>(Comparer<Actor>.Create((x, y) => -y.Fornavn.CompareTo(x.Fornavn)));
        BinaryTree<Actor> actorTre = new BinaryTree<Actor>(pizza);




            //TestGenericBinary<Actor> acaaatorTre = new TestGenericBinary<>(byFirstName);

            List<Actor> ikkeAvføring = new List<Actor>();
        ikkeAvføring.Add(person1);
        ikkeAvføring.Add(person2);
        ikkeAvføring.Add(person3);
        ikkeAvføring.Add(person4);
        ikkeAvføring.Add(person5);
        ikkeAvføring.Add(person6);
        ikkeAvføring.Add(person7);
        ikkeAvføring.Add(person8);

       actorTre.insertItemList(ikkeAvføring);



       actorTre.deleteNode(actorTre.root, person2);
       Console.WriteLine("\n");


        actorTre.inOrder(actorTre.root);
        }
    }
}
