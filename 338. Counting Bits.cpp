/**
Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.

Example 1:

Input: n = 2
Output: [0,1,1]
Explanation:
0 --> 0
1 --> 1
2 --> 10

Example 2:

Input: n = 5
Output: [0,1,1,2,1,2]
Explanation:
0 --> 0
1 --> 1
2 --> 10
3 --> 11
4 --> 100
5 --> 101
 

Constraints:

0 <= n <= 105
 

Follow up:

It is very easy to come up with a solution with a runtime of O(n log n). Can you do it in linear time O(n) and possibly in a single pass?
Can you do it without using any built-in function (i.e., like __builtin_popcount in C++)?
**/

/**
15 / 15 test cases passed.
Status: Accepted
Runtime: 6 ms
Memory Usage: 7.8 MB
**/

class Solution {
public:
int x;
    vector<int> countBits(int n) {
        vector<int> bits(n+1 , 0);
        for(int i = 1 ; i < n+1 ; i++){
            bits[i] = bits[i>>1] + (i&1);
        }
        return bits;
    }
};

/**

15 / 15 test cases passed.
Status: Accepted
Runtime: 3 ms
Memory Usage: 7.9 MB
**/
class Solution {
public:
    vector<int> countBits(int n) {
        vector<int> bits(n+1 , 0);
        int offset = 1;
        for(int i = 1 ; i < n+1 ; i++){
            if(offset * 2 == i){
                offset = i;
            }
            bits[i] = 1 + bits[i - offset];
        }
        return bits;
    }
};

/**

15 / 15 test cases passed.
Status: Accepted
Runtime: 3 ms
Memory Usage: 7.9 MB
**/
class Solution {
public:
    vector<int> countBits(int n) {
        vector<int> bits(n+1 , 0);
        for(int i = 1 ; i < n+1 ; i++){
            bits[i] = bits[i/2] + i%2;
        }
        return bits;
    }
};
