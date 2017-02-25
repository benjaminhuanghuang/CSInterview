
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
        int[,] matrix = new int[,] { {1, 2,3}, {4,5, 6},{7,8,9} };
        var s = new Solution498();
        var array = s.FindDiagonalOrder(matrix);
        foreach (var i in array)
        {
            Console.WriteLine(i);
        }
    }
}