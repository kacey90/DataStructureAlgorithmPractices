using Algorithms.Strings;
using FluentAssertions;

namespace Algorithms.Tests.String;
public class LongestSubstringsWithNoRepeatingCharactersTests
{
    [TestCase("abcabcbb", 3)]
    [TestCase("bbbbb", 1)]
    [TestCase("pwwkew", 3)]
    [TestCase("dvdf", 3)]
    [TestCase("abba", 2)]
    [TestCase(" ", 1)]
    [TestCase("au", 2)]
    [TestCase("aab", 2)]
    [TestCase("tmmzuxt", 5)]
    public void LongestSubstringsWithNoRepeatingCharactersTest(string input, int expected)
    {
        var actual = LongestSubstringsWithNoRepeatingCharacters.LengthOfLongestSubstring(input);
        actual.Should().Be(expected);
    }
}
