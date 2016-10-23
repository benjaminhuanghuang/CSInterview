/*
326. Power of Three

Given an integer, write a function to determine if it is a power of three.

Follow up:
Could you do it without using any loop / recursion?

*/
using System;
public class Solution326 {
    public bool IsPowerOfThree(int n) {
        return n <= 0 ? false : n == Math.Pow(3, Math.Round(Math.Log(n) / Math.Log(3)));
    }
}