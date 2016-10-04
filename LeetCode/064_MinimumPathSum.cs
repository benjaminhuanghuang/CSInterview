/*
64. Minimum Path Sum
Given a m x n grid filled with non-negative numbers, find a path from top left to bottom 
right which minimizes the sum of all numbers along its path.

Note: You can only move either down or right at any point in time.
*/


using System;

public class Solution064 {
    public int MinPathSum(int[,] grid) {
        var dp = new int[grid.GetLength(0), grid.GetLength(1)];

        dp[0, 0] = grid[0,0];
        // rows
        for (int i = 1; i < grid.GetLength(0); i++)
        {
            dp[i, 0] = dp[i - 1, 0] + grid[i, 0];
        }
        // cols
        for (int i = 1; i < grid.GetLength(1); i++)
        {
            dp[0, i] = dp[0, i - 1] + grid[0, i];
        }

        for (int i = 1; i < grid.GetLength(0); i++)
        {
            for (int j = 1; j < grid.GetLength(1); j++)
            {
                dp[i, j] = Math.Min(dp[i - 1, j] + grid[i,j], dp[i, j - 1] + grid[i,j]);
            }
        }

        return dp[grid.GetLength(0) - 1, grid.GetLength(1) - 1];
    }
}