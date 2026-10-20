namespace LeetCodeSolutions.Medium;
public class FindFirstAndLastPositionOfElementInSortedArray
{
    private int FindLast(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (right >= left)
        {
            int mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                if (mid == nums.Length - 1 || nums[mid + 1] != target)
                {
                    return mid;
                }
                left = mid + 1;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return -1;
    }

    private int FindFirst(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (right >= left)
        {
            int mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                if (mid == 0 || nums[mid - 1] != target)
                {
                    return mid;
                }
                right = mid - 1;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return -1;
    }

    public int[] SearchRange(int[] nums, int target)
    {
        int first = FindFirst(nums, target);
        int last = FindLast(nums, target);

        return new int[] { first, last };
    }
}
