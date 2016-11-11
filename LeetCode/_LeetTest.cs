
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
        var nums1 = new int[]{6,7};
        var nums2 = new int[]{6,4,0};


        var s = new Solution321();
        var result = s.MaxNumber(nums1, nums2, 5);  
 
        Console.WriteLine(result);
    }
}