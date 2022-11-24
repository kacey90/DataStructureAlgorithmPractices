using Algorithms.Strings;
using FluentAssertions;

namespace Algorithms.Tests.String;
public class IsomorphicStringsTests
{
    [TestCase("egg", "add", true)]
    [TestCase("foo", "bar", false)]
    [TestCase("paper", "title", true)]
    [TestCase("ab", "aa", false)]
    public void IsIsomorphicTest(string input1, string input2, bool expected)
    {
        var actual = IsomorphicStrings.IsIsomorphic(input1, input2);
        actual.Should().Be(expected);
    }
}
