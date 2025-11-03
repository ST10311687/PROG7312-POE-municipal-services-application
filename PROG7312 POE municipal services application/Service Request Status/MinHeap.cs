using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE_municipal_services_application.Service_Request_Status
{
    public class MinHeap<T>
    {
        private readonly List<T> _heap = new List<T>();

        /// <summary>
        /// Adds an item to the heap and maintains the heap property.
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            _heap.Add(item);
            HeapifyUp(_heap.Count - 1);
        }

        /// <summary>
        /// Extracts and returns the minimum item from the heap.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public T ExtractMin()
        {
            if (_heap.Count == 0)
                throw new InvalidOperationException("Heap is empty.");

            var min = _heap[0];
            _heap[0] = _heap[_heap.Count - 1];
            _heap.RemoveAt(_heap.Count - 1);
            HeapifyDown(0);

            return min;
        }

        /// <summary>
        /// Reorganizes the heap upwards starting from the specified index.
        /// </summary>
        /// <param name="index"></param>
        private void HeapifyUp(int index)
        {
            while (index > 0 && Comparer<T>.Default.Compare(_heap[index], _heap[(index - 1) / 2]) < 0)
            {
                var temp = _heap[index];
                _heap[index] = _heap[(index - 1) / 2];
                _heap[(index - 1) / 2] = temp;

                index = (index - 1) / 2;
            }
        }

        /// <summary>
        /// Reorganizes the heap downwards starting from the specified index.
        /// </summary>
        /// <param name="index"></param>
        private void HeapifyDown(int index)
        {
            int smallest = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;

            if (left < _heap.Count && Comparer<T>.Default.Compare(_heap[left], _heap[smallest]) < 0)
                smallest = left;

            if (right < _heap.Count && Comparer<T>.Default.Compare(_heap[right], _heap[smallest]) < 0)
                smallest = right;

            if (smallest != index)
            {
                var temp = _heap[index];
                _heap[index] = _heap[smallest];
                _heap[smallest] = temp;

                HeapifyDown(smallest);
            }
        }
    }
}
