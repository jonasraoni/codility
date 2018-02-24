using System;

class Solution {
	public int solution(int[] A) {
		int
			start = 0,
			end = 1,
			bestStart = start,
			bestEnd = end, //not needed at all...
			sum = A[start] + A[end];
		double
			bestValue = sum / 2.0,
			tmp,
			tmp2;

		for (var i = 1; ++i < A.Length;) {
			if ((tmp = (double)(sum += A[i]) / (i - start + 1)) < bestValue) {
				bestValue = tmp;
				bestEnd = end = i;
				bestStart = start;
			}
			if ((tmp2 = (A[i - 1] + A[i]) / 2.0) < bestValue) {
				bestStart = start = (bestEnd = end = i) - 1;
				sum = A[i - 1] + A[i];
				bestValue = tmp2;
			}
			else if (tmp2 < tmp)
				sum = A[start = i - 1] + A[i];
		}
		return bestStart;
	}
}