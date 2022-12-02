namespace Algorithms.Numerics;
public class LonelyInteger
{
    public static int Findlonelyinteger(List<int> a)
    {
        var result = 0;
        foreach (var item in a)
        {
            result ^= item;
        }
        return result;
    }
}
