using LeetCodeSolutions.Easy;

namespace LeetCodeSolutions.Tests.Easy;

public class SingleNumberSolutionTests
{
    private readonly SingleNumberSolution _solution = new();

    [Theory]
    [InlineData(new[] { 2, 2, 1 }, 1)]
    [InlineData(new[] { 4, 1, 2, 1, 2 }, 4)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] { -1, -1, -3 }, -3)]
    [InlineData(new[] { 0, 5, 0 }, 5)]
    public void SingleNumber_ReturnsUniqueElement(int[] nums, int expected)
    {
        Assert.Equal(expected, _solution.SingleNumber(nums));
    }
}
