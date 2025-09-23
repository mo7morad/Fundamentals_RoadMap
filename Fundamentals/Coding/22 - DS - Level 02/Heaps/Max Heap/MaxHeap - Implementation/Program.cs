using System;
using System.Collections.Generic;

public class MaxHeap
{
    private List<int> heap = new List<int>();

    // This method inserts a new element into the heap while maintaining the Max-Heap property.
    public void Insert(int value)
    {
        // Step 1: Add the new element to the end of the heap.
        heap.Add(value);

        // Step 2: Restore the heap property by calling HeapifyUp on the last element.
        // Pass the index of the newly added element (heap.Count - 1) to HeapifyUp.
        HeapifyUp(heap.Count - 1);
    }

    // This method restores the heap property by moving the element at the given index up the heap
    // until it's in the correct position for a Max-Heap.
    private void HeapifyUp(int index)
    {
        // Used by Insert to ensure the newly added element is correctly positioned in a Max-Heap:
        // If the element is greater than its parent, it swaps with the parent and continues moving up
        // until the Max-Heap property is satisfied.

        while (index > 0)
        {
            // Calculate the parent's index for the current node
            int parentIndex = (index - 1) / 2;

            // If the current element is less than or equal to its parent,
            // the heap property is satisfied, so we can stop
            if (heap[index] <= heap[parentIndex]) break;

            // Swap if the current element is greater than the parent
            (heap[index], heap[parentIndex]) = (heap[parentIndex], heap[index]);

            // Update the index to the parent's index to continue checking up the tree
            index = parentIndex;
        }
    }

    // This method returns the maximum element in the heap without removing it.
    public int Peek()
    {
        // Check if the heap is empty
        if (heap.Count == 0)
        {
            throw new InvalidOperationException("Heap is empty.");
        }

        // Return the element at the root of the heap, which is the maximum element in a Max-Heap
        return heap[0];
    }

    // This method removes and returns the maximum element from the heap, maintaining the Max-Heap property.
    public int ExtractMax()
    {
        // Check if the heap is empty
        if (heap.Count == 0)
        {
            throw new InvalidOperationException("Heap is empty.");
        }

        // Step 1: Store the maximum value (root element) to return later
        int maxValue = heap[0];

        // Step 2: Move the last element in the heap to the root position
        heap[0] = heap[heap.Count - 1];

        // Step 3: Remove the last element from the heap, as it has been moved to the root
        heap.RemoveAt(heap.Count - 1);

        // Step 4: Restore the heap property by calling HeapifyDown on the root
        HeapifyDown(0);

        // Return the maximum value that was originally at the root
        return maxValue;
    }

    // This helper method restores the heap property by moving an element down the heap
    // if it is smaller than its children, ensuring the Max-Heap structure is maintained.
    private void HeapifyDown(int index)
    {
        // Starts at the root and compares it to its children.
        // Swaps with the larger child if the heap property is violated
        // and continues moving down until the property is restored.

        while (index < heap.Count)
        {
            // Calculate the indices of the left and right children of the current node
            int leftChildIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;

            // Start by assuming the current node is the largest
            int largestIndex = index;

            // Check if the left child exists and is greater than the current largest element
            if (leftChildIndex < heap.Count && heap[leftChildIndex] > heap[largestIndex])
                largestIndex = leftChildIndex;

            // Check if the right child exists and is greater than the current largest element
            if (rightChildIndex < heap.Count && heap[rightChildIndex] > heap[largestIndex])
                largestIndex = rightChildIndex;

            // If the current node is already the largest, stop the process
            if (largestIndex == index) break;

            // Swap the current element with the larger child to restore the Max-Heap property
            (heap[index], heap[largestIndex]) = (heap[largestIndex], heap[index]);

            // Update the index to continue checking down the tree
            index = largestIndex;
        }
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
        MaxHeap maxHeap = new MaxHeap();

        Console.WriteLine("Inserting elements into the Max-Heap...\n");
        maxHeap.Insert(10);
        maxHeap.Insert(4);
        maxHeap.Insert(15);
        maxHeap.Insert(2);
        maxHeap.Insert(8);

        // Display the heap after insertion
        maxHeap.DisplayHeap();

        Console.WriteLine("\nPeek Maximum Element: Maximum Element is: " + maxHeap.Peek());

        // Display the heap after insertion, note that the maximum value is not deleted.
        maxHeap.DisplayHeap();

        // Extract elements based on priority
        Console.WriteLine("\nExtracting elements from the Max-Heap:");
        Console.WriteLine("Extracted Maximum: " + maxHeap.ExtractMax());
        maxHeap.DisplayHeap();

        Console.WriteLine("\nExtracted Maximum: " + maxHeap.ExtractMax());
        maxHeap.DisplayHeap();

        Console.ReadKey();
    }
}
