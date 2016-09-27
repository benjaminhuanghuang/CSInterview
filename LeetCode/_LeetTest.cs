
using System;
using System.IO;


public class LeetTest {
    public static void Main(string[] args)
    {   
        var s = new Solution008();
        var result = s.MyAtoi("2147483648");
        Console.WriteLine(result);
    }
}