using EpicAlgo.Interfaces;
using EpicAlgo.Trees.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EpicAlgo.Trees.BinaryTree
{
    public class BinaryTree<T> : AbstractBinaryTree<T>, ITree<T>
    {

        public BinaryTree(Comparer<T> comparer)
        {
            base.Root = null;
            base.Comparer = comparer;

        }
        public int Count => throw new NotImplementedException();
        public bool IsReadOnly => throw new NotImplementedException();
       
        /// <summary>Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1">ICollection</see>.</summary>
        /// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1">ICollection</see>.</param>
        public void Add(T item)
        {
            AddData(item);
        }
        
        /// <summary>Adds the array with a loop.</summary>
        /// <param name="data">The data.</param>
        public void AddArray(T[] data)
        {
            for (var i = 0; i < data.Length; i++)
            {
                AddData(data[i]);
            }
        }
        
        /// <summary>Adds the list¨with a loop.</summary>
        /// <param name="data">The data.</param>
        public void AddList(List<T> data)
        {
            for (var i = 0; i < data.Count; i++)
            {
                AddData(data[i]);
            }
        }
       
        /// <summary>Finds the data.</summary>
        /// <param name="data">The data.</param>
        /// <returns>data</returns>
        public T FindData(T data)
        {
            return base.FindNode(Root, data).GetData();
        }
        
        /// <summary>Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1">ICollection</see>.</summary>
        public void Clear()
        {
            DeleteTree(Root);
        }
        
        /// <summary>Determines whether this instance contains the object.</summary>
        /// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.ICollection`1">ICollection</see>.</param>
        /// <returns>
        ///   <span class="keyword">
        ///     <span class="languageSpecificText">
        ///       <span class="cs">true</span>
        ///       <span class="vb">True</span>
        ///       <span class="cpp">true</span>
        ///     </span>
        ///   </span>
        ///   <span class="nu">
        ///     <span class="keyword">true</span> (<span class="keyword">True</span> in Visual Basic)</span> if <paramref name="item" /> is found in the <see cref="T:System.Collections.Generic.ICollection`1">ICollection</see>; otherwise, <span class="keyword"><span class="languageSpecificText"><span class="cs">false</span><span class="vb">False</span><span class="cpp">false</span></span></span><span class="nu"><span class="keyword">false</span> (<span class="keyword">False</span> in Visual Basic)</span>.
        /// </returns>
        
        public bool Contains(T item)
        {
            return RContains(Root, item);
        }
        /// <summary>
        /// Copies the elements of the <see cref="T:System.Collections.Generic.ICollection`1">ICollection</see> to an <see cref="T:System.Array">Array</see>, starting at a particular <see cref="T:System.Array">Array</see> index.
        /// </summary>
        /// <param name="array">
        /// The one-dimensional <see cref="T:System.Array">Array</see> that is the destination of the elements copied from <see cref="T:System.Collections.Generic.ICollection`1">ICollection</see>. The <see cref="T:System.Array">Array</see> must have zero-based indexing.
        /// </param>
        /// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>Returns an enumerator that iterates through the collection.</summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>Prints the items in order.</summary>
        public void PrintInOrder()
        {
            base.PrintInOrder(Root);
        }
        
        /// <summary>Prints the items post order.</summary>
        public void PrintPostOrder()
        {
            base.PrintPostOrder(Root);
        }
        
        /// <summary>Prints the items pre order.</summary>
        public void PrintPreOrder()
        {
            base.PrintPreOrder(Root);
        }
       
        /// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.Generic.ICollection`1">ICollection</see>.</summary>
        /// <param name="item">The object to remove from the <see cref="T:System.Collections.Generic.ICollection`1">ICollection</see>.</param>
        /// <returns>
        ///   <span class="keyword">
        ///     <span class="languageSpecificText">
        ///       <span class="cs">true</span>
        ///       <span class="vb">True</span>
        ///       <span class="cpp">true</span>
        ///     </span>
        ///   </span>
        ///   <span class="nu">
        ///     <span class="keyword">true</span> (<span class="keyword">True</span> in Visual Basic)</span> if <paramref name="item" /> was successfully removed from the <see cref="T:System.Collections.Generic.ICollection`1">ICollection</see>; otherwise, <span class="keyword"><span class="languageSpecificText"><span class="cs">false</span><span class="vb">False</span><span class="cpp">false</span></span></span><span class="nu"><span class="keyword">false</span> (<span class="keyword">False</span> in Visual Basic)</span>. This method also returns <span class="keyword"><span class="languageSpecificText"><span class="cs">false</span><span class="vb">False</span><span class="cpp">false</span></span></span><span class="nu"><span class="keyword">false</span> (<span class="keyword">False</span> in Visual Basic)</span> if <paramref name="item" /> is not found in the original <see cref="T:System.Collections.Generic.ICollection`1">ICollection</see>.
        /// </returns>
        public bool Remove(T item)
        {
            if (DeleteNode(Root, item).GetData().Equals(item))
            {
                return true;
            }
            else return false;
        }
        
        /// <summary>Returns an enumerator that iterates through a collection.</summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator">IEnumerator</see> object that can be used to iterate through the collection.</returns>
        /// <exception cref="NotImplementedException"></exception>
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
