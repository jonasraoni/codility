using System;
using System.Collections.Generic;

class Solution {
	public int solution(int[] A) {
		int min = 1;
		HashSet<int> numbers = new HashSet<int>();
		foreach (int n in A) {
			if (!numbers.Contains(n)) {
				numbers.Add(n);
				if (n == min)
					while (numbers.Contains(++min));
			}
		}
		return min;
	}
}