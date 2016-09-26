/*
4. Median of Two Sorted Arrays
There are two sorted arrays nums1 and nums2 of size m and n respectively.

Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).

Example 1:
nums1 = [1, 3]
nums2 = [2]

The median is 2.0
Example 2:
nums1 = [1, 2]
nums2 = [3, 4]

The median is (2 + 3)/2 = 2.5
*/

using System;
using System.Collections;
using System.Linq;

public class Solution004 {
    public double FindMedianSortedArrays_Naive(int[] nums1, int[] nums2) {
        double answer = 0;
        // Contact in Linq
        int[] combined = nums1.Concat(nums2).ToArray();
        Array.Sort(combined);
        int length = combined.Length;
        if (length % 2 == 0)
        {
            answer = (combined[length/2-1] + combined[length/2]) /2.0;   
        }
        else
        {
            if (length ==1)
            {
                answer = combined[0];
            }
            else
            {
                answer = combined[length/2];
            }   
        }
        return answer;
    }
}