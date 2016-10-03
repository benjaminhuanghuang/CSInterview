/*
60. Permutation Sequence

The set [1,2,3,…,n] contains a total of n! unique permutations.

By listing and labeling all of the permutations in order,
We get the following sequence (ie, for n = 3):

"123"
"132"
"213"
"231"
"312"
"321"
Given n and k, return the kth permutation sequence.

Note: Given n will be between 1 and 9 inclusive.
*/
using System;
using System.Linq;
using System.Text;

public class Solution060 {
    // 1~n的排列数有n! ，但如果我们第一个位置上放1，那么有(n-1)!种排列。
    // 故，对于k，首先确定第一个数放几，然后第二个数……，一直到第n个数。
    public string GetPermutation(int n, int k) {
        if(n <=0)
            return "";
        var factorial = new int[n];
        factorial[0]= 1;
        for(int i = 1; i< n; i++)
            factorial[i] = i * factorial[i -1];
        
        var res = new StringBuilder();
        var candi = Enumerable.Range(1, n).ToList();
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("i = {0}, k ={1}", i, k);
            var index = (k - 1)/factorial[n - i];
            k -= index * factorial[n - i];
            res.Append(candi[index]);
            candi.RemoveAt(index);
        }

        return res.ToString();
    }
}