namespace Algorithms.Numerics;
public static class PivotIndex
{
    /// <summary>
    /// Given an array of integers nums, write a method that returns the "pivot" index of this array.
    /// We define the pivot index as the index where the sum of the numbers to the left of the index is equal to the sum of the numbers to the right of the index.
    /// If no such index exists, we should return -1. If there are multiple pivot indexes, you should return the left-most pivot index.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int CalculatePivotIndex(int[] nums)
    {
        var leftSum = 0;
        var rightSum = nums.Sum();
        for (int i = 0; i < nums.Length; i++)
        {
            rightSum -= nums[i];
            if (leftSum == rightSum)
            {
                return i;
            }
            leftSum += nums[i];
        }
        return -1;
    }
}
