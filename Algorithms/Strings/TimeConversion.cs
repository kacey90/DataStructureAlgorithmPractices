namespace Algorithms.Strings;
/// <summary>
/// https://www.hackerrank.com/challenges/time-conversion/problem
/// </summary>
public class TimeConversion
{
    public static string ConvertTime(string time)
    {
        var timeArray = time.Split(':');
        var hour = int.Parse(timeArray[0]);
        var minute = timeArray[1];
        var second = timeArray[2].Substring(0, 2);
        var amPm = timeArray[2].Substring(2, 2);
        if (amPm == "PM" && hour != 12)
        {
            hour += 12;
        }
        else if (amPm == "AM" && hour == 12)
        {
            hour = 0;
        }
        return $"{hour:00}:{minute}:{second}";
    }
}
