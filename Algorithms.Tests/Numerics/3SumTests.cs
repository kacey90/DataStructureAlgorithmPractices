using FluentAssertions;

namespace Algorithms.Tests.Numerics; 
public class _3SumTests 
{
    [TestCaseSource(nameof(ThreeSumTestCases))]
    public void ThreeSumTest(int[] input, IList<IList<int>> expected)
    {
        var actual = _3Sum.ThreeSum(input);
        actual.Should().BeEquivalentTo(expected);
    }

    public static IEnumerable<TestCaseData> ThreeSumTestCases
    {
        get
        {
            yield return new TestCaseData(new int[] { -1, 0, 1, 2, -1, -4 }, new List<IList<int>> { new List<int> { -1, -1, 2 }, new List<int> { -1, 0, 1 } });
            yield return new TestCaseData(new int[] { 0 }, new List<IList<int>> { });
            yield return new TestCaseData(new int[] { 0, 0, 0 }, new List<IList<int>> { new List<int> { 0, 0, 0 } });
        }
    }
}
