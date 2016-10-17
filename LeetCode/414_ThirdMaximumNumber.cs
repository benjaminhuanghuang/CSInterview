/*
414. Third Maximum Number

Given an array of integers, return the 3rd Maximum Number in this array, 
if it doesn't exist, return the Maximum Number. The time complexity must be O(n) or less.
*/
using System;

public class Solution414 {
    public int ThirdMax(int[] nums) {
        int max1= int.MinValue;
        int max2= int.MinValue;
        int max3= int.MinValue;

        for (int i =0; i < nums.Length; i++)
        {
            if (nums[i] >= max1)
            {
                if (nums[i] > max1)
                {
                    max3 = max2;
                    max2 = max1;
                }
                max1= nums[i];
            }
            else
            {
                if (nums[i] >= max2){
                    if (nums[i] > max2)
                        max3 = max2; 
                    max2 = nums[i];                   
                }
                else
                {
                    if (nums[i] > max3)
                        max3= nums[i];
                }
            }
        }
        if (nums.Length < 3)
            return max1;
        return max3;
    }
}