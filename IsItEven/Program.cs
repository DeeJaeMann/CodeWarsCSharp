// In this Kata we are passing a number (n) into a function.
//
//     Your code will determine if the number passed is even (or not).
//
// The function needs to return either a true or false.
//
//     Numbers may be positive or negative, integers or floats.
//
//     Floats with decimal part non equal to zero are considered UNeven for this kata.
Number num = new();
Console.WriteLine($"Test: 0 = {num.IsEven(0)}");
Console.WriteLine($"Test: 0.5 = {num.IsEven(0.5)}");
Console.WriteLine($"Test: 1 =  {num.IsEven(1)}");
Console.WriteLine($"Test: 2 =  {num.IsEven(2)}");
Console.WriteLine($"Test: -4 =  {num.IsEven(-4)}");
Console.WriteLine($"Test: 0.6 = {num.IsEven(0.6)}");


public class Number
{
    public bool IsEven(double n)
    {
        bool result = false;
        if (n % 2 == 0)
        {
            result = true;
        }
        return result;
    }
}