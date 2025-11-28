using System;
using System.Collections.Generic;

public class SequentialPathMerger
{
    public static void Main(string[] args)
    {
        // 1. Input List (Preserving the exact order you provided)
        List<string> rawPaths = new List<string>
        {
            "app/src/root/game/file1.cpp",
            "app/src/root/game/file2.cpp",
            "app/src/root/tool/file3.cpp",
            "app/src/root/file4.cpp",  // Note: Shorter path appearing after deeper paths
            "app/data/file5.cpp",
            "pom.xml"
        };

        Console.WriteLine("--- Sequential Merged Output ---");
        MergeAndPrint(rawPaths);
    }

    public static void MergeAndPrint(List<string> inputPaths)
    {
        if (inputPaths == null || inputPaths.Count == 0) return;

        // --- STEP 1: Parse into 2D Array (List of Token Arrays) ---
        // We do NOT sort here. We preserve the exact index order of the input.
        List<string[]> pathMatrix = new List<string[]>();
        
        foreach (var path in inputPaths)
        {
            if (string.IsNullOrWhiteSpace(path)) continue;
            string[] tokens = path.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            pathMatrix.Add(tokens);
        }

        if (pathMatrix.Count == 0) return;

        // --- STEP 2: Print the First Path (Baseline) ---
        // The first entry is always printed in full to establish the tree root(s).
        string[] baseline = pathMatrix[0];
        PrintTokens(baseline, 0);

        // --- STEP 3: Compare Subsequent Paths to the Baseline ---
        // We iterate strictly in the order of the array.
        for (int i = 1; i < pathMatrix.Count; i++)
        {
            string[] currentPath = pathMatrix[i];
            
            // Compare current row vs previous row (the baseline)
            int divergenceIndex = 0;
            int minLen = Math.Min(baseline.Length, currentPath.Length);

            // Find how many tokens match the previous path
            while (divergenceIndex < minLen && baseline[divergenceIndex] == currentPath[divergenceIndex])
            {
                divergenceIndex++;
            }

            // --- STEP 4: Print Output ---
            // If divergenceIndex == 0, the paths are completely different (no common root).
            // We print the indentation for matched parts, then the new/differing tokens.
            PrintIndentation(divergenceIndex);
            PrintTokens(currentPath, divergenceIndex);

            // Update baseline to the current path for the next iteration
            baseline = currentPath;
        }
    }

    private static void PrintTokens(string[] tokens, int startIndex)
    {
        for (int i = startIndex; i < tokens.Length; i++)
        {
            Console.Write($"--> {tokens[i]} ");
        }
        Console.WriteLine();
    }

    private static void PrintIndentation(int count)
    {
        // For every matched token, we print spacing to align the tree visually.
        // Adjust the multiplier (e.g., 5 spaces) to match the length of "--> token ".
        // Simpler approach: Fixed width indentation.
        for (int i = 0; i < count; i++)
        {
            Console.Write("     "); 
        }
    }
}