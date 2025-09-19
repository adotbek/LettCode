public class Solution
{
    public int AddDigits(int num)
    {
        while (num >= 10)
        {
            int result = 0;
            int temp = num;

           
            while (temp > 0)
            {
                result += temp % 10;
                temp /= 10;
            }

            num = result;
        }

        return num;
    }
}
