
using System;
using System.IO;


public class LeetTest {
    public static void Main(string[] args)
    {   
        var s = new Solution014();
        string[] input = {"a"};
        var result = s.LongestCommonPrefix(input);
        Console.WriteLine(result);
    }
}