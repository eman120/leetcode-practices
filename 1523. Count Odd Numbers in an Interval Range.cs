//1523. Count Odd Numbers in an Interval Range

//Long Way
// 84 / 84 test cases passed.
//Status: Accepted
//Runtime: 3174 ms
//Memory Usage: 26.8 MB

public class Solution {
    public int CountOdds(int low, int high) {
        int count = 0;
        for(int i = low ; i <= high ; i++){
            if (i % 2 == 1){
                count +=1;
            }
        }
        return count;
    }
}

//----------------------------------

//Short way 
//84 / 84 test cases passed.
//Status: Accepted
//Runtime: 25 ms
//Memory Usage: 26.6 MB

public class Solution {
    public int CountOdds(int low, int high) {
        int count = low % 2!=0 || high % 2!=0 ?((high - low)/2) +1 : (high - low)/2;
        return count;
    }
}
