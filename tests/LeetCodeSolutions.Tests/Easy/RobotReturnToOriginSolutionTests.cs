using LeetCodeSolutions.Easy;

namespace LeetCodeSolutions.Tests.Easy;

public class RobotReturnToOriginSolutionTests
{
    private readonly RobotReturnToOriginSolution _solution = new();

    [Theory]
    [InlineData("UD", true)]
    [InlineData("LL", false)]

    [InlineData("U", false)]
    [InlineData("D", false)]
    [InlineData("L", false)]
    [InlineData("R", false)]

    [InlineData("LR", true)]
    [InlineData("RL", true)]
    [InlineData("DU", true)]
    [InlineData("UDLR", true)]
    [InlineData("LURD", true)]

    [InlineData("UDU", false)]
    [InlineData("LRL", false)]
    [InlineData("UDR", false)]

    [InlineData("UUUU", false)]
    [InlineData("RRRR", false)]
    [InlineData("UUDD", true)]
    [InlineData("LLRR", true)]

    [InlineData("UDLRUDLR", true)]
    [InlineData("UUUUDDDD", true)]
    [InlineData("RRRLLL", true)]
    [InlineData("UDLLRR", false)]
    [InlineData("UUDDL", false)]
    [InlineData("DURDLURD", true)]
    public void JudgeCircle_ReturnsWhetherRobotReturnsToOrigin(string moves, bool expected)
    {
        Assert.Equal(expected, _solution.JudgeCircle(moves));
    }
}