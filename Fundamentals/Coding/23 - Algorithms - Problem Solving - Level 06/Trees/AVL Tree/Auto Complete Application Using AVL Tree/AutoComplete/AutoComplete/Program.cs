using System;
using System.Collections.Generic;

class AVLNode
{
    public string Value { get; set; }
    public AVLNode Left { get; set; }
    public AVLNode Right { get; set; }
    public int Height { get; set; }

    public AVLNode(string value)
    {
        Value = value;
        Height = 1; // Initially, when a node is created, its height is set to 1.
    }
}

class AVLTree
{
    private AVLNode root;

    public void Insert(string value)
    {
        root = Insert(root, value);
    }

    private AVLNode Insert(AVLNode node, string value)
    {
        if (node == null)
            return new AVLNode(value);

        int compareResult = string.Compare(value, node.Value, StringComparison.OrdinalIgnoreCase);
        if (compareResult < 0)
            node.Left = Insert(node.Left, value);
        else if (compareResult > 0)
            node.Right = Insert(node.Right, value);
        else
            return node; // Duplicate values are not allowed

        UpdateHeight(node);
        return Balance(node);
    }

    private void UpdateHeight(AVLNode node)
    {
        node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));
    }

    private int Height(AVLNode node)
    {
        return node != null ? node.Height : 0;
    }

    private int GetBalanceFactor(AVLNode node)
    {
        return (node != null) ? Height(node.Left) - Height(node.Right) : 0;
    }

    private AVLNode Balance(AVLNode node)
    {

        //this function will balance the node.
        int balanceFactor = GetBalanceFactor(node);

        //decide which rotation to use and work accordengly.

        // RR - Right Rotation Case : Parent BF=-2 , Child BF for right child = -1 or 0
        if (balanceFactor < -1 && GetBalanceFactor(node.Right) <= 0)
            return LeftRotate(node);

        // LL Case: Parent BF=+2 , Child BF for left child = +1 or 0
        if (balanceFactor > 1 && GetBalanceFactor(node.Left) >= 0)
            return RightRotate(node);


        // LR - Left Rotation Case : Parent BF=+2 , Child BF for right child = -1 
        if (balanceFactor > 1 && GetBalanceFactor(node.Left) < 0)
        {
            //Step1: Perform left rotation
            node.Left = LeftRotate(node.Left);
            //Step2: Perfrom Rigth Rotation
            return RightRotate(node);
        }

        // RL - Right-Left Rotation Case : Parent BF=-2 , Child BF for right child = +1
        if (balanceFactor < -1 && GetBalanceFactor(node.Right) > 0)
        {
            //Step1: Perform right rotation
            node.Right = RightRotate(node.Right);
            //Step2: Perfrom Left Rotation
            return LeftRotate(node);
        }

        return node;
    }

    private AVLNode RightRotate(AVLNode OriginalRoot)
    {

        //Remember the algorithm
        // The left child of the node becomes the new root of the subtree.
        // The original root node becomes the right child of the new root.
        // If the new root already had a right child, it becomes the left child of the new right child(the original root).


        // The left child of the node becomes the new root of the subtree.
        AVLNode NewRoot = OriginalRoot.Left;

        //Save the Original Rigth Child Temperorly
        AVLNode OriginalRightChild = NewRoot.Right;


        //The original root node becomes the right child of the new root.
        NewRoot.Right = OriginalRoot;

        // The original root node becomes the right child of the new root.
        OriginalRoot.Left = OriginalRightChild;

        //After the rotation, the heights of the nodes may no longer be correct.
        //These two lines call a method UpdateHeight for
        //both OriginalRoot and NewRoot to recalculate their heights based on the heights of their children.
        //This is crucial for maintaining the balance of the AVL tree.
        UpdateHeight(OriginalRoot);
        UpdateHeight(NewRoot);

        //Finally, the node NewRoot, which is now the root of this subtree after the rotation, is returned.
        return NewRoot;
    }

    private AVLNode LeftRotate(AVLNode OriginalRoot)
    {

        //Remember the algorithm: go back to presentation.
        // The right child of the node becomes the new root of the subtree.
        // The original root node becomes the left child of the new root.
        // If the new root already had a left child, it becomes the right child of the new right child(the original root).

        //Right child of the node becomes the new root of the subtree
        AVLNode NewRoot = OriginalRoot.Right;
        //Save the Original Left Child Temperorly
        AVLNode OriginalLeftChild = NewRoot.Left;

        //Original root node becomes the left child of the new root.
        NewRoot.Left = OriginalRoot;

        //The new root  left child,it becomes the right child of the new right child(the original root)
        OriginalRoot.Right = OriginalLeftChild;

        //After the rotation, the heights of the nodes may no longer be correct.
        //These two lines call a method UpdateHeight for
        //both OriginalRoot and NewRoot to recalculate their heights based on the heights of their children.
        //This is crucial for maintaining the balance of the AVL tree.
        UpdateHeight(OriginalRoot);
        UpdateHeight(NewRoot);

        //Finally, the node NewRoot, which is now the root of this subtree after the rotation, is returned.
        return NewRoot;
    }

    public void Delete(string value)
    {
        root = DeleteNode(root, value);
    }

    private AVLNode DeleteNode(AVLNode node, string value)
    {
        if (node == null)
        {
            return node;
        }

        int compareResult = string.Compare(value, node.Value, StringComparison.OrdinalIgnoreCase);
        
        // Step 1: Perform standard BST delete
        if (compareResult < 0)
        {
            node.Left = DeleteNode(node.Left, value);
        }
        else if (compareResult > 0)
        {
            node.Right = DeleteNode(node.Right, value);
        }
        else
        {
            //If the node to be deleted has one child or no child,
            //simply remove the node and return the non - null child(if any).

            // Node with only one child or no child
            if (node.Left == null)
            {
                return node.Right;
            }
            else if (node.Right == null)
            {
                return node.Left;
            }

            //if the node to be deleted has two children,
            //find the smallest node in the right subtree (inorder successor), then
            //copy its value to the node to be deleted, and then recursively delete the inorder successor.

            // Node with two children: Get the inorder successor (smallest in the right subtree)
            AVLNode temp = MinValueNode(node.Right);

            // Copy the inorder successor's data to this node
            node.Value = temp.Value;

            // Delete the inorder successor
            node.Right = DeleteNode(node.Right, temp.Value);
        }

        // Step 2: Update height of the current node
        UpdateHeight(node);

        // Step 3: Rebalance the node if needed
        return Balance(node);
    }

    private AVLNode MinValueNode(AVLNode node)
    {
        // the minimum value is always located in the leftmost node.
        // This is because for any given node in a BST,
        // all values in the left subtree are less than the value of the node,
        // and all values in the right subtree are greater.
        AVLNode current = node;
        while (current.Left != null)
        {
            current = current.Left;
        }
        return current;
    }

    // Method to search for a value in the AVL Tree
    public bool Exists(string value)
    {
        return Exists(root, value);
    }

    // Private recursive helper function to perform the search and returns true if found
    private bool Exists(AVLNode node, string value)
    {
        if (node == null)
        {
            return false; // Value not found
        }

        int compareResult = string.Compare(value, node.Value, StringComparison.OrdinalIgnoreCase);

       


         if (compareResult < 0)
        {
            return Exists(node.Left, value); // Search in the left subtree
        }
        else if (compareResult > 0)
        {
            return Exists(node.Right, value); // Search in the right subtree
        }
        else
        {
            return true; // Value found
        }
    }


    // Method to search for a value in the AVL Tree and returns the node if found
    public AVLNode Search(string  value)
    {
        return Search(root, value);
    }

    // Private recursive helper function to perform the search
    private AVLNode Search(AVLNode node, string value)
    {
        if (node == null)
        {
            return null; // Value not found
        }

        int compareResult = string.Compare(value, node.Value, StringComparison.OrdinalIgnoreCase);

      if (compareResult < 0)
        {
            return Search(node.Left, value); // Search in the left subtree
        }
        else if (compareResult > 0)
        {
            return Search(node.Right, value); // Search in the right subtree
        }
        else
        {
            return node; // Value found, return the node
        }
    }

    public void PrintTree()
    {
        PrintTree(root, "", true);
    }

    private void PrintTree(AVLNode node, string indent, bool last)
    {
        if (node != null)
        {
            Console.Write(indent);
            if (last)
            {
                Console.Write("R----");
                indent += "     ";
            }
            else
            {
                Console.Write("L----");
                indent += "|    ";
            }
            Console.WriteLine(node.Value);
            PrintTree(node.Left, indent, false);
            PrintTree(node.Right, indent, true);
        }
    }

    //the auto complete code starts here.
    public IEnumerable<string> AutoComplete(string prefix)
    {
        List<string> results = new List<string>();
        AutoComplete(root, prefix, results);
        return results;
    }

    private void AutoComplete(AVLNode node, string prefix, List<string> results)
    {
        if (node != null)
        {
            if (node.Value.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            {
                results.Add(node.Value);
                AutoComplete(node.Left, prefix, results);
                AutoComplete(node.Right, prefix, results);
            }
            else
            {
                // If the current node's value does not start with the prefix,
                // the method decides which subtree to explore next based on alphabetical order:
                // If the prefix is lexicographically smaller than the node's value, it recurses into the left subtree, as any potential matches must be in the left due to the properties of the binary search tree (BST).
                // Conversely, if the prefix is larger, it searches the right subtree.

                if (string.Compare(prefix, node.Value, StringComparison.OrdinalIgnoreCase) < 0)
                    AutoComplete(node.Left, prefix, results);
                else
                    AutoComplete(node.Right, prefix, results);
            }
        }
    }

    // My solution using range search using lower and upper boundries.
    public IEnumerable<string> MyAutoComplete(string prefix)
    {
        var results = new List<string>();

        string lower = prefix;
        string upper = prefix + char.MaxValue;

        MyAutoComplete(root, lower, upper, results);
        return results;
    }

    private void MyAutoComplete(AVLNode node, string lower, string upper, List<string> results)
    {
        if (node == null)
            return;

        // if node value >= lower boundry
        if (string.Compare(node.Value, lower, StringComparison.OrdinalIgnoreCase) >= 0)
            MyAutoComplete(node.Left, lower, upper, results);

        // If node <= upper boundry
        if (string.Compare(node.Value, upper, StringComparison.OrdinalIgnoreCase) <= 0)
            MyAutoComplete(node.Right, lower, upper, results);

        // If node.Value is between lower and upper, it's a match
        if (string.Compare(node.Value, lower, StringComparison.OrdinalIgnoreCase) >= 0 &&
            string.Compare(node.Value, upper, StringComparison.OrdinalIgnoreCase) <= 0)
        {
            results.Add(node.Value);
        }
    }
    public IEnumerable<string> MyWhileAutoComplete(string prefix)
    {
        var results = new List<string>();
        if (root == null) return results;

        string lower = prefix;                     // minimum possible value
        string upper = prefix + char.MaxValue;     // maximum possible value

        Stack<AVLNode> stack = new Stack<AVLNode>();
        AVLNode current = root;

        while (stack.Count > 0 || current != null)
        {
            // Step 1: Go left if node value >= lower boundry
            while (current != null)
            {
                // Only go left if left may contain values >= lower bound
                if (string.Compare(current.Value, lower, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    stack.Push(current);
                    current = current.Left;
                }
                else
                {
                    // Left side is too small, skip it
                    current = current.Right;
                }
            }

            // Pop a node from the stack (like returning from recursion)
            current = stack.Pop();

            // Step 2: Process the node (check if it's inside our valid range)
            if (
                string.Compare(current.Value, lower, StringComparison.OrdinalIgnoreCase) >= 0 &&
                string.Compare(current.Value, upper, StringComparison.OrdinalIgnoreCase) <= 0
            )
            {
                results.Add(current.Value);
            }

            // Step 3: Go RIGHT *only if* values may still be <= upper bound
            if (string.Compare(current.Value, upper, StringComparison.OrdinalIgnoreCase) <= 0)
            {
                current = current.Right;
            }
            else
            {
                current = null;
            }
        }

        return results;
    }


}

class Program
{
    static void Main(string[] args)
    {
        AVLTree tree = new AVLTree();
        string[] words = { "Ahmad", "Mohammed", "Motasem", "Mohab", "Abla", "Abeer", "Abdullah", "Abbas", "Montaser", "Khalil","Khalid" };

        foreach (var word in words)
        {
            tree.Insert(word);
        }
        tree.PrintTree();

        Console.WriteLine("\nEnter a prefix to search:\n");
        string prefix = Console.ReadLine();
        // var completions = tree.AutoComplete(prefix);
        var completions = tree.MyAutoComplete(prefix);

        Console.WriteLine($"\nSuggestions for '{prefix}':\n");
        foreach (var completion in completions)
        {
            Console.WriteLine(completion);
        }

        Console.ReadKey(); // Wait for user to press a key before closing
    }
}
