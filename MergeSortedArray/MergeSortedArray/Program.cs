public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int [] result = nums1.Take(m).Concat(nums2.Take(n)).ToArray();
        Array.Sort(result);
        for (var i = 0; i < result.Length; i++)
        {
            nums1[i] = result[i];
        }
    }
}