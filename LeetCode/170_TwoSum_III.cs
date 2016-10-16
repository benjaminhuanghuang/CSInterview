/*
170. Two Sum III - Data structure design  

Design and implement a TwoSum class. It should support the following operations:add and find.

add - Add the number to an internal data structure.
find - Find if there exists any pair of numbers which sum is equal to the value.

For example,
add(1); add(3); add(5);
find(4) -> true
find(7) -> false
*/

using System.Collections.Generic;

public class TwoSum {
	private Dictionary<int, int> elements = new Dictionary<int, int>();
 
	public void add(int number) {
		if (elements.ContainsKey(number)) {
            elements[number]= elements[number] + 1;
		} else {
			elements.Add(number, 1);
		}
	}
 
	public bool find(int value) {
		foreach (KeyValuePair<int, int> pair in elements) {
			int target = pair.Value - value;
			if (elements.ContainsKey(target)) {
				if (value == target) {
					continue;
				}
				return true;
			}
		}
		return false;
	}
}