using System;

class Solution {
	public int solution(int X, int[] A) {
		bool[] has = new bool[X];
		int count = 0;
		for (var i = -1; ++i < A.Length;) {
			if (!has[A[i] - 1]) {
				has[A[i] - 1] = true;
				if (++count == X)
					return i;
			}
		}
		return -1;
	}
}