using LeetCodeSolutions.Easy;

namespace LeetCodeSolutions.Tests.Easy;

public class RemoveElementSolutionTests
{
    private readonly RemoveElementSolution _solution = new();

    [Theory]
    [InlineData(new[] { 3, 2, 2, 3 }, 3, new[] { 2, 2 })]
    [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new[] { 0, 0, 1, 3, 4 })]
    [InlineData(new[] { 1, 1 }, 1, new int[] { })]
    [InlineData(new[] { 1, 2 }, 3, new[] { 1, 2 })]
    [InlineData(new int[] { }, 0, new int[] { })]
    public void RemoveElement_ReturnsCountAndKeepsRemainingElements(int[] nums, int val, int[] expectedRemaining)
    {
        int k = _solution.RemoveElement(nums, val);

        Assert.Equal(expectedRemaining.Length, k);
        Assert.Equal(expectedRemaining.OrderBy(x => x), nums.Take(k).OrderBy(x => x));
    }
}
