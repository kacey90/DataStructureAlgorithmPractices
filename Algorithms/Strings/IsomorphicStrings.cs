namespace Algorithms.Strings;
public class IsomorphicStrings
{
    /// <summary>
    /// Given two strings s and t, determine if they are isomorphic.
    /// Two strings s and t are isomorphic if the characters in s can be replaced to get t.
    /// All occurrences of a character must be replaced with another character while preserving the order of characters.
    /// No two characters may map to the same character, but a character may map to itself.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public static bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        var map = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
                if (map[s[i]] != t[i])
                {
                    return false;
                }
            }
            else
            {
                if (map.ContainsValue(t[i]))
                {
                    return false;
                }
                map.Add(s[i], t[i]);
            }
        }
        return true;
    }
}
