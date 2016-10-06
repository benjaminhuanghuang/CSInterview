
using System;
using System.IO;
using System.Collections;

public class LeetTest {
    public static void Main(string[] args)
    {   
        int[] input = new int[]{1,2,3};
        var s = new Solution078();
        var res = s.Subsets(input);

        Console.WriteLine(res);   
    }
}