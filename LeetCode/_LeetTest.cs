
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest
{
    public static void Main(string[] args)
    {
        var s = new Solution399();
        var equations = new string[,]{{"a", "b"}, {"b", "c"}};
        var values = new double[]{2.0, 3.0};
        var queries = new string[,]{{"a", "c"}, {"b", "a"}, {"a", "e"}, {"a", "a"}, {"x", "x"}};

        var res = s.CalcEquation(equations, values, queries);
        foreach (var item in res)
        {
            Console.WriteLine(item);
        }
    }
}