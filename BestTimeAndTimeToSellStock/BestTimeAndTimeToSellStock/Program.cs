using System.Numerics;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var result = 0;
        var min = int.MaxValue;
        var max = 0;
        foreach (var price in prices)
        {
            if (price < min) min = price;
            result = price - min;
            if (price > min) max = price;
        }
        return max;
    }
}
