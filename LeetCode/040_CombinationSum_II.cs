/*
40. Combination Sum II

Given a collection of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.

Each number in C may only be used once in the combination.

Note:
All numbers (including target) will be positive integers.
The solution set must NOT contain duplicate combinations.
For example, given candidate set [10, 1, 2, 7, 6, 1, 5] and target 8, 
A solution set is: 
[
  [1, 7],
  [1, 2, 5],
  [2, 6],
  [1, 1, 6]
]

*/

using System;
using System.Collections.Generic;


public class Solution040 {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        var res = new List<IList<int>>();
        CombinationSumHelper(candidates, target, 0, new List<int>(), res);
        return res; 
    }


    private void CombinationSumHelper(int[] candidates, int target, int index, IList<int> combination, IList<IList<int>> res)
    {
        if (target == 0)
        {
            res.Add(new List<int>(combination));
            return;
        }
        // Important!
        if (target < 0)
        {
            return;
        }
        for (int j = index; j < candidates.Length; j++)         
        {             
            // candidates is sorted
            // j > index will skip the same combination, no combination
            if (j > index && candidates[j] == candidates[j - 1]) 
                continue;
            combination.Add(candidates[j]);
            CombinationSumHelper(candidates, target - candidates[j] , j + 1, combination, res);
            combination.RemoveAt(combination.Count - 1);
        }
    }   
}