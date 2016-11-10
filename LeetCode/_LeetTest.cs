
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
       var input = new string[,]{{"JFK","KUL"},{"JFK","NRT"},{"NRT","JFK"}};

        var s = new Solution332();
        var result = s.FindItinerary(input);  

        Console.WriteLine(result);
    }
}