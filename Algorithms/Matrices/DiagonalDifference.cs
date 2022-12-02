namespace Algorithms.Matrices;
public class DiagonalDifference
{
    public static int CalculateDiagonalDifference(int[][] arr)
    {
        var leftToRight = 0;
        var rightToLeft = 0;
        for (var i = 0; i < arr.Length; i++)
        {
            leftToRight += arr[i][i];
            rightToLeft += arr[i][arr.Length - i - 1];
        }
        return Math.Abs(leftToRight - rightToLeft);
    }
}
