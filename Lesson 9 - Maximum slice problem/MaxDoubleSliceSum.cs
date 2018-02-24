using System;

class Solution {
	public int solution(int[] A) {
		int
			sum = A[0] + A[1] + A[2], bestSum = sum,
			start = 0, bestStart = start,
			end = 2, bestEnd = end;
		for (var i = end; ++i < A.Length;) {
			if (A[start] < 0 && A[i] > A[start]) {
				sum += A[i] - A[start];
				++start;
				++end;
				if (sum > bestSum) {
					bestSum = sum;
					bestStart = start;
					bestEnd = end;
				}
			}
			else if (A[i] >= 0) {
				++end;
				if ((sum += A[i]) > bestSum) {
					bestSum = sum;
					bestStart = start;
					bestEnd = end;
				}
			}
			else {
				sum += A[i];
				++end;
			}
		}
		if (A[bestStart] > 0) {
			if (bestStart > 0) {
				bestSum += A[--bestStart];
			}
			else
				while (A[bestStart + 1] < 0 && bestEnd - bestStart > 2)
					bestSum -= A[bestStart++];
		}

		if (A[bestEnd] > 0) {
			if (bestEnd < A.Length - 1) {
				bestSum += A[++bestEnd];
			}
			else {
				while (A[bestEnd - 1] < 0 && bestEnd - bestStart > 2)
					bestSum -= A[bestEnd--];
			}
		}

		int smallest = bestStart + 1;
		for (var i = smallest; ++i < bestEnd;)
			if (A[smallest] > A[i])
				smallest = i;

		if (A[smallest] > 0) {
			if (bestStart > 0) {
				smallest = bestStart;
				bestSum += A[--bestStart];
			}
			else if (bestEnd < A.Length - 1) {
				smallest = bestEnd;
				bestSum += A[++bestEnd];
			}
		}
		return bestSum - A[bestStart] - A[bestEnd] - A[smallest];
	}
}