using System;

class Solution {
	public int solution(int[] A) {
		int
			l = A.Length + 1,
			expectedSum = (int)Math.Ceiling(l / 2.0) * (l + (l + 1) % 2),
			sum = 0;
		for (int i = -1; ++i < A.Length;)
			sum += A[i];
		return expectedSum - sum;
	}
}