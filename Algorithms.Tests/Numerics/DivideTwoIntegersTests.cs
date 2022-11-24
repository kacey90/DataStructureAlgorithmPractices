using FluentAssertions;

namespace Algorithms.Tests.Numerics;

public class DivideTwoIntegersTests
{
    [TestCase(10, 3, 3)]
    [TestCase(7, -3, -2)]
    public void DivideTwoIntegersCorrect(int dividend, int divisor, int expected)
    {
        var actual = DivideTwoIntegers.Divide(dividend, divisor);
        actual.Should().Be(expected);
    }
}
