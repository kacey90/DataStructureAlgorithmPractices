namespace Algorithms.Numerics;
public class PlusMinus
{
    public static decimal[] CalculatePlusMinus(List<int> arr)
    {
        var positive = 0;
        var negative = 0;
        var zero = 0;
        var result = new decimal[3];
        foreach (var item in arr)
        {
            if (item > 0)
            {
                positive++;
            }
            else if (item < 0)
            {
                negative++;
            }
            else
            {
                zero++;
            }
        }
        //Console.WriteLine((decimal)positive / arr.Count);
        //Console.WriteLine((decimal)negative / arr.Count);
        //Console.WriteLine((decimal)zero / arr.Count);
        result[0] = Math.Round((decimal)positive / arr.Count, 6);
        result[1] = Math.Round((decimal)negative / arr.Count, 6);
        result[2] = Math.Round((decimal)zero / arr.Count, 6);

        return result;
    }
}
