/*
139. Word Break

Given a string s and a dictionary of words dict, determine if s can be segmented into a space-separated 
sequence of one or more dictionary words.

For example, given
s = "leetcode",
dict = ["leet", "code"].

Return true because "leetcode" can be segmented as "leet code".

*/
using System.Collections.Generic;

public class Solution139 {
    // Use dp[i] as the sub string s[0:i] can be segmented into a space-separated sequence of one or more dictionary words. 
    // put dp[0] as empty string and it is true. 
    // dp[k] =  dp[0] + string(0 – k) in dict; dp[1] + string(1 – k) in dict
    public bool WordBreak(string s, ISet<string> wordDict) {
        if (wordDict == null || s == null)
        {
            return false;
        }

        var count = s.Length;
        var dp = new bool[count + 1];

        dp[0] = true;

        for (var i = 1; i < dp.Length; i++)
        {
            for (var j = 0; j < i; j++)
            {
                var word = s.Substring(j, i - j);
                if (wordDict.Contains(word) && dp[j])
                {
                    dp[i] = true;
                    //break;
                }
            }
        }

        return dp[count];
    }
}

