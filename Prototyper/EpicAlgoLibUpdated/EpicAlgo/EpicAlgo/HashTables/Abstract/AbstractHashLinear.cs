﻿using System;
using System.Collections;
using System.Collections.Generic;



namespace EpicAlgo.HashTables.Abstract
{
    /// <summary>HashQuadratic class.</summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class AbstractHashLinear<K, T> : IEnumerable<KeyValuePair<K,T>>
    {

        /// <summary>The table</summary>
        
        protected KeyValuePair<K, T>[] Table;

        /// <summary>Gets the load factor.</summary>
        /// <value>The load factor.</value>
        protected double LoadFactor { get { if (Count == 0) return 0; else return Table.Length / Count; } }

        /// <summary>Gets or sets the count.</summary>
        /// <value>The count.</value>
        protected int Count { set; get; }

        private static int NumberOfInvokes { get; set; }

        /// <summary>Gets a value indicating whether this instance is read only.</summary>
        /// <value>
        ///   <c>true</c> if this instance is read only; otherwise, <c>false</c>.</value>
        /// <exception cref="NotImplementedException"></exception>
        protected bool IsReadOnly => throw new NotImplementedException();

        /// <summary>Initializes a new instance of the <see cref="AbstractHashQuadratic{K, T}" /> class.</summary>


        /// <summary>Gets the <see cref="T" /> with the specified key.</summary>
        /// <param name="key">The key.</param>
        /// <value>The <see cref="T" />.</value>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">There is no such element in the table!</exception>
        protected T this[K key]
        {
            get
            {
                if (!Contains(key))
                {
                    throw new ArgumentOutOfRangeException("There is no such element in the table!");
                }
                int attempt = 0;
                while (attempt <= Count)
                {
                    if (Table[GetIndex(key, attempt)].Key.Equals(key))
                    {
                        return Table[GetIndex(key, attempt)].Value;
                    }
                    attempt++;
                }
                return default(T);
            }
        }

        /// <summary>Gets the enumerator.</summary>
        /// <returns></returns>


        /// <summary>Adds the specified item.</summary>
        /// <param name="item">The item.</param>
        protected void Add(KeyValuePair<K, T> item)
        {
            Add(item.Key, item.Value);
        }

        /// <summary>Determines whether this instance contains the object.</summary>
        /// <param name="item">The item.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified item]; otherwise, <c>false</c>.</returns>
        protected bool Contains(KeyValuePair<K, T> item)
        {
            return Contains(item.Key);
        }

        /// <summary>Copies to.</summary>
        /// <param name="array">The array.</param>
        /// <param name="arrayIndex">Index of the array.</param>
        /// <exception cref="NotImplementedException"></exception>
        protected void CopyTo(KeyValuePair<K, T>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>Removes the specified item.</summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        protected bool Remove(KeyValuePair<K, T> item)
        {
            return Remove(item.Key);
        }

        /// <summary>Adds the specified key.</summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        protected void Add(K key, T value)
        {
            ResizeIfRequires();
            int attempt = 0;
            int index;
            while (true)
            {
                index = GetIndex(key, attempt);
                if (Table[index].Equals(default(KeyValuePair<K, T>)))
                {
                    Table[index] = new KeyValuePair<K, T>(key, value);
                    Count++;
                    return;
                }
                attempt++;
            }
        }

        /// <summary>Clears this instance.</summary>
        protected void Clear()
        {
            Table = new KeyValuePair<K, T>[16];
            Count = 0;
        }

        /// <summary>Determines whether this instance contains the object.</summary>
        /// <param name="key">The key.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified key]; otherwise, <c>false</c>.</returns>
        public bool Contains(K key)
        {
            int attempt = 0;
            while (attempt <= Count)
            {
                if (Table[GetIndex(key, attempt)].Key.Equals(key))
                {
                    return true;
                }
                attempt++;
            }
            return false;
        }

        /// <summary>Finds the index of key.</summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">There is no such element in the table!</exception>
        public int FindIndexOfKey(K key)
        {
            if (!Contains(key))
            {
                throw new ArgumentOutOfRangeException("There is no such element in the table!");
            }
            int attempt = 0;
            while (attempt <= Count)
            {
                if (Table[GetIndex(key, attempt)].Key.Equals(key))
                {
                    return GetIndex(key, attempt);
                }
                attempt++;
            }
            return default(Int32);
        }

        /// <summary>Gets the enumerator.</summary>
        /// <returns></returns>
        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {


            foreach (var p in Table)
            {
                yield return p;
            }

        }

        /// <summary>Gets the index.</summary>
        /// <param name="key">The key.</param>
        /// <param name="attempt">The attempt.</param>
        /// <returns></returns>
        public int GetIndex(K key, int attempt)
        {
            return Convert.ToInt32(Math.Abs((key.GetHashCode() + attempt) % Table.Length));

        }

        /// <summary>Removes the specified key.</summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public bool Remove(K key)
        {
            if (!Contains(key))
            {
                return false;

            }

            int index = FindIndexOfKey(key);
            Table[index] = default(KeyValuePair<K, T>);
            Count--;
            return true;
        }

        /// <summary>Resizes if requires.</summary>
        private void ResizeIfRequires()
        {
            if (LoadFactor < 0.75)
            {
                Table = new KeyValuePair<K, T>[PrimeCalc(Table.Length + NumberOfInvokes)];
            }
            
            NumberOfInvokes ++;
        }

        /// <summary>Calculates the prime number.</summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        private static int PrimeCalc(int number)
        {
            while (true)
            {
                bool isPrime = true;
                //increment the number by 1 each time
                number = number + 1;

                int squaredNumber = (int)Math.Sqrt(number);

                //start at 2 and increment by 1 until it gets to the squared number
                for (int i = 2; i <= squaredNumber; i++)
                {
                    //how do I check all i's?
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    return number;
            }
        }

        /// <summary>Prints this instance.</summary>
        public void Print()
        {

            foreach (var element in this)
            {
                if (!element.Key.Equals(default(K)))
                {
                    Console.WriteLine("Key:" + " " + element.Key
                 + "\n" + "Value:" + " " + element.Value + "\n");
                }


            }


        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}