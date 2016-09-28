
using System;
using System.IO;


public class LeetTest {
    public static void Main(string[] args)
    {   
        var s = new Solution016();
        int[] input = {0,1,2};
        var result = s.ThreeSumClosest(input, 3);
        Console.WriteLine(result);
    }
}