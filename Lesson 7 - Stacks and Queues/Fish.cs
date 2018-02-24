using System;
using System.Collections.Generic;

class Solution {
	public int solution(int[] A, int[] B) {
		int deaths = 0;
		var stack = new Stack<int>();
		for (var i = -1; ++i < A.Length;) {
			if (B[i] == 1) {
				stack.Push(i);
				continue;
			}
			while (stack.Count > 0) {
				++deaths;
				if (A[i] > A[stack.Peek()])
					stack.Pop();
				else
					break;
			}
		}
		return A.Length - deaths;
	}
}