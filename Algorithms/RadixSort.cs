using System;
using System.Collections;
using System.Collections.Generic;

 // http://algorithmsandstuff.blogspot.com/2014/06/radix-sort-in-c-sharp.html
 
 public class RadixSortDemo
 {
    private void SortArrayWithRadixSort()
    {
        int[] array = { 7, 5, 3, 6, 76, 45, 32 };
        int[] sortedArray = RadixSort(array);

        // PrintResult(sortedArray);
    }
    
    public int[] RadixSort(int[] array)
    {
        bool isFinished = false;
        int digitPosition = 0;

        List<Queue<int>> buckets = new List<Queue<int>>();
        InitializeBuckets(buckets);

        while (!isFinished)
        {
            isFinished = true;

            foreach (int value in array)
            {
                int bucketNumber = GetBucketNumber(value, digitPosition);
                if (bucketNumber > 0)
                {
                    isFinished = false;
                }

                buckets[bucketNumber].Enqueue(value);
            }

            int i = 0;
            foreach (Queue<int> bucket in buckets)
            {
                while (bucket.Count > 0)
                {
                    array[i] = bucket.Dequeue();
                    i++;
                }
            }

            digitPosition++;
        }

        return array;
    }

    private int GetBucketNumber(int value, int digitPosition)
    {
        int bucketNumber = (value / (int)Math.Pow(10, digitPosition)) % 10;
        return bucketNumber;
    }

    private static void InitializeBuckets(List<Queue<int>> buckets)
    {
        for (int i = 0; i < 10; i++)
        {
            Queue<int> q = new Queue<int>();
            buckets.Add(q);
        }
    }
 }

