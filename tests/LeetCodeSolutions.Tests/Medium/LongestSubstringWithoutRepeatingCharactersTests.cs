using LeetCodeSolutions.Medium;
using Xunit;

public class LongestSubstringTests
{
    private readonly LongestSubstringWithoutRepeatingCharactersSolution _solution = new();

    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]

    [InlineData("", 0)] 
    [InlineData(" ", 1)]
    [InlineData("au", 2)]
    [InlineData("aab", 2)]
    [InlineData("aabacbebe", 4)]
    [InlineData("dvdf", 3)]
    [InlineData("tmmzuxt", 5)]

    [InlineData("abc 123!@#", 10)]
    [InlineData("   ", 1)]
    [InlineData("12312345", 5)]
    public void LengthOfLongestSubstring_ReturnsCorrectLength(string s, int expected)
    {
        int actual = _solution.LengthOfLongestSubstring(s);

        Assert.Equal(expected, actual);
    }
}