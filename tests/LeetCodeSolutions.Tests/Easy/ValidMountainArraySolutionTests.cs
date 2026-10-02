using LeetCodeSolutions.Easy;

namespace LeetCodeSolutions.Tests.Easy;

public class ValidMountainArraySolutionTests
{
    private readonly ValidMountainArraySolution _solution = new();

    [Theory]
    [InlineData(new[] { 0, 3, 2, 1 }, true)]
    [InlineData(new[] { 1, 3, 2 }, true)]
    [InlineData(new[] { 0, 2, 3, 4, 5, 2, 1, 0 }, true)]
    [InlineData(new[] { 2, 1 }, false)]
    [InlineData(new[] { 3, 5, 5 }, false)]
    [InlineData(new[] { 0, 1, 2, 3 }, false)]
    [InlineData(new[] { 3, 2, 1 }, false)]
    [InlineData(new[] { 0, 2, 3, 3, 5, 2, 1, 0 }, false)]
    [InlineData(new[] { 1, 2, 1, 2 }, false)]
    [InlineData(new int[] { }, false)]
    public void ValidMountainArray_ReturnsExpected(int[] arr, bool expected)
    {
        Assert.Equal(expected, _solution.ValidMountainArray(arr));
    }
}
