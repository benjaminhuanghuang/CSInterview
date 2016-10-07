/*
91. Decode Ways

A message containing letters from A-Z is being encoded to numbers using the following mapping:

'A' -> 1
'B' -> 2
...
'Z' -> 26
Given an encoded message containing digits, determine the total number of ways to decode it.

For example,
Given encoded message "12", it could be decoded as "AB" (1 2) or "L" (12).

The number of ways decoding "12" is 2.

*/

public class Solution091 {
    //dp[i] = how many ways it can decoded from 0 to i. 
    //so if s[i] is 1 to 9,  then dp[i] can be decoded the same number of way dp[i – 1] has; 
    // if string at i – 1 and i is between 10 to 26, then dp[i] can be decoded the same number of way dp[i – 2] has.
    // if s[i] = 0, dp[i] = dp[i-2]
    // if s[i] !=0, dp[i] = dp[i-1]
    // if 10 < int(s[i - 2] + s[i - 1])<=26, dp[i] = dp[i-1] + dp[i-2]
    public int NumDecodings(string s) {
        if (string.IsNullOrEmpty(s) || s[0]=='0')
        {
            return 0;
        }
        var dp = new int[s.Length + 1];
        dp[0] = 1;
        dp[1] = 1;
        // 
        for (int i = 2; i < s.Length + 1; i++)
        {                 
            if (10 < int.Parse(s.Substring(i - 2, 2)) && int.Parse(s.Substring(i - 2, 2))<= 26 && s[i-1] != '0')
                dp[i] = dp[i -1] + dp[i-2];
            else if(10 == int.Parse(s.Substring(i - 2, 2)) || 20 == int.Parse(s.Substring(i - 2, 2)))
                dp[i] = dp[i-2];
            else if(s[i-1] != '0')
                dp[i] = dp[i-1];
            else
                return 0;
        }

        return dp[s.Length];
    }
}