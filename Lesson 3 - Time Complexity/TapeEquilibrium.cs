using System;

class Solution {
	public int solution(int[] A) {
		int left = A[0], right = A[1];
		for (var i = 1; ++i < A.Length; right += A[i])
			;
		int min = Math.Abs(left - right);

		for (var P = 1; ++P < A.Length;) {
			int sum = Math.Abs((left += A[P - 1]) - (right -= A[P - 1]));
			if (sum < min)
				min = sum;
		}
		return min;
	}
}