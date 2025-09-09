public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {

        if (gas.Sum() < cost.Sum()) return -1;

        int diff;
        bool check = false;
        bool check1 = false;
        int a, b;
        for (int i = 0; i < gas.Length; i++)
        {
            if (check1 == true && gas[i] == gas[i - 1] && cost[i] == cost[i - 1] && i != gas.Length - 1)
            {
                continue;
            }
            diff = gas[i] - cost[i];
            if (diff < 0)
            {
                check1 = true;
                continue;
            }
            check = GetRes(i, gas, cost);
            if (check == true) return i;
            else check1 = true;
        }
        return -1;
    }

    private bool GetRes(int index, int[] gaz, int[] cost)
    {
        int summa = 0;
        int n = gaz.Length;
        for (int i = index; i < n; i++)
        {
            summa += gaz[i];
            summa -= cost[i];
            if (summa < 0) return false;
        }

        for (int i = 0; i < index; i++)
        {
            summa += gaz[i];
            summa -= cost[i];
            if (summa < 0) return false;
        }

        return true;
    }
}
