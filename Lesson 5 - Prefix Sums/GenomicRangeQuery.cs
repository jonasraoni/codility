using System;
using System.Collections.Generic;

class Solution {
	class LinkedValue {
		public int value;
		public int? nextMinimum;
	}

	public int[] solution(string S, int[] P, int[] Q) {
		var impactMap = new Dictionary<char, int> {
			{ 'A', 1 },
			{ 'C', 2 },
			{ 'G', 3 },
			{ 'T', 4 },
		};
		var impact = new LinkedValue[S.Length];
		var stack = new Stack<LinkedValue>();
		for (var i = -1; ++i < S.Length;) {
			impact[i] = new LinkedValue {
				value = impactMap[S[i]],
				nextMinimum = null
			};
			while (stack.Count > 0 && impact[i].value < stack.Peek().value)
				stack.Pop().nextMinimum = i;
			if(impact[i].value > 1)
				stack.Push(impact[i]);
		}
		var r = new int[P.Length];
		for(var i = -1; ++i < P.Length;) {
			var current = impact[P[i]];
			if (current.value > 1)
				while ((current.nextMinimum ?? Q[i] + 1) <= Q[i])
					current = impact[current.nextMinimum.Value];
			r[i] = current.value;
		}
		return r;
	}
}