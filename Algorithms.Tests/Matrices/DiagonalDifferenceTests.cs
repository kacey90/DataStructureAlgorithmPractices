using Algorithms.Matrices;
using FluentAssertions;

namespace Algorithms.Tests.Matrices; 
public class DiagonalDifferenceTests 
{
    [TestCaseSource(nameof(DiagonalDifferenceTestCases))]
    public void DiagonalDifferenceTest(int[][] input, int expected)
    {
        var actual = DiagonalDifference.CalculateDiagonalDifference(input);
        actual.Should().Be(expected);
    }

    public static IEnumerable<object[]> DiagonalDifferenceTestCases
    {
        get
        {
            yield return new object[] { new int[][] { new int[] { 11, 2, 4 }, new int[] { 4, 5, 6 }, new int[] { 10, 8, -12 } }, 15 };
        }
    }
}

