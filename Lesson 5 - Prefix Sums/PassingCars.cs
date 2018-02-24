using System;

class Solution {
	public int solution(int[] A) {
		int pairs = 0, east = 0;
		if(A.Length > 1)
			foreach (var i in A) {
				if (i == 0)
					++east;
				else if(east > 0 && (pairs += east) > 1e9)
					return -1;
			}
		return pairs;
	}
}