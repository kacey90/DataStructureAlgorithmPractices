using Algorithms.Strings;
using FluentAssertions;

namespace Algorithms.Tests.String;
public class TimeConversionTests
{
    [TestCase("07:05:45PM", "19:05:45")]
    [TestCase("12:00:00AM", "00:00:00")]
    [TestCase("12:00:00PM", "12:00:00")]
    public void TimeConversionTest(string input, string expected)
    {
        var actual = TimeConversion.ConvertTime(input);
        actual.Should().Be(expected);
    }
}
