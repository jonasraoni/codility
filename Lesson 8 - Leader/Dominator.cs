using System;

class Solution {
	public int solution(int[] A) {
		if (A.Length < 1)
			return -1;
		int size = 0, value = 0;
		for (var i = -1; ++i < A.Length;) {
			if (size == 0) {
				++size;
				value = A[i];
			}
			else if (value != A[i])
				--size;
			else
				++size;
		}
		if (size > 0) {
			int count = 0;
			for (var i = -1; ++i < A.Length;)
				if (A[i] == value && ++count > A.Length / 2)
					return i;
		}
		return -1;
	}
}