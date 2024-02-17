int[] nums = [1, 2, 3, 4, 5, 6, 7];
int k = 3;
//nums = [1, 2];

k = k % nums.Length;
Array.Reverse(nums);
Array.Reverse(nums, 0, k);
Array.Reverse(nums, k, nums.Length - k);


Console.WriteLine($"{string.Join(", ", nums)}");