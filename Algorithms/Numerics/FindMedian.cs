namespace Algorithms.Numerics;
public class FindMedian
{
    public static int FindTheMedian(List<int> arr)
    {
        arr.Sort();

        int mid = arr.Count / 2;
        if (arr.Count % 2 == 0)
        {
            return (arr[mid] + arr[mid - 1]) / 2;
        }

        return arr[mid];
    }
}
