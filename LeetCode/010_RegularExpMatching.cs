/*
10. Regular Expression Matching

Implement regular expression matching with support for '.' and '*'.

'.' Matches any single character.
'*' Matches zero or more of the preceding element.

The matching should cover the entire input string (not partial).

The function prototype should be:
bool isMatch(const char *s, const char *p)

Some examples:
isMatch("aa","a") → false
isMatch("aa","aa") → true
isMatch("aaa","aa") → false
isMatch("aa", "a*") → true
isMatch("aa", ".*") → true
isMatch("ab", ".*") → true
isMatch("aab", "c*a*b") → true

*/


public class Solution010 {
    // dp[i][j] : s[0:i-1] matches p[0:j-1]
    // https://miafish.wordpress.com/2015/01/24/leetcode-oj-c-regular-expression-matching/
    // if we know all previous i, j matches or not, can we judge i, j match or not. 
    // if p[j-1] != '.' and p[j-1] != '*'
    //      dp[i][j] = dp[i-1][j-1] && (s[i-1] == p[j-1])
    // if p[j-1] == '.':
    //      dp[i][j] = dp[i-1][j-1]
    // if p[j-1] == '*'
    //      match 0 chart,  dp[i][j] = dp[i][j-2]
    public bool IsMatch(string s, string pattern) 
    {
        var dp = new bool[s.Length + 1, pattern.Length + 1];
        dp[0, 0] = true;
        for (int i = 1; i < pattern.Length; i++)
        {
            if (p[i] == '*') 
                dp[0, i + 1] = dp[0, i - 1];
            else 
                dp[0, i + 1] = false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < pattern.Length; j++)
            {
                if (s[i] == p[j] || pattern[j] == '.')
                {
                    dp[i + 1, j + 1] = dp[i, j];
                }
                else if(p[j] == '*')
                {
                    dp[i + 1, j + 1] = dp[i + 1, j - 1] || 
                        (dp[i, j + 1] && (s[i] == pattern[j - 1] || p[j - 1] == '.'));
                }
            }
        }

        return dp[s.Length, p.Length];
    }
    // http://bangbingsyb.blogspot.com/2014/11/leetcode-regular-expression-matching.html
    // if p[j-1] != '.' and p[j-1] != '*'
    //      dp[i][j] = dp[i-1][j-1] && (s[i-1] == p[j-1])
    // if p[j-1] == '.':
    //      dp[i][j] = dp[i-1][j-1]
    // if p[j-1] == '*'
    //      match 0 chart,  dp[i][j] = dp[i][j-2]
    //      match 1 chart
    //      match n chart, dp[i][j] = dp[i-1][j] && (p[j-2]=='.' || s[i-2]==p[j-2])
    public bool IsMatch_1(string s, string p) 
    {
        var dp = new bool[s.Length + 1, p.Length + 1];
        dp[0, 0] = true;

        // For case "aab", "c*a*b" or "", "c*c*"
        for (int i = 1; i < p.Length + 1; i++)
        {
            if (p[i - 1] == '*' && i >= 2) 
            {
                dp[0, i] = dp[0, i-2];
            }
        }

        for (int i = 1; i < s.Length + 1; i++)
        {
            for (int j = 1; j < p.Length + 1; j++)
            {
                if (p[j-1] == '.')
                {
                    dp[i, j] = dp[i-1, j-1];
                }
                else if(p[j-1] == '*')
                {
                    dp[i, j] = dp[i, j - 1] || dp[i, j - 2] || 
                             (dp[i-1, j] && (s[i-1] == p[j - 2] || p[j - 2] == '.'));
                }
                else{
                    dp[i, j] = dp[i-1, j-1] && (s[i-1] == p[j-1]);
                }
            }
        }

        return dp[s.Length, p.Length];
    }

    // https://miafish.wordpress.com/2015/01/24/leetcode-oj-c-regular-expression-matching/
    public bool isMatch_2(string s, string p)
    {
        if (p == null && s == null)
        {
            return true;
        }
        if (p == null || s == null)
        {
            return false;
        }
        return this.isMatchRecursion(s, 0, p, 0);
    }

    public bool isMatchRecursion(string s, int indexOfs, string p, int indexofp)
    {
        if (indexOfs >= s.Length)
        {
            while (indexofp + 1 < p.Length && p[indexofp + 1].Equals('*'))                 
            {                     
                indexofp += 2;                 
            }             
        }             
        if (indexOfs >= s.Length && indexofp >= p.Length)
        {
            return true;
        }
        if (indexOfs >= s.Length || indexofp >= p.Length)
        {
            return false;
        }

        var next = indexofp + 1 >= p.Length ? ' ' : p[indexofp + 1];

        if (next.Equals('*'))
        {
            if (s[indexOfs].Equals(p[indexofp]) || p[indexofp].Equals('.'))
            {
                // a* matches more than 0 of a in s
                return this.isMatchRecursion(s, indexOfs + 1, p, indexofp) 
                    // a* matches 0 of a in s
                    || this.isMatchRecursion(s, indexOfs, p, indexofp + 2);
            }
            
            return this.isMatchRecursion(s, indexOfs, p, indexofp + 2);
        }

        if (s[indexOfs].Equals(p[indexofp]) || p[indexofp].Equals('.'))
        {
            return this.isMatchRecursion(s, indexOfs + 1, p, indexofp + 1);
        }

        return false;
    }
}