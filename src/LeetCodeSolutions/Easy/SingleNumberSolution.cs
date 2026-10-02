namespace LeetCodeSolutions.Easy;

public class SingleNumberSolution
{
    public int SingleNumber(int[] nums)
    {
        int result = 0;
        foreach (var num in nums)
        {
            result ^= num;
        }
        return result;
    }
}
