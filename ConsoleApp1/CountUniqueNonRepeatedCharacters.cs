using System;
using System.Collections.Generic;

public class CountUniqueNonRepeatedCharacters
{
    public static int Count(string s, int k)
    {
        HashSet<char> uniqueNonRepeatedCharacters = new HashSet<char>();

        for (int i = 0; i <= s.Length - k; i++)
        {
            string substring = s.Substring(i, k);
            if (s.IndexOf(substring, i + 1) != -1)
            {
                Dictionary<char, int> charCounts = new Dictionary<char, int>();

                // Count occurrences of each character in the substring
                foreach (char c in substring)
                {
                    if (!charCounts.ContainsKey(c))
                    {
                        charCounts[c] = 0;
                    }
                    charCounts[c]++;
                }

                // Add characters that occur only once to the set of unique non-repeated characters
                foreach (var pair in charCounts)
                {
                    if (pair.Value == 1)
                    {
                        uniqueNonRepeatedCharacters.Add(pair.Key);
                    }
                }
            }
        }

        return uniqueNonRepeatedCharacters.Count;
    }
}
