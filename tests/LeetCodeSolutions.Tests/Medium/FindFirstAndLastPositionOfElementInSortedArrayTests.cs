using LeetCodeSolutions.Medium;

namespace LeetCodeSolutions.Tests.Medium;

public class FindFirstAndLastPositionOfElementInSortedArrayTests
{
    private readonly FindFirstAndLastPositionOfElementInSortedArray _solution = new();

    [Theory]
    [InlineData(new[] { 5, 7, 7, 8, 8, 10 }, 8, new[] { 3, 4 })]
    [InlineData(new[] { 5, 7, 7, 8, 8, 10 }, 6, new[] { -1, -1 })]
    [InlineData(new int[0], 0, new[] { -1, -1 })]

    [InlineData(new[] { 1 }, 1, new[] { 0, 0 })]
    [InlineData(new[] { 1 }, 2, new[] { -1, -1 })]

    [InlineData(new[] { 2, 2, 3, 4, 5 }, 2, new[] { 0, 1 })]
    [InlineData(new[] { 1, 2, 3, 5, 5 }, 5, new[] { 3, 4 })]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 1, new[] { 0, 0 })]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 5, new[] { 4, 4 })]

    [InlineData(new[] { 7, 7, 7, 7, 7 }, 7, new[] { 0, 4 })]
    [InlineData(new[] { 7, 7, 7, 7, 7 }, 3, new[] { -1, -1 })]

    [InlineData(new[] { 2, 4, 6, 8 }, 1, new[] { -1, -1 })]
    [InlineData(new[] { 2, 4, 6, 8 }, 9, new[] { -1, -1 })]

    [InlineData(new[] { -10, -5, -5, -5, 0, 3 }, -5, new[] { 1, 3 })]
    public void SearchRange_ReturnsCorrectRange(int[] nums, int target, int[] expected)
    {
        Assert.Equal(expected, _solution.SearchRange(nums, target));
    }
}