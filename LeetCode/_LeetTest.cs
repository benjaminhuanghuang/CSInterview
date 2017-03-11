
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest
{
    public static void Main(string[] args)
    {
        var begin = "qa";
        var end = "sq";
        var wordList = new List<string> { "si", "go", "se", "cm", "so", "ph", "mt", "db", "mb", "sb", "kr", "ln", "tm", "le", "av", "sm", "ar", "ci", "ca", "br", "ti", "ba", "to", "ra", "fa", "yo", "ow", "sn", "ya", "cr", "po", "fe", "ho", "ma", "re", "or", "rn", "au", "ur", "rh", "sr", "tc", "lt", "lo", "as", "fr", "nb", "yb", "if", "pb", "ge", "th", "pm", "rb", "sh", "co", "ga", "li", "ha", "hz", "no", "bi", "di", "hi", "qa", "pi", "os", "uh", "wm", "an", "me", "mo", "na", "la", "st", "er", "sc", "ne", "mn", "mi", "am", "ex", "pt", "io", "be", "fm", "ta", "tb", "ni", "mr", "pa", "he", "lr", "sq", "ye" };

        var s = new Solution126();
        var res = s.FindLadders(begin, end, wordList);
        foreach (var l in res)
        {
            Console.Write("ladder: ");
            Console.WriteLine(String.Join(" ", l));
        }

    }
}