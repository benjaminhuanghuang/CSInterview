/*
378. Kth Smallest Element in a Sorted Matrix  


Given a n x n matrix where each of the rows and columns are sorted in ascending order, 
find the kth smallest element in the matrix.

Note that it is the kth smallest element in the sorted order, not the kth distinct element.

Example:

matrix = [
   [ 1,  5,  9],
   [10, 11, 13],
   [12, 13, 15]
],
k = 8,

return 13.
Note: 
You may assume k is always valid, 1 ≤ k ≤ n2.
*/
using System.Collections.Generic;

public class Solution378
{
    // you are already iterating the full matrix, by this time we can tell the kth smallest, 
    // but the input is sorted so that we will avoid full traversal, on top of it you are 
    // sorting which is o(n log n). No interviewer accepts this answer.
    public int KthSmallest_Lazy(int[,] matrix, int k)
    {
        int h = matrix.GetLength(0);
        List<int> list = new List<int>();
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < h; j++)
                list.Add(matrix[i, j]);
        }
        list.Sort();
        return list[k - 1];
    }

    public int KthSmallest(int[,] matrix, int k)
    {
        int n = matrix.GetLength(0);
        int low = matrix[0, 0];
        int high = matrix[n - 1, n - 1];

        while (low < high)
        {
            // 注意优先级
            int mid = low + ((high - low) >> 1);
            int count = this.count(matrix, mid);
            if (count < k)
                low = mid + 1;
            else
                high = mid;
        }
        return low;
    }

    private int count(int[,] matrix, int target)
    {
        int m = matrix.GetLength(0);
        int i = m - 1;
        int j = 0;
        int count = 0;

        while (i >= 0 && j < m)
        {
            if (matrix[i, j] <= target)
            {
                count += i + 1;
                j++;
            }
            else
            {
                i--;
            }
        }

        return count;
    }
}