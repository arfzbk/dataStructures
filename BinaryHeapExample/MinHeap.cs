using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryHeapExample
{
    public class MinHeap<T> : BHeap<T>, IEnumerable<T>
        where T : IComparable
    {
        public MinHeap() : base() { }
        public MinHeap(int size) : base(size) { }
        public MinHeap(ICollection<T> collection) : base(collection) { }
        protected override void HeapifyDown()
        {
            var index = 0;
            while (HasLeftChild(index))
            {
                var smallerIndex = GetLeftChildIndex(index);
                if(HasRightChild(index) && GetLeftChild(index).CompareTo(GetRightChild(index)) > 0)
                {
                    smallerIndex = GetRightChildIndex(index);
                }
                if(Array[index].CompareTo(Array[smallerIndex]) <= 0)
                {
                    break;
                }
                Swap(smallerIndex, index);
                index = smallerIndex;
            }
        }

        protected override void HeapifyUp()
        {
            var index = position - 1;
            while(!IsRoot(index) && GetParent(index).CompareTo(Array[index]) > 0)
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }
    }
}
