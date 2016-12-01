
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class MSTest {
    public static void Main(string[] args)
    {       
        var s = new Solution_DeleteWord();
        var result = s.DeleteWord("a big ball is running", 'b');
        Console.WriteLine(result);
    }
}