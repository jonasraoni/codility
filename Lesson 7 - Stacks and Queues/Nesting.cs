using System;

class Solution {
	public int solution(string S) {
		int open = 0;
		foreach (var c in S)
			if ((open += c == '(' ? 1 : -1) < 0)
				break;
		return open == 0 ? 1 : 0;
	}
}