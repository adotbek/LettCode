public class Solution
{
    public int TotalMoney(int n)
    {
        var result = 0;
        var a = 0;
        var j = 1;
        for (var i = 1; i <= n; i++)
        {
            if (i % 7 == 1 && i != 1)
            {
                a++;
                j = a;
            }
            result += j;
            j++;
        }
        return result;
    }
}