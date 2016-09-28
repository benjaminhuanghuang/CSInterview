
using System;
using System.IO;


public class LeetTest {
    public static void Main(string[] args)
    {   
        var s = new Solution022();
        var res = s.GenerateParenthesis2(50);     
        foreach (var i in res){
            Console.WriteLine(i);
        }
    }
}