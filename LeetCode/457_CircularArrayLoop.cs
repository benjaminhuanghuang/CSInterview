/*
457. Circular Array Loop

You are given an array of positive and negative integers. If a number n at an index is 
positive, then move forward n steps. Conversely, if it's negative (-n), move backward 
n steps. Assume the first element of the array is forward next to the last element, and 
the last element is backward next to the first element. Determine if there is a loop in 
this array. A loop starts and ends at a particular index with more than 1 element along 
the loop. The loop must be "forward" or "backward'.

Example 1: Given the array [2, -1, 1, 2, 2], there is a loop, from index 0 -> 2 -> 3 -> 0.

Example 2: Given the array [-1, 2], there is no loop.

Example 3: Given the array [2, 0, 2, 1, 3], return false since 0 is not supposed to 
appear in the array.

Can you do it in O(n) time complexity and O(1) space complexity?
*/

public class Solution457 {
    //http://blog.csdn.net/junchen1992/article/details/53142125
    public bool CircularArrayLoop(int[] nums) {
        return false;
    }
}