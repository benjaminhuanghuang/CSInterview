
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
            var s = new Solution301();
        var result = s.RemoveInvalidParentheses("()())()"); 

        Console.WriteLine(result);
    }
}