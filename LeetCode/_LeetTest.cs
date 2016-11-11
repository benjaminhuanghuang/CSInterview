
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
        var input = "[1,2]";

        var s = new Codec();
        var root = s.deserialize(input);  
        var result = s.serialize(root);
        root = s.deserialize(result);  
        Console.WriteLine(result);
    }
}