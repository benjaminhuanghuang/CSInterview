/*
120. Triangle

Given a triangle, find the minimum path sum from top to bottom. Each step you may move to 
adjacent numbers on the row below.

For example, given the following triangle
[
     [2],
    [3,4],
   [6,5,7],
  [4,1,8,3]
]
The minimum path sum from top to bottom is 11 (i.e., 2 + 3 + 5 + 1 = 11).

Note:
Bonus point if you are able to do this using only O(n) extra space, where n is the total number of rows in the triangle.


*/
using System.Collections.Generic;

public class Solution120 {
    public int MinimumTotal(IList<IList<int>> triangle) {
        if (triangle.Count == 0)
        {
            return 0;
        }
        var mimimumPath = int.MaxValue;
        var dp = new int[triangle.Count];
        for (var i = 0; i < dp.Length; i++)
        {
            dp[i] = int.MaxValue;
        }

        dp[0] = triangle[0][0];
        for (int j = 1; j >= 0; j--)
        {
            if (j == 0)
            {
                dp[j] = dp[j] + triangle[i][j];
            }
            else
            {
                dp[j] = Math.Min(dp[j - 1], dp[j]) + triangle[i][j];
            }
        }
        

        foreach (var path in dp)
        {
            if (path < mimimumPath)
            {
                mimimumPath = path;
            }
        }

        return mimimumPath;
    }
}