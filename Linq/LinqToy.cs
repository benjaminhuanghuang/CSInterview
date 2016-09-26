using System;
using System.Linq;

public class LinqToy
{
    public static void Main(string[] args)
    {
        // print n*n if n % 10 == 0
        var arr = Enumerable.Range(1, 90);
        arr.Where(i => i % 10 == 0).Select(i => i * i).ToList().ForEach(Console.WriteLine);
    }
}
