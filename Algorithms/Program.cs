class MergeSortedArray
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int p1 = m - 1;
        int p2 = n - 1;
        int pMerge = n + m - 1;
        while (p2 >= 0)
        {
            if (p1 > 0 && nums1[p1] > nums2[p2])
            {
                nums1[pMerge--] = nums1[p1--];
            }
            else
            {
                nums1[pMerge--] = nums2[p2--];
            }
        }
    }
   
}
class Solutions
{
    public static void Main(String[] args)
    {
        MergeSortedArray sol = new MergeSortedArray();
        int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = new int[] { 2, 5, 6 };
        sol.Merge(nums1, 3, nums2, 3);
        foreach (var item in nums1)
        {
            Console.WriteLine(item);
        }
    }
}


