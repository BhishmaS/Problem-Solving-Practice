public class SubArrayRanges
{
    public long SubArraysSum(int[] nums, int start, int end)
    {
        if (end >= nums.Length)
        {
            return 0;
        }

        if (start > end)
        {
            return this.SubArraysSum(nums, 0, end + 1);
        }

        long min = nums[start], max = nums[start];
        for (int i = start + 1; i <= end; i++)
        {
            if (min > nums[i])
            {
                min = nums[i];
            }

            if (max < nums[i])
            {
                max = nums[i];
            }
        }

        return (max - min) + this.SubArraysSum(nums, start + 1, end);
    }

    public long FindSubArrayRanges(int[] nums)
    {
        return this.SubArraysSum(nums, 0, 0);
    }
}