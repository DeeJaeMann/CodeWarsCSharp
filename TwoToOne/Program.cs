// Take 2 strings s1 and s2 including only letters from a to z. Return a new sorted string (alphabetical ascending), 
// the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.
//
//     Examples:
// a = "xyaabbbccccdefww"
// b = "xxxxyyyyabklmopq"
// longest(a, b) -> "abcdefklmopqwxy"
//
// a = "abcdefghijklmnopqrstuvwxyz"
// longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"

Console.WriteLine(Longest("abcdef", "hijklm"));

static string Longest(string s1, string s2)
{
    string result = "";

    HashSet<char> inputA = new();
    HashSet<char> inputB = new();

    foreach (char c in s1)
    {
        inputA.Add(c);
    }

    foreach (char c in s2)
    {
        inputB.Add(c);
    }

    // HashSet<char> parseSet = inputA.UnionWith(inputB);
    // foreach (char c in inputA)
    // {
    //     Console.Write($"{c}, ");
    // }
    inputA.UnionWith(inputB);

    foreach (char c in inputA)
    {
        result += c;
    }

    return result;
}