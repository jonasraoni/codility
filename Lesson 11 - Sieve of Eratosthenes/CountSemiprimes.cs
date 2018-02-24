using System;

class Solution {
	public int[] createSieve(int n) {
		var r = new int[n + 1];
		r[0] = 0;
		r[1] = 1;
		var i = 2;
		while (i * i <= n) {
			if (r[i] == 0) {
				var k = i * i;
				while (k <= n) {
					if (r[k] == 0)
						r[k] = i;
					k += i;
				}
			}
			++i;
		}
		return r;
	}
	public int[] solution(int N, int[] P, int[] Q) {
		int [] sieve = createSieve(N), counter = new int[N + 1], r = new int[P.Length];
		int current = 0;

		for (var i = 3; ++i <= N;) {
			if (sieve[i] != 0 && sieve[i / sieve[i]] == 0)
				++current;
			counter[i] = current;
		}
		for (var i = -1; ++i < P.Length;)
			r[i] = counter[Q[i]] - (P[i] > 0 ? counter[P[i] - 1] : 0);
		return r;
	}
}