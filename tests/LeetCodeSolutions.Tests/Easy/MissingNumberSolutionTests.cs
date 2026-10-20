using LeetCodeSolutions.Easy;

namespace LeetCodeSolutions.Tests.Easy;

public class MissingNumberSolutionTests
{
    private readonly MissingNumber _solution = new();

    [Theory]
    [InlineData(new[] { 3, 0, 1 }, 2)]
    [InlineData(new[] { 0, 1 }, 2)]
    [InlineData(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
    
    [InlineData(new[] { 0 }, 1)]
    [InlineData(new[] { 1 }, 0)]

    [InlineData(new[] { 1, 2, 3, 4 }, 0)]
    [InlineData(new[] { 0, 1, 2, 3 }, 4)]
    [InlineData(new[] { 3, 2, 1 }, 0)]

    [InlineData(new[] { 2, 0 }, 1)]
    [InlineData(new[] { 5, 4, 1, 0, 2 }, 3)]
    [InlineData(new[] { 7, 1, 6, 2, 5, 0, 4 }, 3)]
    public void MissingNumber_ReturnsMissingNumber(int[] nums, int expected)
    {
        Assert.Equal(expected, _solution.MissingNumber(nums));
    }
}