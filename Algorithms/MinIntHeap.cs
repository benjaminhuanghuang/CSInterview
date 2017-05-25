/*
    Data Structures: Heaps
    https://www.youtube.com/watch?v=t0Cq6tVNRBA&t=386s

    In a min heap the elements are all smaller than their children.
    Insert : got to the next empty spot looking top to bottom , left to right.
             Then "bubble up" the new element until it got to the right spot.


    Remove: Remove the root node, then "Swap the root" with the last element,
            Then "bubble down" the root node until it got to the right spot.

    Use array instead treenode makes it compact.  
        每层元素为 1, 2, 4... 2*n
        index of parent = (index - 1 ) / 2
        index of left child = index * 2 + 1
        index of right child = index * 2 + 1
 */

using System;

namespace CSInterview.Algorithms
{
    public class MinIntHeap
    {
        private int capacity = 10;
        private int size = 0;

        private int[] items = new int[10];


        private int GetLeftChildIndex(int index)
        {
            return 2 * index + 1;
        }

        private int GetRightChildIndex(int index)
        {
            return 2 * index + 2;
        }

        private int GetParentIndex(int index)
        {
            return (index - 1) / 2;
        }

        private bool HasLeftChild(int index)
        {
            return GetLeftChildIndex(index) < size;
        }

        private bool HasRightChild(int index)
        {
            return GetRightChildIndex(index) < size;
        }

        private bool HasParent(int index)
        {
            return GetParentIndex(index) >= 0;
        }

        private int LeftChild(int index)
        {
            return items[GetLeftChildIndex(index)];
        }

        private int RightChild(int index)
        {
            return items[GetRightChildIndex(index)];
        }

        private int Parent(int index)
        {
            return items[GetParentIndex(index)];
        }

        private void Swap(int i1, int i2)
        {
            int temp = items[i1];
            items[i1] = items[i2];
            items[i2] = temp;
        }

        private void EnsureExtraCapacity()
        {
            if (size == capacity)
            {
                int[] tmp = new int[capacity * 2];
                items.CopyTo(tmp, 0);
                items = tmp;
                capacity = capacity * 2;
            }
        }

        public int Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            return items[0];
        }

        public int Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            int item = items[0];
            items[0] = items[size - 1];
            size--;
            HeapifyDown();
            return item;
        }

        public void Add(int item)
        {
            EnsureExtraCapacity();
            items[size] = item;
            size++;
            HeapifyUp();
        }

        private void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))   //if there is no left child then there is certainly no right child
            {
                int smallerChildIndex = GetLeftChildIndex(index);
                if(HasRightChild(index) && RightChild(index)<LeftChild(index))
                {
                    smallerChildIndex = GetRightChildIndex(index);
                }

                if (items[index] < items[smallerChildIndex])
                {
                    break;
                }
                else
                {
                    Swap(index, smallerChildIndex);
                }
                index = smallerChildIndex;
            }
        }

        private void HeapifyUp()
        {
            int index = size - 1;
            while (HasParent(index) && Parent(index) > items[index])
            {
                Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }
        }
    }
}