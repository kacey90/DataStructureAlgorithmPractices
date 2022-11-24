using FluentAssertions;

namespace Algorithms.Tests.Numerics;
public class RunningSumTests
{
    [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
    [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 })]
    [TestCase(new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new int[] { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 })]
    public void IsRunningSumTestsCorrect(int[] input, int[] expected)
    {
        var actual = RunningSum.CalculateRunningSum(input);
        actual.Should().Equal(expected);
    }
}
