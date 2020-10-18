using EpicAlgo.HashTables;
using EpicAlgo.Models;
using EpicAlgo.Timers.Timer;
using EpicAlgo.Trees.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMetodAddingBinaryTree()
        {

            var AgeComparer = Comparer<Actor>.Create((x, y) => -x.Alder.CompareTo(y.Alder));
            BinaryTree<Actor> ActorTree = new BinaryTree<Actor>(AgeComparer);


            var actual = new Actor("Roger", "Knutsen", 67);

            ActorTree.Add(actual);

            Assert.AreEqual(ActorTree.FindData(actual), actual);

        }

        [TestMethod]
        public void TestMethodContainsBinaryTree()
        {

            var AgeComparer = Comparer<Actor>.Create((x, y) => -x.Alder.CompareTo(y.Alder));
            BinaryTree<Actor> ActorTree = new BinaryTree<Actor>(AgeComparer);


            var actual = new Actor("Roger", "Knutsen", 67);
            ActorTree.Add(actual);
            ActorTree.Add(new Actor("test", "test", 19));

            //should return true
            Assert.IsTrue(ActorTree.Contains(actual));

        }

        [TestMethod]
        public void TestMethodAddingHashTable()
        {
            HashQuadratic<int, string> HashString = new HashQuadratic<int, string>();
            HashString.Add(new KeyValuePair<int, string>(1, "Peter"));


            HashLinear<int, string> HashString1 = new HashLinear<int, string>();
            HashString1.Add(new KeyValuePair<int, string>(1, "Peter"));

            //should return true
            Assert.IsTrue(HashString.Contains(1));
            Assert.IsTrue(HashString1.Contains(1));

        }
        [TestMethod]
        public void TestMethodRemoveHashTable()
        {
            HashQuadratic<int, string> HashString = new HashQuadratic<int, string>();
            HashString.Add(new KeyValuePair<int, string>(1, "Peter"));


            HashLinear<int, string> HashString1 = new HashLinear<int, string>();
            HashString1.Add(new KeyValuePair<int, string>(1, "Peter"));

            //should return true

            Assert.IsTrue(HashString.Remove(1));
            Assert.IsTrue(HashString1.Remove(1));


        }

        [TestMethod]
        public void TestMethodTimer()
        {
            HashQuadratic<int, int> HashQuadraticTimer = new HashQuadratic<int, int>();
            HashLinear<int, int> HashLinearTimer = new HashLinear<int, int>();
            HashTimer<int, int> HashTimer1 = new HashTimer<int, int>(HashQuadraticTimer);
            HashTimer<int, int> HashTimer2 = new HashTimer<int, int>(HashLinearTimer);

            KeyValuePair<int, int> KvpArrayTest = new KeyValuePair<int, int>();
            for (int i = 0; i < 1000; i++)
            {
                KeyValuePair<int, int> temp = new KeyValuePair<int, int>(i, i / 2);

            }


            HashTimer1.TakeTimeOfInsert(KvpArrayTest);
            HashTimer1.TakeTimeOfRemove(KvpArrayTest);

            HashTimer2.TakeTimeOfInsert(KvpArrayTest);
            HashTimer2.TakeTimeOfRemove(KvpArrayTest);




            Assert.IsTrue(HashTimer1.InsertDictionary.Count > 0);
            Assert.IsTrue(HashTimer1.RemoveDictionary.Count > 0);

            Assert.IsTrue(HashTimer2.InsertDictionary.Count > 0);
            Assert.IsTrue(HashTimer2.RemoveDictionary.Count > 0);


        }






























    }
}
