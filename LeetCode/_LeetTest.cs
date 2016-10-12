
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
        var s = new Solution120();
        var res = s.MinimumTotal(new List<IList<int>>(){new List<int>(){1},new List<int>(){2,3}});

        Console.WriteLine(res);   
    }
}