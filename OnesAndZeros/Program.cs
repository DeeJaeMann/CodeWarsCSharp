// Given an array of ones and zeroes, convert the equivalent binary value to an integer.
//
//     Eg: [0, 0, 0, 1] is treated as 0001 which is the binary representation of 1.
//
//     Examples:
//
// Testing: [0, 0, 0, 1] ==> 1
// Testing: [0, 0, 1, 0] ==> 2
// Testing: [0, 1, 0, 1] ==> 5
// Testing: [1, 0, 0, 1] ==> 9
// Testing: [0, 0, 1, 0] ==> 2
// Testing: [0, 1, 1, 0] ==> 6
// Testing: [1, 1, 1, 1] ==> 15
// Testing: [1, 0, 1, 1] ==> 11
// However, the arrays can have varying lengths, not just limited to 4.

var first = new int[] { 0, 0, 0, 0 };
var second = new int[] { 1, 1, 1, 1 };
var third = new int[] { 0, 1, 1, 0 };
var fourth = new int[] { 0, 1, 0, 1 };

Console.WriteLine($"First:{Kata.binaryArrayToNumber(first)}");
Console.WriteLine($"Second:{Kata.binaryArrayToNumber(second)}");
Console.WriteLine($"Third:{Kata.binaryArrayToNumber(third)}");
Console.WriteLine($"Fourth:{Kata.binaryArrayToNumber(fourth)}");

class Kata
{
    public static int binaryArrayToNumber(int[] BinaryArray)
    {
        int result = 0;
        string binParse = String.Empty;

        foreach (int num in BinaryArray)
        {
            binParse += num.ToString();
        }
        result = Convert.ToInt32(binParse, 2);        

        return result;
    }
}