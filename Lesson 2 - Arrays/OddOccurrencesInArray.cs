using System;
using System.Collections.Generic;

class Solution {
	public int solution(int[] A) {
		var has = new HashSet<int>();
		foreach (var i in A)
			if (has.Contains(i))
				has.Remove(i);
			else
				has.Add(i);
		foreach(var i in has)
			return i;
		return 0;
	}
}