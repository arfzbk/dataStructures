using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryHeapExample
{
    public class MaxHeap<T> : BHeap<T>, IEnumerable<T>
        where T : IComparable
    {
        public MaxHeap() : base() { }
        public MaxHeap(int size) : base(size) { }
        public MaxHeap(ICollection<T> collection) : base(collection) { }
        protected override void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var biggerIndex = GetLeftChildIndex(index);
                if(HasRightChild(index) && GetLeftChild(index).CompareTo(GetRightChild(index)) < 0)
                {
                    biggerIndex = GetRightChildIndex(index);
                }
                if(Array[index].CompareTo(Array[biggerIndex]) >= 0)
                {
                    break;
                }
                Swap(biggerIndex, index);
                index = biggerIndex;
            }
        }

        protected override void HeapifyUp()
        {
            int index = position - 1;
            while(!IsRoot(index) && GetParent(index).CompareTo(Array[index]) < 0)
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }
    }
}
