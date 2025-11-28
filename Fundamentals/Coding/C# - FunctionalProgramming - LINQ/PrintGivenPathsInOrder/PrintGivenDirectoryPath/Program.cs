// using System;
// using System.Collections.Generic;

// public class SequentialPathMerger
// {
//     public static void Main(string[] args)
//     {
//         // 1. Input List (Preserving the exact order you provided)
//         List<string> rawPaths = new List<string>
//         {
//             "app/src/root/game/file1.cpp",
//             "app/src/root/game/file2.cpp",
//             "app/src/root/tool/file3.cpp",
//             "app/src/root/file4.cpp",  // Note: Shorter path appearing after deeper paths
//             "app/data/file5.cpp",
//             "pom.xml"
//         };

//         Console.WriteLine("--- Sequential Merged Output ---");
//         MergeAndPrint(rawPaths);
//     }

//     public static void MergeAndPrint(List<string> inputPaths)
//     {
//         if (inputPaths == null || inputPaths.Count == 0) return;

//         // --- STEP 1: Parse into 2D Array (List of Token Arrays) ---
//         // We do NOT sort here. We preserve the exact index order of the input.
//         List<string[]> pathMatrix = new List<string[]>();
        
//         foreach (var path in inputPaths)
//         {
//             if (string.IsNullOrWhiteSpace(path)) continue;
//             string[] tokens = path.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
//             pathMatrix.Add(tokens);
//         }

//         if (pathMatrix.Count == 0) return;

//         // --- STEP 2: Print the First Path (Baseline) ---
//         // The first entry is always printed in full to establish the tree root(s).
//         string[] baseline = pathMatrix[0];
//         PrintTokens(baseline, 0);

//         // --- STEP 3: Compare Subsequent Paths to the Baseline ---
//         // We iterate strictly in the order of the array.
//         for (int i = 1; i < pathMatrix.Count; i++)
//         {
//             string[] currentPath = pathMatrix[i];
            
//             // Compare current row vs previous row (the baseline)
//             int divergenceIndex = 0;
//             int minLen = Math.Min(baseline.Length, currentPath.Length);

//             // Find how many tokens match the previous path
//             while (divergenceIndex < minLen && baseline[divergenceIndex] == currentPath[divergenceIndex])
//             {
//                 divergenceIndex++;
//             }

//             // --- STEP 4: Print Output ---
//             // If divergenceIndex == 0, the paths are completely different (no common root).
//             // We print the indentation for matched parts, then the new/differing tokens.
//             PrintIndentation(divergenceIndex);
//             PrintTokens(currentPath, divergenceIndex);

//             // Update baseline to the current path for the next iteration
//             baseline = currentPath;
//         }
//     }

//     private static void PrintTokens(string[] tokens, int startIndex)
//     {
//         for (int i = startIndex; i < tokens.Length; i++)
//         {
//             Console.Write($"--> {tokens[i]} ");
//         }
//         Console.WriteLine();
//     }

//     private static void PrintIndentation(int count)
//     {
//         // For every matched token, we print spacing to align the tree visually.
//         // Adjust the multiplier (e.g., 5 spaces) to match the length of "--> token ".
//         // Simpler approach: Fixed width indentation.
//         for (int i = 0; i < count; i++)
//         {
//             Console.Write("     "); 
//         }
//     }
// }


// Approach 2 (Trie)

using System;
using System.Collections.Generic;
using System.Linq;

namespace FileSystemTrie
{
    // 1. The Node Class
    // Represents a single folder or file in the hierarchy.
    public class TrieNode
    {
        public string Name { get; set; }
        
        // Using SortedDictionary to ensure the output is automatically sorted alphabetically.
        public SortedDictionary<string, TrieNode> Children { get; set; }

        public TrieNode(string name)
        {
            Name = name;
            Children = new SortedDictionary<string, TrieNode>();
        }
    }

    // 2. The Trie Structure
    // Manages the root and operations.
    public class PathTrie
    {
        private readonly TrieNode _root;

        public PathTrie()
        {
            // The root is a dummy node (entry point).
            _root = new TrieNode("ROOT");
        }

        // INSERT: Parses the path and builds the tree nodes
        public void InsertPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return;

            // Normalize and split
            // "app/src/file.cpp" -> ["app", "src", "file.cpp"]
            String[] tokens = path.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            
            TrieNode currentNode = _root;

            foreach (var token in tokens)
            {
                // If the child directory doesn't exist, create it.
                if (!currentNode.Children.ContainsKey(token))
                {
                    currentNode.Children[token] = new TrieNode(token);
                }
                
                // Move the pointer down to the child
                currentNode = currentNode.Children[token];
            }
        }

        // PRINT: Triggers the recursive display
        public void PrintStructure()
        {
            // Start printing from the children of Root (we don't print Root itself)
            foreach (var child in _root.Children.Values)
            {
                PrintRecursive(child, 0);
            }
        }

        // Recursive Helper for Depth-First Search
        private void PrintRecursive(TrieNode node, int indentLevel)
        {
            // 1. Print Indentation
            // Using 5 spaces to align with the length of "--> "
            for (int i = 0; i < indentLevel; i++)
            {
                Console.Write("     "); 
            }

            // 2. Print the current node
            Console.WriteLine($"--> {node.Name}");

            // 3. Recurse down to children (DFS)
            foreach (var child in node.Children.Values)
            {
                PrintRecursive(child, indentLevel + 1);
            }
        }
    }

    // 3. Main Execution
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rawPaths = new List<string>
            {
                "app/src/root/game/file1.cpp",
                "app/src/root/game/file2.cpp",
                "app/src/root/tool/file3.cpp",
                "app/src/root/file4.cpp",
                "app/data/file5.cpp",
                "pom.xml",
                // The Trie handles unsorted or scrambled inputs gracefully
                "app/src/root/game/assets/image.png" 
            };

            PathTrie fileSystem = new PathTrie();

            Console.WriteLine("Building Trie...");
            foreach (var path in rawPaths)
            {
                fileSystem.InsertPath(path);
            }

            Console.WriteLine("\n--- Trie-Based Hierarchical Output ---");
            fileSystem.PrintStructure();
        }
    }
}