using System;
using System.Linq;

public class LinqToy
{
    public static void Main(string[] args)
    {
        // print n*n if n % 10 == 0
        var arr = Enumerable.Range(1, 90);
        arr.Where(i => i % 10 == 0).Select(i => i * i).ToList().ForEach(Console.WriteLine);

        // Put valus in dictionary to a list
        var dict = new Dictionary<string, List<string>>();
        List<string> strList = dict.Select(one => one.Value).Cast<IList<string>>().ToList();
    }
}
