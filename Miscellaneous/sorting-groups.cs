/*
A list of unique numbers is given with the intention of being sorted, the objective is to separate them into sorting groups in a way that fewer movements will be required. Then just retrieve the amount of groups.
E.g.
1, 2, 3 is already sorted and should be divided in 3 groups: 1 | 2 | 3
2, 1, 3 should be divided in 2 groups: 2, 1 | 3
2, 1, 3, 4 should be divided in 3 groups: 2, 1 | 3 | 4
2, 3, 4, 1 should be divided in 1 group because "1" will need to go to the beginning
*/

using System;
using System.Collections.Generic;

class Solution {
	class Group {
		public int minimum, maximum;
	}
	public int solution(int[] A) {
		var groups = new Stack<Group>();
		var current = new Group { maximum = A[0], minimum = A[0] };
		for (var i = 0; ++i < A.Length;) {
			if (A[i] > current.maximum) {
				groups.Push(current);
				current = new Group { minimum = A[i], maximum = A[i] };
			}
			else if (A[i] < current.minimum) {
				current.minimum = Math.Min(current.minimum, A[i]);
				while (groups.Count > 0 && A[i] < groups.Peek().minimum) {
					var g = groups.Pop();
					current.minimum = Math.Min(g.minimum, current.minimum);
					current.maximum = Math.Max(g.maximum, current.maximum);
				}
			}
		}
		groups.Push(current);
		return groups.Count;
	}
}