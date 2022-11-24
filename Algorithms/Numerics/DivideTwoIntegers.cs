namespace Algorithms.Numerics;

/// <summary>
/// Given two integers dividend and divisor, divide two integers without using multiplication, division, and mod operator.

/// The integer division should truncate toward zero, which means losing its fractional part.For example, 8.345 would be truncated to 8, and -2.7335 would be truncated to -2.

/// Return the quotient after dividing dividend by divisor.
/// </summary>
public class DivideTwoIntegers
{
    public static int Divide(int dividend, int divisor)
    {
        if (dividend == int.MinValue && divisor == -1)
        {
            return int.MaxValue;
        }

        var isNegative = (dividend < 0) ^ (divisor < 0);
        var quotient = 0;
        var dividendAbs = Math.Abs((long)dividend);
        var divisorAbs = Math.Abs((long)divisor);

        while (dividendAbs >= divisorAbs)
        {
            var temp = divisorAbs;
            var multiple = 1;

            while (dividendAbs >= temp << 1)
            {
                temp <<= 1;
                multiple <<= 1;
            }

            dividendAbs -= temp;
            quotient += multiple;
        }

        return isNegative ? -quotient : quotient;
    }
}
