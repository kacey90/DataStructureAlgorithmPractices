namespace Algorithms.Strings; 
public class LongestPalindromeSubstring 
{
    /// <summary>
    /// Given a string s, return the longest palindromic substring in s.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string CalculateLongestPalindromeSubstring(string input)
    {
        var result = string.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            var current = ExpandAroundCenter(input, i, i);
            if (current.Length > result.Length)
            {
                result = current;
            }
            current = ExpandAroundCenter(input, i, i + 1);
            if (current.Length > result.Length)
            {
                result = current;
            }
        }
        return result;
    }
    private static string ExpandAroundCenter(string input, int left, int right)
    {
        while (left >= 0 && right < input.Length && input[left] == input[right])
        {
            left--;
            right++;
        }
        return input.Substring(left + 1, right - left - 1);
    }
}
