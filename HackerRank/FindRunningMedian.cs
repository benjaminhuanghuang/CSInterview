/*

 */
using System.Collections;
using System.Collections.Generic;
namespace HackerRank
{
    public class RunningMedianSolution
    {
        public double[] GetMedians(int[] array)
        {
            // Max heap
            PriorityQueue<int> lowers = new PriorityQueue<int>();
            // Min heap
            PriorityQueue<int> highers = new PriorityQueue<int>();

            double[] medians = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                AddNumber(numbers, lowers, highers);
                Rebalance(lowers, heighers);
                medians = GetMedians(lowers, highers);
            }
        }

        private void AddNumber(int number, PriorityQueue<int> lowers, PriorityQueue<int> highers)
        {
            if (lowers.Length == 0 || number < lowers.Peek())
            {
                lowers.Add(number);
            }
            else
            {
                highers.Add(number);
            }
        }
        private void Rebalance(PriorityQueue<int> lowers, PriorityQueue<int> highers)
        {
            PriorityQueue<int> biggerHeap = lowers.Length > highers.Length ? lowers : highers;
            PriorityQueue<int> smallerHeap = lowers.Length > highers.Length ? highers : lowers;

            if(biggerHeap.Length - smallerHeap.Length >=2)
            {
                smallerHeap.Add(biggerHeap.Pop());
            }
        }

        private void GetMedians(int number, PriorityQueue<int> lowers, PriorityQueue<int> highers)
        {
            PriorityQueue<int> biggerHeap = lowers.Length > highers.Length ? lowers : highers;
            PriorityQueue<int> smallerHeap = lowers.Length > highers.Length ? highers : lowers;

            if(biggerHeap.Length == smallerHeap.Length)
            {
                return (biggerHeap.Peek() + smallerHeap.Peek()) / 2.0;
            }
            else
            {
                return biggerHeap.Peek();
            }
        }

    }




}

