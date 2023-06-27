//Reverse bits of a given 32 bits unsigned integer.

//Example 1:
//Input: n = 00000010100101000001111010011100
//Output:    964176192 (00111001011110000010100101000000)
//Explanation: The input binary string 00000010100101000001111010011100 represents the unsigned integer 43261596, so return 964176192 which its binary representation is 00111001011110000010100101000000.


//Example 2:
//Input: n = 11111111111111111111111111111101
//Output:   3221225471 (10111111111111111111111111111111)
//Explanation: The input binary string 11111111111111111111111111111101 represents the unsigned integer 4294967293, so return 3221225471 which its binary representation is 10111111111111111111111111111111.

//Constraints:
//The input must be a binary string of length 32

////----------------------------------------------------

//The Solution: O(1)
//Set the result to zero, then loop from 0 to 31. 
//Inside that loop grab that bit at the loops index. 
//To do this shift the original number to the right i bits then AND it with 1 to determine the bit. 
//Now with that bit, set the result to the OR of itself and the bit shifted back to its original position. 
//After this loop return the result.

public class Solution {
    public uint reverseBits(uint n) {
        uint result = 0;
        for (int i = 0 ; i < 32 ; i++){
            uint bit = (n >> i) & 1;
            result = result | (bit << (31 - i));
        }
   
        return result;
    }
}
