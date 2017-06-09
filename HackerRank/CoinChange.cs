/*
find and print the number of different ways you can make change for  dollars if each coin is 
available in an infinite quantity.

https://www.hackerrank.com/challenges/ctci-coin-change
https://www.youtube.com/watch?v=sn0DWI-JdNA

Recursion  ->  Memoizaton DP
Solve 'Coin Change' Using Memoization and DP
*/
using System.Collections.Generic;

public class CoinChangeSolution
{
    public int MakeChange(int[] coins, int money)
    {
        return MakeChange(coins, money, 0);
    }

    private int MakeChange(int[] coins, int money, int index)
    {
        if (money == 0)
        {
            return 1;
        }
        if (index >= coins.Length)
        {
            return 0;
        }
        int amountWithCoin = 0;
        int ways = 0;
        while (amountWithCoin < money)
        {
            int remaining = money - amountWithCoin;
            ways += MakeChange(coins, remaining, index + 1);
            amountWithCoin += coins[index];
        }
        return ways;
    }
    public int MakeChange_DP(int[] coins, int money)
    {
        return MakeChange_DP(coins, money, 0, new Dictionary<string, int>());
    }

    private int MakeChange_DP(int[] coins, int money, int index, Dictionary<string, int> memo)
    {
        if (money == 0)
        {
            return 1;
        }
        if (index >= coins.Length)
        {
            return 0;
        }
        string key = string.Format("{0}-{1}", money, index);

        if (memo.ContainsKey(key))
        {
            return memo[key];
        }
        int amountWithCoin = 0;
        int ways = 0;
        while (amountWithCoin <= money)
        {
            int remaining = money - amountWithCoin;
            ways += MakeChange_DP(coins, remaining, index + 1, memo);
            amountWithCoin += coins[index];
        }
        memo[key] = ways;
        return ways;
    }
}