using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings;
public class PalindromeChecker
{
    public static string CheckPalindrome(string s, List<int> startIndex, List<int> endIndex, List<int> subs)
    {
        var result = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            var current = ExpandAroundCenter(s, i, i);
            if (current.Length > result.Length)
            {
                result = current;
                startIndex.Add(i - current.Length / 2);
                endIndex.Add(i + current.Length / 2);
                subs.Add(current.Length);
            }
            current = ExpandAroundCenter(s, i, i + 1);
            if (current.Length > result.Length)
            {
                result = current;
                startIndex.Add(i - current.Length / 2);
                endIndex.Add(i + current.Length / 2);
                subs.Add(current.Length);
            }
        }
        return result;

        
    }

    private static string ExpandAroundCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        return s.Substring(left + 1, right - left - 1);
    }
}
