/*
33. Search in Rotated Sorted Array

Suppose a sorted array is rotated at some pivot unknown to you beforehand.

(i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

You are given a target value to search. If found in the array return its index, 
otherwise return -1.

You may assume no duplicate exists in the array.
*/

public class Solution033 {
    // if mid is greater than low, then we know mid is in the left part. 
    //  if x >= low and x < mid. search left part, otherwise search right part;
    // if mid is less than low, then we know mid is in the right part. 
    //  if x <= high and x > mid. search the right part, otherwise search left part;
    // if mid is equal to low, just increase the low (we do not know where the target x would be)
    public int Search(int[] nums, int target) {
        if (nums == null || nums.Length < 1)
            return -1;

        return this.SearchInRotatedArrayRecursion(nums, 0, nums.Length -1, target);
    }

    private int SearchInRotatedArrayRecursion(int[] array, int low, int high, int x)
    {          
        if (low > high)
        {
            return -1;
        }
        var mid = (high - low) / 2 + low;
        if (array[mid] == x)
            return mid;
      
        // left part is increasing
        if (array[mid] > array[low])
        {
            if (x >= array[low] && x < array[mid])
            {
                return this.SearchInRotatedArrayRecursion(array, low, mid - 1, x);
            }
            else
            {
                return this.SearchInRotatedArrayRecursion(array, mid + 1, high, x);
            }
        }
        // right part is increasing
        else if (array[mid] < array[low])             
        {                 
            if (x > array[mid] && x <= array[high])
            {
                return this.SearchInRotatedArrayRecursion(array, mid + 1, high, x);
            }
            else
            {
                return this.SearchInRotatedArrayRecursion(array, low, mid - 1, x);
            }
        }
        // left part are all same, just increase low by 1
        else
        {
            return this.SearchInRotatedArrayRecursion(array, low + 1, high, x);
        }
    }


    public int Search_better(int[] nums, int target) {
        if (nums == null || nums.Length < 1)
            return -1;

        int left = 0;
        int right = nums.Length -1;

        while (left <= right)
        {
            if (nums[left] == target)
                return left;
            if (nums[right] == target)
                return right;

            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
                return mid;

            if (nums[mid] > nums[left])
            {
                // mid located in left part, which is increasing
                if (nums[left] < target && target < nums[mid])
                    right = mid -1;
                else
                    left = mid + 1;
            }
            else
            {
                // mid located in right part, which is increasing
                if (nums[mid] < target && target < nums[right])
                    left = mid + 1;
                else
                    right = mid - 1;
            }
        }

        return -1;
    }
}