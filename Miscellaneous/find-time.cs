/*
A list of 6 numbers is sent, then it's needed to check what's the best way to reorder them to form the smallest possible and valid time in the format hh:mm:ss, otherwise return an error message.
As there was no performance requirement, permuting was the best idea I could come up with...
*/

using System;

class Solution {
	public void swap(ref int a, ref int b) {
		int temp = a;
		a = b;
		b = temp;
	}
	public int? permute(int[] list, int start, int end, int? minimum) {
		int i;
		if (start == end) {
			if (int.Parse(list[0].ToString() + list[1]) < 24
				&& int.Parse(list[2].ToString() + list[3]) < 60
				&& int.Parse(list[4].ToString() + list[5]) < 60
			) {
				int value = int.Parse(string.Join("", list));
				if (!minimum.HasValue || minimum.Value > value)
					minimum = value;
			}
			return minimum;
		}
		else
			for (i = start; i <= end; i++) {
				swap(ref list[start], ref list[i]);
				minimum = permute(list, start + 1, end, minimum);
				swap(ref list[start], ref list[i]);
			}
		return minimum;
	}

	public string solution(int A, int B, int C, int D, int E, int F) {
		var r = permute(new[] { A, B, C, D, E, F }, 0, 5, null);
		return r.HasValue ? System.Text.RegularExpressions.Regex.Replace(r.Value.ToString().PadLeft(6, '0'), "^(.{2})(.{2})", "$1:$2:") : "NOT POSSIBLE";
	} 
}