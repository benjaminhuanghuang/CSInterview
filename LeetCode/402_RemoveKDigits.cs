/*
402. Remove K Digits
Given a non-negative integer num represented as a string, remove k digits from the number so that the new number is the smallest possible.

Note:
The length of num is less than 10002 and will be ≥ k.
The given num does not contain any leading zero.
Example 1:

Input: num = "1432219", k = 3
Output: "1219"
Explanation: Remove the three digits 4, 3, and 2 to form the new number 1219 which is the smallest.
Example 2:

Input: num = "10200", k = 1
Output: "200"
Explanation: Remove the leading 1 and the number is 200. Note that the output must not contain leading zeroes.
Example 3:

Input: num = "10", k = 2
Output: "0"
Explanation: Remove all the digits from the number and it is left with nothing which is 0.
*/

/*
其基本思想是利用栈尽量维持一个递增的序列，也就是说将字符串中字符依次入栈，如果当前字符串比栈顶元素小，
并且还可以继续删除元素，那么就将栈顶元素删掉，这样可以保证将当前元素加进去一定可以得到一个较小的序列．
也可以算是一个贪心思想．最后我们只取前len-k个元素构成一个序列即可，如果这样得到的是一个空串那就手动返回０．
还有一个需要注意的是字符串首字符不为０
*/

using System.Collections.Generic;

public class Solution402 {
    public string RemoveKdigits(string num, int k) {
        var stack = new Stack<int>();

        if (num.Length == 0 || num.Length <= k)
            return "0";

        for(int i=0; i < num.Length; i++)
        {
            int curr = num[i] - '0';
            while(stack.Count > 0 && curr < stack.Peek() && 
                num.Length - i - 1 >= (num.Length - k) - stack.Count)
                stack.Pop();

            if(stack.Count < num.Length - k)
                stack.Push(curr);
        }
        return "";
    }
}