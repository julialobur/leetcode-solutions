using Xunit;

public class MoveZeroesTests
{
    private readonly Solution _solution = new();

    [Theory]
    [InlineData(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
    [InlineData(new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new[] { 0, 0, 0 }, new[] { 0, 0, 0 })]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4 })]
    [InlineData(new[] { 1, 0 }, new[] { 1, 0 })]
    [InlineData(new[] { 0, 1 }, new[] { 1, 0 })]
    [InlineData(new[] { 2, 1 }, new[] { 2, 1 })]
    [InlineData(new[] { 4, 2, 4, 0, 0, 3, 0, 5, 1, 0 },
                new[] { 4, 2, 4, 3, 5, 1, 0, 0, 0, 0 })] 
    public void MoveZeroes_ModifiesArrayInPlace(int[] input, int[] expected)
    {
        _solution.MoveZeroes(input);

        Assert.Equal(expected, input);
    }
}