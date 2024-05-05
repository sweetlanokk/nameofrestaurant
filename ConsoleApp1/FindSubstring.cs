using System.Collections.Generic;

public class FindSubstring
{
    public static bool HasIdenticalSubstrings(string s, int k)
    {
        HashSet<string> substrings = new HashSet<string>();

        for (int i = 0; i <= s.Length - k; i++)
        {
            string substring = s.Substring(i, k);
            if (substrings.Contains(substring))
            {
                return true;
            }
            substrings.Add(substring);
        }

        return false;
    }
}
