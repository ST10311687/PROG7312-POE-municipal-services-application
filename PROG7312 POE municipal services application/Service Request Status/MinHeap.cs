using System;
using System.Collections.Generic;

namespace PROG7312_POE_municipal_services_application.Service_Request_Status
{
    public class MinHeap<T>
    {
        private readonly List<T> _heap = new List<T>();
        private readonly IComparer<T> _comparer;

        public MinHeap() : this(Comparer<T>.Default) { }

        public MinHeap(IComparer<T> comparer)
        {
            _comparer = comparer ?? Comparer<T>.Default;
        }

        public int Count => _heap.Count;

        public void Add(T item)
        {
            _heap.Add(item);
            HeapifyUp(_heap.Count - 1);
        }

        public T Peek()
        {
            if (_heap.Count == 0)
                throw new InvalidOperationException("Heap is empty.");
            return _heap[0];
        }

        public T ExtractMin()
        {
            if (_heap.Count == 0)
                throw new InvalidOperationException("Heap is empty.");

            var min = _heap[0];
            _heap[0] = _heap[_heap.Count - 1];
            _heap.RemoveAt(_heap.Count - 1);
            if (_heap.Count > 0)
                HeapifyDown(0);

            return min;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0 && _comparer.Compare(_heap[index], _heap[(index - 1) / 2]) < 0)
            {
                var temp = _heap[index];
                _heap[index] = _heap[(index - 1) / 2];
                _heap[(index - 1) / 2] = temp;
                index = (index - 1) / 2;
            }
        }

        private void HeapifyDown(int index)
        {
            int smallest = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;

            if (left < _heap.Count && _comparer.Compare(_heap[left], _heap[smallest]) < 0)
                smallest = left;

            if (right < _heap.Count && _comparer.Compare(_heap[right], _heap[smallest]) < 0)
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

