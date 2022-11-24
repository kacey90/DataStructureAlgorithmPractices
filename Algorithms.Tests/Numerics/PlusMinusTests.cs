using FluentAssertions;

namespace Algorithms.Tests.Numerics;
public class PlusMinusTests
{
    [TestCaseSource(nameof(PlusMinusCases))]
    public void IsPlusMinusCorrect(List<int> arr, IEnumerable<decimal> expected)
    {
        var actual = PlusMinus.CalculatePlusMinus(arr);
        actual.Should().BeEquivalentTo(expected);
    }

    public static IEnumerable<TestCaseData> PlusMinusCases
    {
        get
        {
            yield return new TestCaseData(new List<int> { -4, 3, -9, 0, 4, 1 }, new decimal[] { 0.500000M, 0.333333M, 0.166667M });
            yield return new TestCaseData(new List<int> { 1, 1, 0, -1, -1 }, new decimal[] { 0.400000M, 0.400000M, 0.200000M });
        }
    }
}
