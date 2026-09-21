// Story
//     Ben has a very simple idea to make some profit: he buys something and sells it again. Of course, this wouldn't give 
//     him any profit at all if he was simply to buy and sell it at the same price. Instead, he's going to buy it for the 
//     lowest possible price and sell it at the highest.
//
//     Task
//     Write a function that returns both the minimum and maximum number of the given list/array.
//
//         Examples (Input --> Output)
//         [1,2,3,4,5] --> [1,5]
//     [2334454,5] --> [5,2334454]
//     [1]         --> [1,1]
// Remarks
//     All arrays or lists will always have at least one element, so you don't need to check the length. Also, your 
//     function will always get an array or a list, you don't have to check for null, undefined or similar.

using System;

var first = MinMax.minMax(new int[] { 1, 2, 5, -1, 12, 20 });
var second = MinMax.minMax(new int[] { 1, 2, 3, 4, 5});
var third = MinMax.minMax(new int[] { 1, 2, -3, 4, 5});

Console.WriteLine($"First: {first[0]}, {first[1]}");
Console.WriteLine($"Second: {second[0]}, {second[1]}");
Console.WriteLine($"Third: {third[0]}, {third[1]}");

public class MinMax
{
    public static int[] minMax(int[] lst)
    {
        int[] result = [];
        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (int num in lst)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }

        result = [min, max];
        
        return result;
    }
}