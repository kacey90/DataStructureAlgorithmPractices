using Algorithms.Strings;
using FluentAssertions;

namespace Algorithms.Tests.String; 
public class LongestPalindromeSubstringTests 
{
    [TestCase("babad", "bab")]
    [TestCase("cbbd", "bb")]
    [TestCase("a", "a")]
    [TestCase("ac", "a")]
    public void LongestPalindromeSubstringTest(string input, string expected)
    {
        var actual = LongestPalindromeSubstring.CalculateLongestPalindromeSubstring(input);
        actual.Should().Be(expected);
    }
}
