/*
26. Remove Duplicates from Sorted Array

Given a sorted array, remove the duplicates in place such that each element appear only 
once and return the new length.

Do not allocate extra space for another array, you must do this in place with constant memory.

For example,
Given input array nums = [1,1,2],

Your function should return length = 2, with the first two elements of nums being 1 and 2 
respectively. "It doesn't matter what you leave beyond the new length."
*/

using System;

public class Solution026 {
    public int RemoveDuplicates_Wrong(int[] nums) {
        if (nums == null)
            return 0;
        int len = nums.Length;
        if (len < 2)
            return len;

        int i = 1;
        int right = len - 1;
        int prev = nums[0];
        while (i < right)
        {   
            int curr = nums[i]; 
            if (prev == curr)
            {
                this.SwapArrayElements(nums, i, right);
                right --;    
            }
            else
            {
                i ++;
            }
        }
        return right - (i - 1) + 1;
    }
    public void SwapArrayElements(int[] nums, int i, int j)
    {
        int tmp = nums[i];
        nums[i] = nums[j];
        nums[j] = tmp; 
    }

    public int RemoveDuplicates(int[] nums) {
        if (nums == null)
            return 0;
        int len = nums.Length;
        if (len < 2)
            return len;
        int size = 0;
        for (int i =0 ;i < len ; i++)
        {
            if (nums[size] != nums[i])
            {
                size ++;
                nums[size] = nums[i];
            }
        }
        return size + 1;
    }
}