public class DPDemo
{
    long Fibonacci_Solution1(unsigned int n)
    {
        int result[2] = { 0, 1 };
        if (n < 2)
            return result[n];

        return Fibonacci_Solution1(n - 1) + Fibonacci_Solution1(n - 2);
    }

    long Fibonacci_Solution2(unsigned n)
    {
        int result[2] = { 0, 1 };
        if (n < 2)
            return result[n];

        long long fibNMinusTwo = 0;
        long long fibNMinusOne = 1;
        long long fibN = 0;
        for (unsigned int i = 2; i <= n; ++i)
        {
            fibN = fibNMinusOne + fibNMinusTwo;

            fibNMinusTwo = fibNMinusOne;
            fibNMinusOne = fibN;
        }

        return fibN;
    }
}