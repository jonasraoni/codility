There are N giraffes in your zoo. The zoo is famous for the distinct heights of its giraffes. This means that there are no two giraffes of equal height in the zoo.

The giraffes live in displays located along the main path. Every giraffe has its own display. For aesthetic reasons, you want the giraffes to be arranged in ascending order of height. Reordering all the giraffes at once, however, would cause the animals a lot of stress, so you want to split the displays into as many smaller groups as possible and reorder all the groups separately. A group should contain one or more consecutive displays. After reordering all the groups, the giraffes should be arranged in ascending order of height.

Write a function:

function solution(A);

that, given a zero-indexed array A containing N integers, where A[I] denotes the height of the giraffe in the I-th display, returns the maximum number of groups that can be reordered independently in order to sort all the giraffes in ascending order of height.

For example, given A = [1, 5, 4, 9, 8, 7, 12, 13, 14], the function should return 6. Displays can be split into six groups: [1], [5, 4], [9, 8, 7], [12], [13] and [14]. Then, after reordering each group, the whole sequence of giraffes will be sorted into ascending order. Note that group [12, 13, 14] was already ordered correctly, so it could be split into three groups, each containing one giraffe.

Given A = [4, 3, 2, 6, 1], the function should return 1. Displays cannot be split into smaller groups; the giraffes have to be sorted all at once.
Assume that:
   
N is an integer within the range [1..100,000]; 

Each element of array A is an integer within the range [1..1,000,000,000];

The elements of A are all distinct.

Complexity:

Expected worst-case time complexity is O(N*log(N));

Expected worst-case space complexity is O(N), beyond input storage (not counting the storage required for input arguments).