using System;

class Solution {
	public int solution(int N) {
		int end = (int)Math.Sqrt(N), min = N + 1, i = 1;
		while (++i <= end) {
			int d = N / i;
			if (d * i == N && min > d + i)
				min = d + i;
		}
		return min * 2;
	}
}