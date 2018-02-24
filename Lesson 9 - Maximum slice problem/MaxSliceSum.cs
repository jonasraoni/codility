using System;

class Solution {
	public int solution(int[] A) {
		int bestSum = A[0];
		if (A.Length > 1) {
			int sum = A[0];
			int start = 0, end = 0;
			for (var i = 0; ++i < A.Length;) {
				if (A[i] > sum && A[i] > A[i] + sum) {
					if ((sum = A[end = start = i]) > bestSum)
						bestSum = sum;
				}
				else if (A[i] < 0) {
					++end;
					sum += A[i];
				}
				else {
					if ((sum += A[i]) > bestSum)
						bestSum = sum;
					end++;
				}
			}
		}
		return bestSum;
	}
}