using LeetCodeSolutions.Easy;

namespace LeetCodeSolutions.Tests.Easy;

public class TwoSumSolutionTests
{
    private readonly TwoSumSolution _solution = new();

    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    [InlineData(new[] { -1, -2, -3, -4, -5 }, -8, new[] { 2, 4 })]
    [InlineData(new[] { 0, 4, 3, 0 }, 0, new[] { 0, 3 })]
    public void TwoSum_ReturnsIndicesOfPair(int[] nums, int target, int[] expected)
    {
        Assert.Equal(expected, _solution.TwoSum(nums, target));
    }

    [Fact]
    public void TwoSum_NoSolution_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _solution.TwoSum(new[] { 1, 2, 3 }, 100));
    }
}
