using System;

class Solution {
	public int solution(int[] A) {
		int leader = -1;
		switch (A.Length) {
			case 0:
				break;
			case 1:
				leader = A[0];
				break;
			case 2:
				if(A[0] == A[1])
					leader = A[0];
				break;
			default:
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
						if (A[i] == value && ++count > A.Length >> 1) {
							leader = A[i];
							break;
						}
				}
				break;
		}
		int equiLeaders = 0;
		if (leader != -1) {
			var counter = new int[A.Length];
			var current = 0;
			for (var i = -1; ++i < A.Length; counter[i] = A[i] == leader ? ++current : current)
				;
			for (var i = 0; ++i < A.Length;)
				if (counter[i - 1] > i >> 1 && counter[A.Length - 1] - counter[i - 1] > A.Length - i >> 1)
					++equiLeaders;
		}
		return equiLeaders;
	}
}