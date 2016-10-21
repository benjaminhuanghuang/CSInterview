/*
13. Roman to Integer

Given a roman numeral, convert it to an integer.

Input is guaranteed to be within the range from 1 to 3999.
*/
using System.Collections.Generic;

public class Solution013 {
    //https://miafish.wordpress.com/2015/02/17/leetcode-oj-c-roman-to-integer/
    Dictionary<char, int> dict3 = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},                
        {'M', 1000}
    };

    public int RomanToInt(string s) {
        var res = 0;
        var pre = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            var cur = dict3[s[i]];
            res += pre > cur ? -cur : cur;
            pre = cur;
        }

        return res;
    }
}
