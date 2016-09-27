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
    public bool IsMatch(string s, string p) {
        int ps = 0;
        int pp = 0;
        bool matchStar = false;
        while (ps < s.Length && pp < p.Length)
        {
            char cs = s[ps];
            char cp = p[pp];
            if (cs == cp)
            {
                ps++;
                pp++;
                if (matchStar)
                    matchStar = false;
                continue;
            }
            if (cp == '.')
            {
                ps++;
                pp++;
                continue;
            }
            if (cp == '*')
            {
                ps++;
                pp++;
                matchStar = true;
                continue;
            }
            if (cs != cp)
            {
                if (matchStar)
                {
                    ps++;
                    continue;
                }
                return false;
            }
        }
        return (ps == s.Length && pp == p.Length);
    }
}