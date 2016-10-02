/*
48. Rotate Image


You are given an n x n 2D matrix representing an image.

Rotate the image by 90 degrees (clockwise).

Follow up:
Could you do this in-place?


*/

public class Solution048 {
    // Rotate the matrix layer by layer
    public void Rotate(int[,] matrix) {
        int n = matrix.GetLength(0);
        int layerNum = n / 2;
        for (int layer = 0; layer < layerNum; layer++)
        {
            for(int i = layer; i < n - layer - 1; i++)
            {
                int temp = matrix[layer, i ]; // back the up layer
                // left to up
                matrix[layer, i] = matrix[n - 1 -i, layer];
                // bottom to left
                matrix[n-1-i, layer] = matrix[n - 1 -layer, n -1 -i];
                // right to bottom
                matrix[n-1-layer, n - 1 -i] = matrix[i, n -1 -layer];
                // up to right
                matrix[i, n-1-layer] = temp;                              
            }
        }
    }        
}