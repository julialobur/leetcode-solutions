namespace LeetCodeSolutions.Easy;

public class MissingNumberSolution
{
    public int MissingNumber(int[] nums)
    {
        int currentSum = nums.Sum();
        int n = nums.Length;
        int intendedSum = n * (n + 1) / 2;
        return intendedSum - currentSum;
    }
}
