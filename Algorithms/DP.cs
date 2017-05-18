public class DPDemo
{
    long Fibonacci_Solution1(int n)
    {
        int[] result = { 0, 1 };
        if (n < 2)
            return result[n];

        return Fibonacci_Solution1(n - 1) + Fibonacci_Solution1(n - 2);
    }

    long Fibonacci_Solution2(int n)
    {
        int[] result = { 0, 1 };
        if (n < 2)
            return result[n];

        long fibNMinusTwo = 0;
        long fibNMinusOne = 1;
        long fibN = 0;
        for (int i = 2; i <= n; ++i)
        {
            fibN = fibNMinusOne + fibNMinusTwo;

            fibNMinusTwo = fibNMinusOne;
            fibNMinusOne = fibN;
        }

        return fibN;
    }
}