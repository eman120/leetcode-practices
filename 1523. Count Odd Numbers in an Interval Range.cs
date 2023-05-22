//1523. Count Odd Numbers in an Interval Range

public class Solution {
    public int CountOdds(int low, int high) {
        int count = low % 2!=0 || high % 2!=0 ?((high - low)/2) +1 : (high - low)/2;
        return count;
    }
}
