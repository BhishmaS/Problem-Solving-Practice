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

        public int SearchRotatedTarget(int[] nums, int target)
        {
            int begin = 0, end = nums.Length - 1;

            while (begin <= end)
            {
                int mid = begin + (end - begin) / 2;

                if (target == nums[mid])
                {
                    return mid;
                }
                else if (nums[begin] <= nums[mid])
                {
                    if (target >= nums[begin] && target < nums[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        begin = mid + 1;
                    }
                }
                else
                {
                    if (target > nums[mid] && target <= nums[end])
                    {
                        begin = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }

            return -1;
        }
    }
}
