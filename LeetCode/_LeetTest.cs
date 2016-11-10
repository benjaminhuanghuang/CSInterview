
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
        var input = new int[,]{  {1,1,3,3},
  {3,1,4,2},
  {3,2,4,4},
  {1,3,2,4},
  {2,3,3,4}};

            var s = new Solution391();
            var result = s.IsRectangleCover(input);  

            Console.WriteLine(result);
    }
}