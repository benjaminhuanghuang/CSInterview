/*
47. Permutations II

Given a collection of numbers that might contain duplicates, return all possible unique permutations.

For example,
[1,1,2] have the following unique permutations:
[
  [1,1,2],
  [1,2,1],
  [2,1,1]
]
*/
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution047 {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        Array.Sort(nums);
        var res = new List<IList<int>>();

        this.Permute_Recursion(nums, 0, res);

        return res;
    }

    public void Permute_Recursion(int[] nums, int index, IList<IList<int>> res) 
    {
        var used = new Dictionary<int, bool>();
        if (index == nums.Length)
        {
            res.Add(new List<int>(nums)); // back trace need copy the combination
            return;
        }
        for (int i = index ; i< nums.Length; i++)
        {
            if (!used.ContainsKey(nums[i]))
            {
                this.Swap(nums, i, index);
                this.Permute_Recursion(nums, index + 1, res);
                this.Swap(nums, index, i);

                used.Add(nums[i], true);
            }
        }
    }

    private void Swap(int[] nums, int i,int j)
    {
        int tmp = nums[i];
        nums[i] = nums[j];
        nums[j] = tmp;
    }
}