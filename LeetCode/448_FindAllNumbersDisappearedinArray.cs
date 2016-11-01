/*
448. Find All Numbers Disappeared in an Array [Google]

Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice 
and others appear once.

Find all the elements of [1, n] inclusive that do not appear in this array.

Could you do it without extra space and in O(n) runtime? You may assume the returned list 
does not count as extra space.

Example:

Input:
[4,3,2,7,8,2,3,1]

Output:
[5,6]
*/
using System.Collections.Generic;

public class Solution448 {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        var res = new List<int>();
        for(int i=0; i< nums.Length; i++)
        {

        }

        return res;
    }
    private void Swap(int[] nums, int i, int j)
    {
        int tmp = nums[i];
        nums[i] = nums[j];
        nums[j] = tmp;
    }
}