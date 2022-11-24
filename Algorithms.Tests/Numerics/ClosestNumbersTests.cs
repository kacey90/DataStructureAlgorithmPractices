using FluentAssertions;

namespace Algorithms.Tests.Numerics;
public class ClosestNumbersTests
{
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 30)]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 42)]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 56)]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 72)]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 90)]
    public void IsClosestNumbersCorrect(int[] input, int expected)
    {
        var actual = ClosestNumbers.CalculateClosestNumbers(input);
        actual.Should().Be(expected);
    }
}
