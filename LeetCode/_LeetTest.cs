
using System;
using System.IO;


public class LeetTest {
    public static void Main(string[] args)
    {   
        var s = new Solution404();
        var result = s.SumOfLeftLeaves(new TreeNode(100));
        Console.WriteLine(result);
    }
}