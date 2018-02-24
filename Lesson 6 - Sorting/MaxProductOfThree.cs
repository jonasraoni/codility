using System;

class Solution {
	public int solution(int[] A) {
		Array.Sort(A);
		int biggest = A[A.Length - 1], front = A[0] * A[1], back = A[A.Length - 2] * A[A.Length - 3];
		return biggest * (biggest >= 0 ? Math.Max(front, back) : Math.Min(front, back));
	}
}