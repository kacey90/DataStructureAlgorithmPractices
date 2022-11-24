using Algorithms.Strings;
using FluentAssertions;

namespace Algorithms.Tests.String; 
public class StringSubsequenceTests 
{
    [TestCase("abc", "ahbgdc", true)]
    [TestCase("axc", "ahbgdc", false)]
    public void IsSubsequenceTest(string input1, string input2, bool expected)
    {
        var actual = StringSubsequence.IsSubsequence(input1, input2);
        actual.Should().Be(expected);
    }
}
