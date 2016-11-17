/*
456. 132 Pattern

Given a sequence of n integers a1, a2, ..., an, a 132 pattern is a subsequence ai, aj, ak such that 
i < j < k and ai < ak < aj. Design an algorithm that takes a list of n numbers as input and checks 
whether there is a 132 pattern in the list.

Note: n will be less than 15,000.

Example 1:
    Input: [1, 2, 3, 4]
    Output: False
    Explanation: There is no 132 pattern in the sequence.

Example 2:
    Input: [3, 1, 4, 2]
    Output: True
    Explanation: There is a 132 pattern in the sequence: [1, 4, 2].

Example 3:
    Input: [-1, 3, 2, 0]    
    Output: True

Explanation: There are three 132 patterns in the sequence: [-1, 3, 2], [-1, 3, 0] and [-1, 2, 0].
*/

/*
https://discuss.leetcode.com/topic/68193/java-o-n-solution-using-stack-in-detail-explanation

*/

using System.Collections.Generic;

public class Solution456 {

    public class Pair{
        public int Min {get; set;}
        public int Max {get; set;}
    }
    public bool Find132pattern(int[] nums) {
        Stack<Pair> stack = new Stack<Pair>();
        foreach (int n in nums){
            if(stack.Count == 0 || n <stack.Peek().Min ) 
            {
                stack.Push(new Pair(){Min = n, Max = n});
            }
            else if(n > stack.Peek().Min)
            { 
                Pair last = stack.Pop();
                if(n < last.Max) 
                    return true;
                else 
                {
                    last.Max = n;
                    while(stack.Count > 0 && n >= stack.Peek().Max) 
                        stack.Pop();
                    // At this time, n < stack.peek().max (if stack not empty)
                    if(stack.Count > 0 && stack.Peek().Min < n) 
                        return true;
                    stack.Push(last);
                }
            }
        }
        return false;
    }

    //  public boolean find132pattern_Naive(int[] nums) {
    //     if(nums.Length<3) return false;
    //     Integer low = null, high = null;
    //     int start = 0, end = 0;
    //     while(start<nums.length-1){
    //         while(start<nums.length-1 && nums[start]>=nums[start+1]) start++;
    //         // start is lowest now
    //         int m = start+1;
    //         while(m<nums.length-1 && nums[m]<=nums[m+1]) m++;
    //         // m is highest now
    //         int j = m+1;
    //         while(j<nums.length){
    //             if(nums[j]>nums[start] && nums[j]<nums[m]) return true;
    //             j++;
    //         }
    //         start = m+1;
    //     }
    //     return false;
    // }
}