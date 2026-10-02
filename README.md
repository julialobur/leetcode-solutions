# LeetCode Solutions (.NET 8)

```
src/LeetCodeSolutions/
├── Easy/     # easy problems
└── Medium/   # medium problems
tests/LeetCodeSolutions.Tests/
├── Easy/     # one xUnit test file per easy solution
└── Medium/   # one xUnit test file per medium solution
```

Run all tests: `dotnet test`
Run one difficulty: `dotnet test --filter "FullyQualifiedName~.Easy."` (or `.Medium.`)

## Adding a new problem
1. Add `src/LeetCodeSolutions/<Difficulty>/<ProblemName>Solution.cs` (namespace `LeetCodeSolutions.<Difficulty>`).
2. Add `tests/LeetCodeSolutions.Tests/<Difficulty>/<ProblemName>SolutionTests.cs` (namespace `LeetCodeSolutions.Tests.<Difficulty>`) with multiple cases.
