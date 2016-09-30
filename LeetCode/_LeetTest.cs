
using System;
using System.IO;
using System.Collections;

public class LeetTest {
    public static void Main(string[] args)
    {   
        int[] input = new int[]{10, 1, 2, 7, 6, 1, 5};
        var s = new Solution040();
        s.CombinationSum2(input, 8);         
    }
}