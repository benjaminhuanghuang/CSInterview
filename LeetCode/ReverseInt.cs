/*
7. Reverse Integer

Reverse digits of an integer.

Example1: x = 123, return 321
Example2: x = -123, return -321

*/

public class Solution007 {
    public int Reverse(int x) {
        bool positive = x > 0;
        if (!positive)
        {
            x = -x;
        }
        int result = x % 10;
        x = x /10;
        while (x > 0)
        {
            if (result > Int32.MaxValue)
                break;
            int digit = x % 10;

            result = digit * 10 + result;
            x = x /10;
        }
        if (!positive)
        {
            result = -result;
        }
        return result;
    }
}