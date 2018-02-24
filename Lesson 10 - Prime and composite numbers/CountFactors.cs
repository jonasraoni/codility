using System;

class Solution {
	public int solution(int N) {
		int end = (int)Math.Sqrt(N), count = 0, i = 1;
		while (++i <= end) {
			if (N % i == 0)
				++count;
		}
		return count * 2 + (end * end == N ? 1 : 2);
	}
}