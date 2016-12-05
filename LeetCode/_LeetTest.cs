
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
        var nums = new int[] {3, 5, 2, 1, 6, 4};
        var s = new Solution324();
        s.WiggleSort2(nums);
        foreach (var i in nums)
        {
            Console.WriteLine(i);
        }
    }
}