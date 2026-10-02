namespace LeetCodeSolutions.Easy;

public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seen_numbers = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            int neededNumber = target - num;
            if (seen_numbers.ContainsKey(neededNumber))
            {
                return new int[] { seen_numbers[neededNumber], i };
            }
            else
            {
                seen_numbers[num] = i;
            }
        }
        throw new ArgumentException("No two sum solution");
    }
}
