using System;

class Solution {
	public int[] solution(int[] A, int K) {
		var r = new int[A.Length];
		if(r.Length > 0)
			for (int i = -1, j = A.Length - (K % A.Length); ++i < A.Length;)
				r[i] = A[(j + i) % A.Length];
		return r;
	}
}