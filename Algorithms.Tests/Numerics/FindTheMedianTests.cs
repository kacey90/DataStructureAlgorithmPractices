using FluentAssertions;

namespace Algorithms.Tests.Numerics;
internal class FindTheMedianTests
{
    [TestCaseSource(nameof(FindTheMedianCases))]
    public void FindTheMedianTest(List<int> arr, int expected)
    {
        var actual = FindMedian.FindTheMedian(arr);
        actual.Should().Be(expected);
    }

    public static IEnumerable<TestCaseData> FindTheMedianCases
    {
        get
        {
            yield return new TestCaseData(new List<int> { 0, 1, 2, 4, 6, 5, 3 }, 3);
            yield return new TestCaseData(new List<int> { 0, 1, 2, 4, 6, 5, 3, 7 }, 3);
        }
    }
}
