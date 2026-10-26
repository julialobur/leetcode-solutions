using LeetCodeSolutions.Easy;

namespace LeetCodeSolutions.Tests.Easy;

public class AddBinarySolutionTests
{
    private readonly AddBinarySolution _solution = new();

    [Theory]
    [InlineData("11", "1", "100")]
    [InlineData("1010", "1011", "10101")]
    [InlineData("0", "0", "0")]
    [InlineData("0", "1", "1")]
    [InlineData("1", "0", "1")]
    [InlineData("1", "1", "10")]
    [InlineData("111", "111", "1110")]
    [InlineData("1111", "1", "10000")]
    [InlineData("1", "1111", "10000")]
    [InlineData("100", "110010", "110110")]
    [InlineData("1010000010010011011001", "1101010010111011100101", "11011110100001100101110")]
    [InlineData("111111111111111111111111111111111111111111111111111111111111111", "1", "1000000000000000000000000000000000000000000000000000000000000000")]
    public void AddBinary_ReturnsBinarySum(string a, string b, string expected)
    {
        Assert.Equal(expected, _solution.AddBinary(a, b));
    }
}