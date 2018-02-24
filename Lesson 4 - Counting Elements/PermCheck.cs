using System;
using System.Collections.Generic;

class Solution {
	public int solution(int[] A) {
		uint
			expected = (uint)((A.Length + ((A.Length + 1) % 2)) * Math.Ceiling(A.Length / 2.0)),
			sum = 0;
		HashSet<int> digits = new HashSet<int>(A);
		if (digits.Count != A.Length)
			return 0;
		for (int i = -1; ++i < A.Length; sum += (uint)A[i])
			;
		return sum == expected ? 1 : 0;
	}
}