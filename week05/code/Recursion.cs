using System.Collections;

public static class Recursion
{
    // --------------------
    // Problem 1
    // --------------------
    public static int SumSquaresRecursive(int n)
    {
        if (n <= 0)
            return 0;

        return n * n + SumSquaresRecursive(n - 1);
    }

    // --------------------
    // Problem 2
    // --------------------
    public static void PermutationsChoose(List<string> results, string letters, int size, string word = "")
    {
        // Base case: when the word reaches the target size
        if (word.Length == size)
        {
            results.Add(word);
            return;
        }

        // Try each unused letter
        for (int i = 0; i < letters.Length; i++)
        {
            // Remove letter at index i
            string remaining = letters.Remove(i, 1);

            // Add it to the word and recurse
            PermutationsChoose(results, remaining, size, word + letters[i]);
        }
    }

    // --------------------
    // Problem 3
    // --------------------
    public static decimal CountWaysToClimb(int s, Dictionary<int, decimal>? remember = null)
    {
        if (remember == null)
            remember = new Dictionary<int, decimal>();

        // Base cases
        if (s == 0) return 0;
        if (s == 1) return 1;
        if (s == 2) return 2;
        if (s == 3) return 4;

        // Memoization lookup
        if (remember.ContainsKey(s))
            return remember[s];

        decimal ways =
            CountWaysToClimb(s - 1, remember) +
            CountWaysToClimb(s - 2, remember) +
            CountWaysToClimb(s - 3, remember);

        remember[s] = ways;
        return ways;
    }

    // --------------------
    // Problem 4
    // --------------------
    public static void WildcardBinary(string pattern, List<string> results)
    {
        int index = pattern.IndexOf('*');

        // Base case: no wildcard
        if (index == -1)
        {
            results.Add(pattern);
            return;
        }

        // Replace * with 0
        string option0 = pattern[..index] + "0" + pattern[(index + 1)..];
        WildcardBinary(option0, results);

        // Replace * with 1
        string option1 = pattern[..index] + "1" + pattern[(index + 1)..];
        WildcardBinary(option1, results);
    }

    // --------------------
    // Problem 5
    // --------------------
    public static void SolveMaze(List<string> results, Maze maze, int x = 0, int y = 0, List<ValueTuple<int, int>>? currPath = null)
    {
        if (currPath == null)
            currPath = new List<ValueTuple<int, int>>();

        // Invalid move → stop the recursion
        if (!maze.IsValidMove(currPath, x, y))
            return;

        // Add current position to path
        currPath.Add((x, y));

        // If end found, store path
        if (maze.IsEnd(x, y))
        {
            results.Add(currPath.AsString());
            currPath.RemoveAt(currPath.Count - 1);
            return;
        }

        // Try moving in 4 directions: down, up, right, left
        SolveMaze(results, maze, x, y + 1, currPath); // down
        SolveMaze(results, maze, x, y - 1, currPath); // up
        SolveMaze(results, maze, x + 1, y, currPath); // right
        SolveMaze(results, maze, x - 1, y, currPath); // left

        // Backtrack
        currPath.RemoveAt(currPath.Count - 1);
    }
}
