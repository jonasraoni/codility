Given six digits, find the earliest valid time that can be displayed on a digital clock (in 24-hour format) using those digits. 

For example, given digits 1, 8, 3, 2, 6, 4 the earliest valid time is "12:36:48". Note that "12 : 34 : 68" is not a valid time.

Write a method:

class Solution {
     public String solution(int A, int B, int C, int D, int E, int F);
}

That, given six integers A, B, C, D, E and F, returns the earliest valid time in "hh:mm:ss" string format, or "NOT POSSIBLE" if it is not possible to display a valid time using all six integers. 

For example, given 1, 8, 3, 2, 6, 4 the function should return "12:36:48". 

Given 0, 0, 0, 0, 0, 0, the function should return "00:00:00".
Given 0, 0, 0, 7, 8, 9, the function should return "07:08:09".
Given 2, 4, 5, 9, 5, 9, the function should return "NOT POSSIBLE".

Assume that: • A, B, C, D, E and F are integers within the range [0..9].