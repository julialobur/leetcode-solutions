using LeetCodeSolutions.Medium;

namespace LeetCodeSolutions.Tests.Medium;

public class ContainerWithMostWaterSolutionTests
{
    private readonly ContainerWithMostWaterSolution _solution = new();

    [Theory]
    [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    [InlineData(new[] { 1, 1 }, 1)]
    [InlineData(new[] { 4, 3, 2, 1, 4 }, 16)]
    [InlineData(new[] { 1, 2, 1 }, 2)]
    [InlineData(new[] { 2, 3, 4, 5, 18, 17, 6 }, 17)]
    [InlineData(new[] { 0, 0 }, 0)]
    public void MaxArea_ReturnsLargestContainer(int[] height, int expected)
    {
        Assert.Equal(expected, _solution.MaxArea(height));
    }
}
