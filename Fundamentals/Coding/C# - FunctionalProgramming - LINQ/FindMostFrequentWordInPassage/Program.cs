using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq; // Added for easy Dictionary sorting

namespace TextAnalysisDemo
{
    public class WordFrequencyAnalyzer
    {
        public static (string Word, int Count) FindMostImportantWord(string passageString, HashSet<string> stopWordSet)
        {
            if (string.IsNullOrWhiteSpace(passageString))
            {
                return (null, 0);
            }

            // 1. Normalize to lowercase
            string normalizedText = passageString.ToLowerInvariant();

            // 2. Clean text: Replace anything that is NOT a letter or digit with a space.
            string cleanedText = Regex.Replace(normalizedText, @"[^a-z0-9]+", " ");

            // 3. Tokenize: Split by space AND remove empty entries.
            // This is the critical to ensure empty strings don't get counted.
            string[] tokens = cleanedText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var wordFrequencyMap = new Dictionary<string, int>();

            foreach (string token in tokens)
            {
                // No need to Trim() here because RemoveEmptyEntries handles it.
                string word = token;

                // Filter stop words
                if (stopWordSet.Contains(word))
                {
                    continue;
                }

                // Count
                if (wordFrequencyMap.ContainsKey(word))
                {
                    wordFrequencyMap[word]++;
                }
                else
                {
                    wordFrequencyMap.Add(word, 1);
                }
            }

            // 4. Find winner (Handling ties by picking the first alphabetical one)
            if (wordFrequencyMap.Count > 0)
            {
                // Order by count descending, then by word ascending to break ties consistently
                var winner = wordFrequencyMap
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .First();

                return (winner.Key, winner.Value);
            }

            return (null, 0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The same sample input
            string samplePassage = @"
                Software engineering is not just about writing code. 
                A good software engineer thinks about architecture, testing, and scalability.
                Code is important, but engineering the entire system is the primary goal of an engineer.
                The engineer must build robust code.
            ";

            var commonStopWords = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "the", "a", "an", "and", "or", "but", "is", "are", "was",
                "of", "in", "on", "to", "not", "just", "about"
            };

            Console.WriteLine("--- Starting Analysis ---\n");

            var result = WordFrequencyAnalyzer.FindMostImportantWord(samplePassage, commonStopWords);

            if (result.Word != null)
            {
                Console.WriteLine($"Analysis complete.");
                Console.WriteLine($"Most mentioned relevant word: '{result.Word}'");
                Console.WriteLine($"Frequency count: {result.Count}");
            }
            else
            {
                Console.WriteLine("Could not determine a most frequent word.");
            }
            // Removed ReadKey for online compiler compatibility
            // Console.ReadKey();
        }
    }
}