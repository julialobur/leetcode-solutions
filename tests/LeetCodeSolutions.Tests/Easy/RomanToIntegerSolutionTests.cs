using LeetCodeSolutions.Easy;

namespace LeetCodeSolutions.Tests.Easy;

public class RomanToIntegerSolutionTests
{
    private readonly RomanToIntegerSolution _solution = new();

    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    [InlineData("IV", 4)]
    [InlineData("IX", 9)]
    [InlineData("XL", 40)]
    [InlineData("CD", 400)]
    [InlineData("MMMCMXCIX", 3999)]
    public void RomanToInt_ConvertsCorrectly(string input, int expected)
    {
        Assert.Equal(expected, _solution.RomanToInt(input));
    }
}
