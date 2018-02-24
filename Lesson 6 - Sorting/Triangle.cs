using System;

class Solution {
	public int solution(int[] A) {
		long p, q, r;
		if (A.Length > 2) {
			Array.Sort(A);
			for (var i = -1; ++i < A.Length - 2;) {
				p = A[i];
				q = A[i + 1];
				r = A[i + 2];
				if (p + q > r && q + r > p && r + p > q)
					return 1;
			}
		}
		return 0;
	}
}