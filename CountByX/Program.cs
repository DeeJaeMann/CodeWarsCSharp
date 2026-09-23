// Create a function with two arguments that will return an array of the first n multiples of x.
//
//     Assume both the given number and the number of times to count will be positive numbers greater than 0.
//
//     Return the results as an array or list ( depending on language ).
//
//     Examples
// x = 1, n = 10 --> [1,2,3,4,5,6,7,8,9,10]
// x = 2, n = 5  --> [2,4,6,8,10]

int[] first = new int[] { 1, 2, 3, 4, 5 };

int[] firstResult = CountBy(1, 5);

foreach (int num in firstResult)
{
    Console.Write($"{num}, ");
}

static int[] CountBy(int x, int n)
{
    int[] z = new int[n];

    for (int index = 1; index <= n; index++)
    {
        z[index - 1] = index * x;
    }

    return z;
}