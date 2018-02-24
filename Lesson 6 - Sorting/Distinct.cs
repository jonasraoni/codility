using System;

class Solution {
	public int solution(int[] A) {
		int count = A.Length > 0 ? 1 : 0;
		if (A.Length > 1) {
			Array.Sort(A);
			int current = A[0];
			for (var i = 0; ++i < A.Length;)
				if (current != A[i]) {
					++count;
					current = A[i];
				}
		}
		return count;
	}
}