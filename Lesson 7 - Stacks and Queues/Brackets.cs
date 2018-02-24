using System;
using System.Collections.Generic;

class Solution {
	public int solution(string S) {
		const string opening = "({[", closing = ")}]";
		var stack = new Stack<int>();
		int p;
		foreach (var c in S)
			if ((p = opening.IndexOf(c)) != -1)
				stack.Push(p);
			else if (stack.Count == 0 || stack.Pop() != closing.IndexOf(c))
				return 0;
		return stack.Count == 0 ? 1 : 0;
	}
}