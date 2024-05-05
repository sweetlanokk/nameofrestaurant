using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! In order to go further, press Enter!");
        Console.ReadLine();
        Console.WriteLine("Enter the input string:");
        string s = Console.ReadLine();

        Console.WriteLine("Enter the length of substrings:");
        int k = int.Parse(Console.ReadLine());

        bool hasIdenticalSubstrings = FindSubstring.HasIdenticalSubstrings(s, k);
        if (hasIdenticalSubstrings)
        {
            int uniqueNonRepeatedCharactersCount = CountUniqueNonRepeatedCharacters.Count(s, k);
            Console.WriteLine($"Number of unique non-repeated characters in identical substrings of length {k}: {uniqueNonRepeatedCharactersCount}");
        }
        else
        {
            Console.WriteLine("The input string does not contain at least two identical substrings of length " + k);
        }
    }
}
