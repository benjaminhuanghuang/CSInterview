/*
307. Range Sum Query - Mutable

# 303. Range Sum Query - Immutable

Given an integer array nums, find the sum of the elements between indices i and j (i ≤ j), inclusive.

The update(i, val) function modifies nums by updating the element at index i to val.
Example:
Given nums = [1, 3, 5]

sumRange(0, 2) -> 9
update(1, 2)
sumRange(0, 2) -> 8
Note:
The array is only modifiable by the update function.
You may assume the number of calls to update and sumRange function is distributed evenly.

*/
//http://www.cnblogs.com/grandyang/p/4985506.html

public class NumArrayMutalbe {
    private int[] nums;
    public NumArrayMutalbe(int[] nums) {
        this.nums = nums;
    }

    public void Update(int i, int val) {
        
    }

    public int SumRange(int i, int j) {
        return 0;
    }
}


// Your NumArray object will be instantiated and called as such:
// NumArray numArray = new NumArray(nums);
// numArray.SumRange(0, 1);
// numArray.Update(1, 10);
// numArray.SumRange(1, 2);