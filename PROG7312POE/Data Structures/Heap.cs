using System;
using System.Collections.Generic;

namespace PROG7312POE
{
    public class Heap<T> where T : class
    {
        private List<T> elements = new List<T>();
        private Func<T, T, int> comparer;

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Initializes a new instance of the Heap class with a specified comparer function.
        /// </summary>
        public Heap(Func<T, T, int> comparer)
        {
            this.comparer = comparer;
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Gets the number of elements in the heap.
        /// </summary>
        public int Count => elements.Count;

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Inserts an element into the heap.
        /// </summary>
        public void Insert(T element)
        {
            elements.Add(element);
            HeapifyUp(elements.Count - 1);
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Removes and returns the maximum element from the heap.
        /// </summary>
        public T RemoveMax()
        {
            if (Count == 0) throw new InvalidOperationException("Heap is empty");

            T root = elements[0];
            elements[0] = elements[Count - 1];
            elements.RemoveAt(Count - 1);
            HeapifyDown(0);
            return root;
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Restores the heap property by moving the element at the specified index up.
        /// </summary>
        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (comparer(elements[index], elements[parentIndex]) > 0)
                {
                    Swap(index, parentIndex);
                    index = parentIndex;
                }
                else
                {
                    break;
                }
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Restores the heap property by moving the element at the specified index down.
        /// </summary>
        private void HeapifyDown(int index)
        {
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;
            int largest = index;

            if (leftChild < Count && comparer(elements[leftChild], elements[largest]) > 0)
            {
                largest = leftChild;
            }

            if (rightChild < Count && comparer(elements[rightChild], elements[largest]) > 0)
            {
                largest = rightChild;
            }

            if (largest != index)
            {
                Swap(index, largest);
                HeapifyDown(largest);
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Swaps the elements at the specified indices.
        /// </summary>
        private void Swap(int i, int j)
        {
            T temp = elements[i];
            elements[i] = elements[j];
            elements[j] = temp;
        }
    }
}
//<-------------------------------------------------------------------END OF FILE-------------------------------------------------------------------------------->//
