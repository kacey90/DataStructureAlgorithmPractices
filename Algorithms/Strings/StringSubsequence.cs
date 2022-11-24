namespace Algorithms.Strings; 
public class StringSubsequence 
{
    /// <summary>
    /// Given two strings s and t, check if s is a subsequence of t.
    /// A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
    /// </summary>
    /// <param name="input"></param>
    /// <param name="subsequence"></param>
    /// <returns></returns>
    public static bool IsSubsequence(string s, string t)
    {
        var inputIndex = 0;
        var subsequenceIndex = 0;
        while (inputIndex < t.Length && subsequenceIndex < s.Length)
        {
            if (t[inputIndex] == s[subsequenceIndex])
            {
                subsequenceIndex++;
            }
            inputIndex++;
        }
        return subsequenceIndex == s.Length;
    }
}
