namespace Algorithms.Strings;
public class LongestSubstringsWithNoRepeatingCharacters
{
    public static int LengthOfLongestSubstring(string s)
    {
        var longest = 0;
        var current = 0;
        var start = 0;
        var end = 0;
        var dict = new Dictionary<char, int>();
        while (end < s.Length)
        {
            if (dict.ContainsKey(s[end]))
            {
                start = Math.Max(dict[s[end]] + 1, start);
            }
            dict[s[end]] = end;
            current = end - start + 1;
            longest = Math.Max(longest, current);
            end++;
        }
        return longest;
    }
}
