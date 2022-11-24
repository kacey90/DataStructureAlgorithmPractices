using FluentAssertions;

namespace Algorithms.Tests.Numerics;
public class PivotIndexTests
{
    [TestCase(new int[] { 1, 7, 3, 6, 5, 6 }, 3)]
    [TestCase(new int[] { 1, 2, 3 }, -1)]
    [TestCase(new int[] { 2, 1, -1 }, 0)]
    public void IsPivotIndexCorrect(int[] input, int expected)
    {
        var actual = PivotIndex.CalculatePivotIndex(input);
        actual.Should().Be(expected);
    }
}
