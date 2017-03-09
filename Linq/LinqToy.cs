using System;
using System.Linq;
using System.Collections.Generic;
public class LinqToy
{
    public static void Main(string[] args)
    {
        // print n*n if n % 10 == 0
        var arr = Enumerable.Range(1, 90);
        arr.Where(i => i % 10 == 0).Select(i => i * i).ToList().ForEach(Console.WriteLine);

        // Put valus in dictionary to a list
        var dict = new Dictionary<string, List<string>>();
        //List<string> strList = dict.Select(one => one.Value).Cast<IList<string>>().ToList();
    }

    //var dictionary = num.ToDictionary(i => i, i => false);
    
    private static bool IsOnlyOneCharDifferent(string str1, string str2)
    {
        // all string have same length
        return str1.Where((t, i) => !t.Equals(str2[i])).Count() == 1;
    }
    private void Sort(int[] nums)
    {
        Array.Sort(nums, (i, j) => String.Compare(j.ToString() + i.ToString(), i.ToString() + j.ToString(), StringComparison.Ordinal));
        
        //Array.Sort(intervals, (a, b) => a.start.CompareTo(b.start));
    }

    private void SortSort(){
        //sort the numbers first by height and then by the position. height in descending order and position in ascending order.
        //temp.Sort((x, y) => { int result = y.Item1.CompareTo(x.Item1); return result == 0 ? x.Item2.CompareTo(y.Item2) : result; });
    }
    
    static long TotalAllEvenNumbers(int[] intArray) {
        return intArray.Where(i => i % 2 == 0).Sum(i => (long)i);
    }
}
