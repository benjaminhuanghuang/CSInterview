
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest
{
    public static void Main(string[] args)
    {
        var s = new Solution393();
        var data = new int[] { 248, 130, 130, 130};
        Console.WriteLine(s.ValidUtf8(data));
    }
}