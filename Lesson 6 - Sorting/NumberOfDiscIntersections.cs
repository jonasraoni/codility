using System;
using System.Collections;

class Solution {
	public class Comparer : IComparer {
		public int Compare(object x, object y) {
			Circle a = (Circle)x, b = (Circle)y;
			return a.left.CompareTo(b.left) == 0 ? a.position.CompareTo(b.position) : a.left.CompareTo(b.left);
		}
	}

	class Circle {
		public long radius;
		public long position;
		public long left {
			get {
				return position - radius;
			}
		}
		public long right {
			get {
				return position + radius;
			}
		}
	}

	public int solution(int[] A) {
		int count = 0;
		var circles = new Circle[A.Length];
		for (var i = -1; ++i < A.Length;) {
			circles[i] = new Circle {
				radius = A[i],
				position = i
			};
		}
		var list = new List<Circle>();
		Array.Sort(circles, new Comparer());
		for (var i = -1; ++i < circles.Length;) {
			for (var j = list.Count; --j >= 0;) {
				if (list[j].right < circles[i].left)
					list.RemoveAt(j);
			}
			if ((count += list.Count) > 1e7)
				return -1;
			list.Add(circles[i]);
		}
		return count;
	}
}