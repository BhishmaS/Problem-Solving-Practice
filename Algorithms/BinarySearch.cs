using System;

namespace Learning.Algorithms
{
    public class BinarySearch
    {
        public int FindMin(int[] nums)
        {
            int start = 0, end = nums.Length - 1;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] > nums[end])
                {
                    start = mid + 1;
                }
                else if (nums[mid] < nums[end])
                {
                    end = mid;
                }
                else
                {
                    end--;
                }
            }

            return nums[start];
        }

        public void Search()
        {
            int[] nums = new int[] { 1 };
            int target = 1;
            int start = 0, end = nums.Length - 1;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                {
                    Console.WriteLine(mid);
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            Console.WriteLine(nums[start] > target ? start : start + 1);
        }

        public int SearchInsert(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return nums[start] >= target ? start : start + 1;
        }
    }
}
