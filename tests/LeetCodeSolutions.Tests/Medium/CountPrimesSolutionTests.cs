using LeetCodeSolutions.Medium;

namespace LeetCodeSolutions.Tests.Medium;

public class CountPrimesSolutionTests
{
    private readonly CountPrimesSolution _solution = new();

    [Theory]
    [InlineData(10, 4)]
    [InlineData(0, 0)]
    [InlineData(1, 0)]

    [InlineData(2, 0)]
    [InlineData(3, 1)]
    [InlineData(4, 2)]
    [InlineData(5, 2)]

    [InlineData(11, 4)]
    [InlineData(12, 5)]
    [InlineData(20, 8)]
    [InlineData(30, 10)]

    [InlineData(100, 25)]
    [InlineData(1000, 168)]
    [InlineData(10000, 1229)]
    [InlineData(499979, 41537)]
    public void CountPrimes_ReturnsCountOfPrimesStrictlyLessThanN(int n, int expected)
    {
        Assert.Equal(expected, _solution.CountPrimes(n));
    }
}