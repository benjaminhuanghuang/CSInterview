/*
467. Unique Substrings in Wraparound String

Consider the string s to be the infinite wraparound string of "abcdefghijklmnopqrstuvwxyz", 
so s will look like this: "...zabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcd....".

Now we have another string p. Your job is to find out how many unique non-empty substrings of p 
are present in s. In particular, your input is the string p and you need to output the number of 
different non-empty substrings of p in the string s.

Note: p consists of only lowercase English letters and the size of p might be over 10000.

Example 1:
Input: "a"
Output: 1

Explanation: Only the substring "a" of string "a" is in the string s.
Example 2:
Input: "cac"
Output: 2
Explanation: There are two substrings "a", "c" of string "cac" in the string s.
Example 3:
Input: "zab"
Output: 6
Explanation: There are six substrings "z", "a", "b", "za", "ab", "zab" of string "zab" in the 
string s.
 */

/*
    字符串s是小写字母"abcdefghijklmnopqrstuvwxyz"的无限循环
    用字典cmap记录以某字母开始的子串的最大长度
    遍历字符串p，维护区间[start, end]，p[start ... end]是无限循环字符串s的一部分
    更新p[start], p[start + 1], ... p[end]在cmap中的长度值
    最终结果为cmap中value的和
*/
 public class Solution467 {
    public int FindSubstringInWraproundString(string p) {
        string pattern = "abcdefghijklmnopqrstuvwxyz";
        int clen = 0;
        for (int i = 0; i < p.Length; i++)
        {

        }
        int sum =0 ;

        return sum;
    }
}