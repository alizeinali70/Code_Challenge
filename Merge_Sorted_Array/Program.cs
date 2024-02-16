int[] nums1 = [1, 2, 3, 0, 0, 0];
int m = 3;
int[] nums2 = [2, 5, 6];
int n = 3;

//int[] nums1 = [1]; int m = 1; int[] nums2 = []; int n = 0;
//int[] nums1 = [0];int m = 0; int[] nums2 = [1];int n = 1;

for (int i = m; i < m + n; i++)
{
    for (int j = 0; j < n; j++)
    {
        nums1[i] = nums2[j];
        i++;
    }
}

Array.Sort(nums1);

Console.WriteLine($"{string.Join(", ", nums1)}");
Console.ReadLine();
