using System;

class Solution {
	public int solution(int N) {
		bool started = false;
		int length = 0, max = 0;
		for (uint i = 1; i <= N; i <<= 1) {
			if ((i & N) != 0) {
				if (started) {
					if (length > max)
						max = length;
					length = 0;
				}
				started = true;
			}
			else if (started)
				++length;
		}
		return max;
	}
}