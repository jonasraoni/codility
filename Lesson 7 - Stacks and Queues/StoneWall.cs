using System;
using System.Collections.Generic;

class Solution {
	public int solution(int[] H) {
		int blocks = 1;
		var stack = new Stack<int>();
		stack.Push(H[0]);
		for(var i = 0; ++i < H.Length;) {
			int height = H[i];
			while(stack.Count > 0 && stack.Peek() > height)
				stack.Pop();
			if (stack.Count == 0 || stack.Peek() != height) {
				stack.Push(height);
				++blocks;
			}
		}
		return blocks;
	}
}