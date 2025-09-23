using System;
using System.Collections.Generic;
using System.Xml.Linq;

public class MinHeap
{
    private List<int> heap = new List<int>();

    // This method inserts a new element into the heap while maintaining the Min-Heap property.
    public void Insert(int value)
    {
        // Step 1: Add the new element to the end of the heap.
        heap.Add(value);

        // Step 2: Restore the heap property by calling HeapifyUp on the last element.
        // Pass the index of the newly added element (heap.Count - 1) to HeapifyUp.
        HeapifyUp(heap.Count - 1);
    }

    // This method restores the heap property by moving the element at the given index up the heap
    // until it's in the correct position for a Min-Heap.
    private void HeapifyUp(int index)
    {

        /* Used by Insert to ensure the newly added element is correctly positioned:

         Starts at the index of the newly added element.
         If the element is smaller than its parent, it swaps with the parent 
         and continues moving up until the Min - Heap property is satisfied. 

         To get the Parent of index i: (i - 1) / 2

         */

        while (index > 0)
        {

            // Calculate the parent's index for the current node
            int parentIndex = (index - 1) / 2;

            // If the current element is greater than or equal to its parent,
            // the heap property is satisfied, so we can stop
            if (heap[index] >= heap[parentIndex]) break;

            // is a shorthand way in C# to swap the values of heap[index] and heap[parentIndex]. It’s known as tuple assignment or tuple swap,
            // where the values on the left side are swapped with the values on the right side in a single, concise statement.
            //swaps with the parent
            (heap[index], heap[parentIndex]) = (heap[parentIndex], heap[index]);

            // is equivalent to the following code:
            /* 
                 int temp = heap[index];
                 heap[index] = heap[parentIndex];
                 heap[parentIndex] = temp;

             */

            // Update the index to the parent's index to continue checking up the tree
            index = parentIndex;
        }
    }



    // This method returns the minimum element in the heap without removing it.
    public int Peek()
    {
        // Check if the heap is empty
        if (heap.Count == 0)
        {
            // If the heap is empty, throw an exception since there's no element to return
            throw new InvalidOperationException("Heap is empty.");
        }

        // Return the element at the root of the heap, which is the minimum element in a Min-Heap
        return heap[0];
    }


    // Display the elements in the heap
    public void DisplayHeap()
    {
        Console.WriteLine("\nHeap Elements: ");
        foreach (int value in heap)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        MinHeap minHeap = new MinHeap();

        Console.WriteLine("Inserting elements into the Min-Heap...\n");
        minHeap.Insert(10);
        minHeap.Insert(4);
        minHeap.Insert(15);
        minHeap.Insert(2);
        minHeap.Insert(8);

        // Display the heap after insertion
        minHeap.DisplayHeap();

        Console.WriteLine("\nPeek Minimum Element: Minimum Element is: " + minHeap.Peek());
      
        // Display the heap after insertion, note that the minimum value is not deleted.
        minHeap.DisplayHeap();

        Console.ReadKey();

    }
}
