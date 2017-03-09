
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
        var s = new Solution127();
        var begin = "hit";
        var end ="cog";
        var wordList = new List<string> {"hot","dot","dog","lot","log"};
    
        var res= s.LadderLength(begin, end, wordList);
        Console.WriteLine(res);
        // foreach (var l in res)
        // {
        //     Console.WriteLine(String.Join(" ",l));
        // }
    }
}