using System;
using System.Linq;
using System.Collections.Generic;

    namespace GreedyCoinChange
    {
        class Program
        {
            static (int, Queue<int>) MinChangeNotes(int amount, int[] denominations)
            {
                int BillNotesNumber = 0;
                Queue<int> notesUsed = new Queue<int>();
                // Sort denominations in descending order
                Array.Sort(denominations);
                Array.Reverse(denominations);

                foreach (var denom in denominations)
                {
                    while (amount >= denom)
                    {
                        amount -= denom;
                        BillNotesNumber++;
                        // adding a queue to hold the notes used to print them later
                        notesUsed.Enqueue(denom);
                    }
                }

                    return amount == 0 ? (BillNotesNumber, notesUsed) : (-1, notesUsed);
            }

            static void Main(string[] args)
            {
                int amount = 27;
                int[] denominations = new int[] { 100, 50, 20, 10, 5, 1 };

                  var result = MinChangeNotes(amount, denominations);
                if (result.Item1 != -1)
                {
                    Console.WriteLine($"Minimum number of notes for amount {amount} is: {result}");
                    Console.WriteLine("Denominations used:");
                    while (result.Item2.Count > 0)
                    {
                        Console.WriteLine(result.Item2.Dequeue());
                    }
                }
                else
                {
                    Console.WriteLine($"Cannot make exact change for amount {amount} with given denominations.");
                }
            }
        }
    }


// ============================================
                // Course Code
// ============================================

// using System;
// using System.Collections.Generic;


// class Program
// {
//     static void Main()
//     {
//         //// Define the coin denominations in an array.
//         //int[] coins = { 1, 5, 10, 20, 50, 100 };


//         // Define the coin denominations in a list.
//         List<int> coins = new List<int> { 1, 5, 10, 20, 50, 100 };


        
        
//         // Define the total amount for which change is needed.
//         int amount = 33;


//         // Call the MinCoins function to compute the minimum coins needed.
//         List<int> result = MinCoins(coins, amount);


//         // Output the coins used to make the total amount.
//         Console.WriteLine("Coins used to form total:");
//         short TotalCoins = 0;


//         foreach (var coin in result)
//         {
//             Console.WriteLine(coin);
//             TotalCoins++;
//         }
//         Console.WriteLine("\nTotal Given Coins = " + TotalCoins );
//         // Wait for a key press before closing the console window.
//         Console.ReadKey();
//     }


//     // Function to determine the minimum number of coins needed to make the given amount.
//     static List<int> MinCoins(List<int> coins, int amount)
//     {


//         // Sort the list in descending order.
//         coins.Sort((a, b) => b.CompareTo(a));


//         // List to store the result of the coins used.
//         List<int> result = new List<int>();


//         // Iterate over each coin denomination starting from the largest to the smallest.
//         foreach (int coin in coins)
//         {
//             // Keep using this coin denomination until it can no longer be used without exceeding the amount.
//             while (amount >= coin)
//             {
//                 // Reduce the amount by the denomination value.
//                 amount -= coin;
//                 // Add the coin to the result list.
//                 result.Add(coin);
//             }
//         }
//         // Return the list of coins that collectively sum up to the original amount.
//         return result;
//     }
// }
