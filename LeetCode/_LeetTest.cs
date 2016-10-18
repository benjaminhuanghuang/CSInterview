
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
        var input = new int[]{2,2,2};
        var s = new Solution400();
        var res = s.FindNthDigit(2147483647);

        Console.WriteLine(res);   
    }
}