
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
        string input = "dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext";
        input = "dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext";
        var s = new Solution388();
        var result = s.LengthLongestPath(input);  

        Console.WriteLine(result);
    }
}