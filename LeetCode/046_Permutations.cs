/*
46. Permutations

Given a collection of distinct numbers, return all possible permutations.

For example,
[1,2,3] have the following permutations:
[
  [1,2,3],
  [1,3,2],
  [2,1,3],
  [2,3,1],
  [3,1,2],
  [3,2,1]
]
*/
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution046 {
    public IList<IList<int>> Permute(int[] nums) {
        Array.Sort(nums);
        var res = new List<IList<int>>();

        this.Permute_Recursion(nums, new List<int>(), res);

        return res;
    }

    public void Permute_Recursion(int[] nums, List<int> combination, IList<IList<int>> res) 
    {
        if (nums.Length == 0)
        {
            res.Add(new List<int>(combination)); // back trace need copy the combination
            return;
        }
        for (int i = 0 ; i< nums.Length; i++)
        {
            combination.Add(nums[i]);
            this.Permute_Recursion(nums.Where((t, j) => j != i).ToArray(), combination, res );
            combination.RemoveAt(combination.Count - 1);
        }
    }

    public IList<IList<int>> Permute_Iteration(int[] nums) {
        var res = new List<IList<int>>() { nums };

        for (int i = 0; i < nums.Length; i++)
        {
            var resnext = new List<IList<int>>();
            foreach (var result in res)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    this.Swap(result, i, j);
                    resnext.Add(new List<int>(result));
                }

            }

            res = resnext;
        }

        return res;
    }

    private void Swap(IList<int> list, int i,int j)
    {
        int tmp = list[i];
        list[i] = list[j];
        list[j] = tmp;
    }
}