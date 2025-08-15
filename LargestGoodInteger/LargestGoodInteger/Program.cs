public class Solution
{
    public string LargestGoodInteger(string num)
    {
        var zero = "";
        var one = "";
        var two = "";
        var three = "";
        var four = "";
        var five = "";
        var six = "";
        var seven = "";
        var eight = "";
        var nine = "";
        var largest = "";

        var values = new []{ zero, one, two, three, four, five, six, seven, eight, nine };

        if (num.Contains("000")) zero = "000";
        if (num.Contains("111")) one = "111";
        if (num.Contains("222")) two = "222";
        if (num.Contains("333")) three = "333";
        if (num.Contains("444")) four = "444";
        if (num.Contains("555")) five = "555";
        if (num.Contains("666")) six = "666";
        if (num.Contains("777")) seven = "777";
        if (num.Contains("888")) eight = "888";
        if (num.Contains("999")) nine = "999";
        
        foreach (var value in values)
        {
            if (string.Compare(value, largest) > 0)
            {
                largest = value;
            }
        }
        return largest;
    }


}
