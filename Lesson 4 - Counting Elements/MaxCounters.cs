using System;

class Solution {
	public int[] solution(int N, int[] A) {
		var counters = new int[N];
		int max = 0, min = 0;
		foreach (var n in A)
			if (n == N + 1)
				min = max;
			else {
				var v = counters[n - 1];
				if((counters[n - 1] = Math.Max(v, min) + 1) > max)
					max = counters[n - 1];
			}
		for (int i = counters.Length; --i >= 0; )
			if(counters[i] < min)
				counters[i] = min;
		return counters;
	}
}