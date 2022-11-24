using Algorithms.Other;
using FluentAssertions;

namespace Algorithms.Tests.Other; 
public class DetectSquaresTests 
{
    [Test]
    public void DetectSquaresTest()
    {
        var detectSquares = new DetectSquares();
        detectSquares.Add(new int[] { 3, 10 });
        detectSquares.Add(new int[] { 11, 2 });
        detectSquares.Add(new int[] { 3, 2 });
        detectSquares.Count(new int[] { 11, 10 }).Should().Be(1);
        detectSquares.Count(new int[] { 14, 8 }).Should().Be(0);
        detectSquares.Add(new int[] { 11, 2 });
        detectSquares.Count(new int[] { 11, 10 }).Should().Be(2);
    }
}
