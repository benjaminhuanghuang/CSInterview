/*
76. Minimum Window Substring
Given a string S and a string T, find the minimum window in S which will contain all the 
characters in T in complexity O(n).

For example,
S = "ADOBECODEBANC"
T = "ABC"
Minimum window is "BANC".

Note:
If there is no such window in S that covers all characters in T, return the empty string "".

If there are multiple such windows, you are guaranteed that there will always be only one 
unique minimum window in S.
*/

using System.Collections.Generic;

public class Solution076 {
    // 双指针思想，尾指针不断往后扫，当扫到有一个窗口包含了所有T的字符，然后再收缩头指针，直到不能再收缩为止。最后记录所有可能的情况中窗口最小的。
    public string MinWindow(string s, string t) {
        var dict = new Dictionary<char, int>();
        for (int i = 0; i < t.Length; i++)
        {
            if (dict.ContainsKey(t[i]))
            {
                dict[t[i]]++;
            }
            else
            {
                dict.Add(t[i], 1);
            }
        }

        var res = string.Empty;
        var len = s.Length + 1;
        var start = 0;
        var count = t.Length;
        for (int i = 0; i < s.Length; i++)             
        {                 
            if (dict.ContainsKey(s[i]))                 
            {                     
                if (dict[s[i]]-- > 0) // if s[i] is char in t string
                {
                    count--;
                }
            }
            // When count == 0, substring S[start : i] contains string T     
            while (count == 0)
            {
                if (len > i - start + 1)
                {
                    len = i - start + 1;
                    res = s.Substring(start, len);
                }

                if (dict.ContainsKey(s[start]))
                {
                    if (dict[s[start]]++ >= 0)   //  remove char from the sub string
                    {
                        count++;
                    }
                }
                start++;
            }
        }

        return res;
    }
}


// string S = "ADOBECODEBANC";
// string T = "ABB";

// var s = new Solution076();
// var res = s.MinWindow(S, T);

// Console.WriteLine(res);