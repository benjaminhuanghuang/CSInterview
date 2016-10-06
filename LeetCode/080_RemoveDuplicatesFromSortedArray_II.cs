/*
80. Remove Duplicates from Sorted Array II

Follow up for "Remove Duplicates":
What if duplicates are allowed at most twice?

For example,
Given sorted array nums = [1,1,1,2,2,3],

Your function should return length = 5, with the first five elements of nums being 1, 1, 2, 2 and 3. 
It doesn't matter what you leave beyond the new length.

Refer to 26. Remove Duplicates from Sorted Array

*/

using System;

public class Solution080 {
    public int RemoveDuplicates(int[] nums) {
        if(nums == null)
            return 0;
        if(nums.Length < 3)
            return nums.Length;
        
        int slow = 1;
        int fast = 2;
        while ( fast < nums.Length)
        {
            if (nums[fast] == nums[slow] && nums[fast] == nums[slow-1])
            {
                fast ++;
            }
            else{
                slow ++;
                nums[slow] = nums[fast];
                fast ++;
            }
        }   
        return slow + 1;     
    }
}