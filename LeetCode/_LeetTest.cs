
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest
{
    public static void Main(string[] args)
    {
        var s = new Solution126();
        // var begin = "hit";
        // var end = "cog";
        // var wordList = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };

        var begin = "hot";
        var end = "dog";
        var wordList = new List<string> { "hot", "dog"};

        var res = s.FindLadders(begin, end, wordList);
        foreach (var l in res)
        {
            Console.Write("ladder: ");
            Console.WriteLine(String.Join(" ", l));
        }
    }
}