public class Solution
{
    public int DayOfYear(string date)
    {
        var result = 0;
        var dayStr = date.Substring(date.Length - 2);
        var monthStr = date.Substring(5, 2);
        var yearStr = date.Substring(0, 4);

        var day = int.Parse(dayStr);
        var month = int.Parse(monthStr);
        var year = int.Parse(yearStr);

        result += day;

        if (month == 2)
        {
            result += 31;
        }
        else if (month == 3)
        {
            result += 59;
        }
        else if (month == 4)
        {
            result += 90;
        }
        else if (month == 5)
        {
            result += 120;
        }
        else if (month == 6)
        {
            result += 151;
        }
        else if (month == 7)
        {
            result += 181;
        }
        else if (month == 8)
        {
            result += 212;
        }
        else if (month == 9)
        {
            result += 243;
        }
        else if (month == 10)
        {
            result += 273;
        }
        else if (month == 11)
        {
            result += 304;
        }
        else if (month == 12)
        {
            result += 334;
        }

        if ((year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) && month > 2)
        {
            result += 1;
        }

        return result;
    }
}
