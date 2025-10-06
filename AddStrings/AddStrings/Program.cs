public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        var int1 = int.Parse(num1);
        var int2 = int.Parse(num2);

        var result = int1 + int2;

        return result.ToString(); 
    }
}