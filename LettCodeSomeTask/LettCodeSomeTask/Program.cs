public class Solution
{
    public string ReverseStr(string s, int k)
    {
        var list = new List<string>();
        var result = string.Empty;
        var addS = string.Empty;

        foreach (var ch in s)
        {
            addS += ch;
            if (addS.Length == k)
            {
                list.Add(addS);
                addS = string.Empty;
            }
        }
        if (addS.Length > 0)
        {
            list.Add(addS);
        }

        for (int i = 0; i < list.Count; i++)
        {
            if (i % 2 == 0)
            {
                result += new string(list[i].Reverse().ToArray());
            }
            else
            {
                result += list[i];
            }
        }

        return result;
    }
}