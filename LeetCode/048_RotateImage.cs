/*
48. Rotate Image


You are given an n x n 2D matrix representing an image.

Rotate the image by 90 degrees (clockwise).

Follow up:
Could you do this in-place?


*/

public class Solution {
    // https://www.tianmaying.com/tutorial/LC48
    public void Rotate(int[,] matrix) {
        int n = matrix.GetLength(0);

        //for (int i = 0; i < Math.Ceiling(n / 2.0); i++)
        for (int i = 0; i < (n / 2 + 1); i++)
        {
            for (int j = i; j < n - i - 1; j++)
            {
                var temp = matrix[i, j];

                matrix[i, j] = matrix[n - j - 1, i];
                matrix[n - j - 1, i] = matrix[n - 1 - i, n - j - 1];
                matrix[n - 1 - i, n - j - 1] = matrix[j, n - 1 - i];
                matrix[j, n - 1 - i] = temp;
            }
        }
    }        
    
    // * 1 2 3       7 8 9       7 4 1
    // * 4 5 6 =>    4 5 6 =>    8 5 2
    // * 7 8 9       1 2 3       9 6 3
    public void Rotate(int[,] matrix)
    {
        var m = matrix.GetLength(0);
        var n = matrix.GetLength(1);

        for (var i = 0; i < m / 2; i++)
        {
            for (var j = 0; j < n; j++)
            {
                var temp = matrix[i, j];
                matrix[i,j] = matrix[n - 1 - i, j];
                matrix[n - 1 - i, j] = temp;
            }
        }
        
        for (var i = 0; i < m; ++i)
        {
            for (var j = i + 1; j < n; ++j)
            {
                var temp = matrix[i, j];
                matrix[i, j] = matrix[j,i];
                matrix[j, i] = temp;
            }
        }
    }
}