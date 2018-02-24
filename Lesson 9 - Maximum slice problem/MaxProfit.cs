using System;

class Solution {
	public int solution(int[] A) {
		int best = 0;
		if (A.Length > 1) {
			int current = 0, start = 0, end = 0;
			for (var i = 0; ++i < A.Length;) {
				var diff = A[i] - A[i - 1];
				if (diff >= 0) {
					if ((current += diff) > best)
						best = current;
					++end;
				}
				else if (current + diff >= 0) {
					current += diff;
					++end;
				}
				else {
					start = end = i;
					current = 0;
				}
			}
		}
		return best;
	}
}