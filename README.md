# LeetCode Solutions in C# (.NET 8)

A personal repository dedicated to practicing data structures, algorithms, and idiomatic C# problem-solving. 

## About This Repository

While LeetCode is great for quick iterations in the browser, solving problems locally encourages software engineering best practices rather than just writing throwaway scripts. 

This repository exists to:
- **Write Idiomatic C#**: Focus on clean, modern .NET 8 syntax, readability, and memory-efficient implementations.
- **Ensure Correctness with Unit Tests**: Pair every solution with comprehensive xUnit tests, covering standard inputs, edge cases, and performance constraints.
- **Maintain a Personal Reference**: Track progress across problem categories (arrays, strings, trees, dynamic programming) and serve as an easily searchable codebase for review.

---

## Project Structure

The solution is divided into the core implementation library and a matching xUnit test suite, categorized by difficulty:

```
src/LeetCodeSolutions/
├── Easy/       # Easy difficulty solutions
└── Medium/     # Medium difficulty solutions
tests/LeetCodeSolutions.Tests/
├── Easy/       # Unit test files for easy problems
└── Medium/     # Unit test files for medium problems
```

---

## Running Tests

All problems are verified locally using xUnit. You can run tests via the .NET CLI:

**Run all tests across the entire suite:**
```bash
dotnet test
```

**Run tests for a specific difficulty:**
```bash
# Easy problems only
dotnet test --filter "FullyQualifiedName~.Easy."

# Medium problems only
dotnet test --filter "FullyQualifiedName~.Medium."
```

**Run tests for a single problem:**
```bash
dotnet test --filter "FullyQualifiedName~<ProblemName>SolutionTests"
```

---

## Adding a New Problem

When adding a new solution, maintain parity between the implementation and test projects:

1. **Create the solution file:**
   - Path: `src/LeetCodeSolutions/<Difficulty>/<ProblemName>Solution.cs`
   - Namespace: `LeetCodeSolutions.<Difficulty>`
2. **Create the corresponding test file:**
   - Path: `tests/LeetCodeSolutions.Tests/<Difficulty>/<ProblemName>SolutionTests.cs`
   - Namespace: `LeetCodeSolutions.Tests.<Difficulty>`
   - Include multiple test cases using `[Theory]` and `[InlineData]` or `[Fact]` to cover standard cases, null/empty inputs, and boundary conditions.