/*
164. Maximum Gap

Given an unsorted array, find the maximum difference between the successive elements in its sorted form.

Try to solve it in linear time/space.

Return 0 if the array contains less than 2 elements.

You may assume all elements in the array are non-negative integers and fit in the 32-bit signed integer range.

*/
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution164 {
    //http://magicsong.xyz/leetcode/leetcode%E4%B9%8Bmaximum-gap%E8%A7%A3%E9%A2%98%E6%80%9D%E8%B7%AF%EF%BC%88c%EF%BC%89/
    // if we can sort it, it will be really easy. but it takes O(nlgn). 
    // Solve it in linear time. we can think about linear time sort, bucket sort algorithm.
    // put all int into 32 buckets according to its length. then sort each bucket to get the maximum gap.
    public int MaximumGap(int[] nums) {
        var res = 0;
        var buckets = new List<int>[32];
        for (int i = 0; i < 32; i++)
        {
            buckets[i] = new List<int>();
        }
        foreach (var i in nums)
        {
            var len = i.ToString().Length - 1;
            buckets[len].Add(i);
        }

        var previous = 0;
        for (int i = 0; i < buckets.Count(); i++)
        {
            buckets[i].Sort();

            for (int j = 0; j < buckets[i].Count; j++)
            {
                if(previous != 0) res = Math.Max(res, buckets[i][j] - previous);
                previous = buckets[i][j];
            }
        }

        return res;
    }
}


