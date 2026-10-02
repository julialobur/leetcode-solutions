using LeetCodeSolutions.Medium;

namespace LeetCodeSolutions.Tests.Medium;

public class BoatsToSavePeopleSolutionTests
{
    private readonly BoatsToSavePeopleSolution _solution = new();

    [Theory]
    [InlineData(new[] { 1, 2 }, 3, 1)]
    [InlineData(new[] { 3, 2, 2, 1 }, 3, 3)]
    [InlineData(new[] { 3, 5, 3, 4 }, 5, 4)]
    [InlineData(new[] { 5 }, 5, 1)]
    [InlineData(new[] { 1, 1, 1, 1 }, 2, 2)]
    [InlineData(new[] { 2, 2, 2 }, 4, 2)]
    public void NumRescueBoats_ReturnsMinimumBoats(int[] people, int limit, int expected)
    {
        Assert.Equal(expected, _solution.NumRescueBoats(people, limit));
    }
}
