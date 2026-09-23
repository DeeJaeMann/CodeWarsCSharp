// An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that 
//     determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. 
// Ignore letter case.
//
// Example: (Input --> Output)
//
// "Dermatoglyphics" --> true
// "aba" --> false
// "moOse" --> false (ignore letter case)

static bool IsIsogram(string str)
{
    Dictionary<char, int> letters = new();
    foreach (char c in str)
    {
        char letter = Char.ToLower(c);
        if (letters.ContainsKey(letter)) return false;
        else letters[letter] = 1;
    }
    return true;
}