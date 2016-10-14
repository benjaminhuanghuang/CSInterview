/*
131. Palindrome Partitioning

Given a string s, partition s such that every substring of the partition is a palindrome.

Return all possible palindrome partitioning of s.

For example, given s = "aab",
Return

[
  ["aa","b"],
  ["a","a","b"]
]
*/

using System.Collections.Generic;

public class Solution131 {
    public IList<IList<string>> Partition(string s) {
         var res = new List<IList<string>>();
         return PartitionRecursion(res, s, 0);
         return res;
    }

    private IList<IList<string>> PartitionRecursion(List<IList<string>> res, string s, int index)
    {
        if (index >= s.Length)
        {
            return;
        }

        for (int i = index; i < s.Length; i++)
        {
            var str = s.Substring(index, i - index + 1);
            if (isPartition(str))
            {
                PartitionRecursion(s, i + 1);

                foreach (var restPartition in restPartitions)
                {
                    var newPartition = new List<string> {str};
                    newPartition.AddRange(restPartition);
                    res.Add(newPartition);
                }
            }
        }

        return res;
    }

    private bool isPartition(string str)
    {
        for (int i = 0, j = str.Length - 1; i < j; i++, j--)
        {
            if (str[i] != str[j])
            {
                return false;
            }
        }

        return true;
    }
}