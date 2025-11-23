using System;

class RedBlackTree
{
    private Node root;

    // Node definition for the Red-Black Tree
    // Make the Node class public to allow accessibility
    public class Node
    {
        public int Value;
        public Node Left, Right, Parent;
        public bool IsRed = true; // New nodes are red by default

        public Node(int value)
        {
            Value = value;
        }
    }

    // Public method to insert a value into the tree
    public void Insert(int newValue)
    {
        Node newNode = new Node(newValue);
        // Handle the special case when the tree is empty
        if (root == null)
        {
            root = newNode;
            root.IsRed = false; // The root must be black
            return;
        }

        // Standard Binary Search Tree insertion
        Node current = root;
        Node parent = null;
        while (current != null)
        {
            parent = current;
            if (newValue < current.Value)
                current = current.Left;
            else
                current = current.Right;
        }

        // Set the parent of the new node
        newNode.Parent = parent;
        if (newValue < parent.Value)
            parent.Left = newNode;
        else
            parent.Right = newNode;

        // Restore Red-Black properties that might have been violated during insertion
        FixInsert(newNode);
    }

    // Method to restore Red-Black properties after insertion
    private void FixInsert(Node node)
    {
        Node parent = null;
        Node grandparent = null;

        // Fix the tree as long as the node is not the root and both the node and its parent are red
        while ((node != root) && (node.IsRed) && (node.Parent.IsRed))
        {
            parent = node.Parent;
            grandparent = parent.Parent;

            // Parent node is a left child
            if (parent == grandparent.Left)
            {
                Node uncle = grandparent.Right; // Uncle node is the right child

                // Case 1: The uncle is red (recoloring)
                if (uncle != null && uncle.IsRed)
                {
                    grandparent.IsRed = true; // Recolor grandparent to red
                    parent.IsRed = false; // Recolor parent to black
                    uncle.IsRed = false; // Recolor uncle to black
                    node = grandparent; // Move up the tree to continue fixing
                }
                else
                {
                    // Case 2: Node is the right child of its parent (Triangle Case)
                    if (node == parent.Right)
                    {
                        // Perform left rotation on parent to transform the triangle case into the line case
                        RotateLeft(parent);
                        node = parent;
                        parent = node.Parent;
                    }

                    // Case 3: Node is now the left child of its parent (Line Case)
                    // Perform right rotation on grandparent to balance the tree
                    RotateRight(grandparent);
                    // Swap colors of parent and grandparent to maintain Red-Black properties
                    bool tmp = parent.IsRed;
                    parent.IsRed = grandparent.IsRed;
                    grandparent.IsRed = tmp;
                    node = parent;
                }
            }
            else // Parent node is a right child
            {
                Node uncle = grandparent.Left; // Uncle node is the left child

                // Case 1: The uncle is red (recoloring)
                if (uncle != null && uncle.IsRed)
                {
                    grandparent.IsRed = true; // Recolor grandparent to red
                    parent.IsRed = false; // Recolor parent to black
                    uncle.IsRed = false; // Recolor uncle to black
                    node = grandparent; // Move up the tree to continue fixing
                }
                else
                {
                    // Case 2: Node is the left child of its parent (Triangle Case)
                    if (node == parent.Left)
                    {
                        // Perform right rotation on parent to transform the triangle case into the line case
                        RotateRight(parent);
                        node = parent;
                        parent = node.Parent;
                    }

                    // Case 3: Node is now the right child of its parent (Line Case)
                    // Perform left rotation on grandparent to balance the tree
                    RotateLeft(grandparent);
                    // Swap colors of parent and grandparent to maintain Red-Black properties
                    bool tmp = parent.IsRed;
                    parent.IsRed = grandparent.IsRed;
                    grandparent.IsRed = tmp;
                    node = parent;
                }
            }
        }

        root.IsRed = false; // Ensure the root remains black
    }

    // Rotate left pivots around the given node making the right child the parent of the pivoted node
    private void RotateLeft(Node node)
    {
        Node right = node.Right; // Right child becomes the new root of the subtree
        node.Right = right.Left; // Move the left subtree of right to the right subtree of node
        if (node.Right != null)
            node.Right.Parent = node; // Set parent of the new right child

        right.Parent = node.Parent; // Connect new root with the grandparent

        if (node.Parent == null)
            root = right; // The right child becomes new root of the tree
        else if (node == node.Parent.Left)
            node.Parent.Left = right; // Set right child to left child of parent
        else
            node.Parent.Right = right; // Set right child to right child of parent

        right.Left = node; // Original node becomes the left child of its right child
        node.Parent = right; // Update parent of the original node
    }

    // Rotate right pivots around the given node making the left child the parent of the pivoted node
    private void RotateRight(Node node)
    {
        Node left = node.Left; // Left child becomes the new root of the subtree
        node.Left = left.Right; // Move the right subtree of left to the left subtree of node
        if (node.Left != null)
            node.Left.Parent = node; // Set parent of the new left child

        left.Parent = node.Parent; // Connect new root with the grandparent

        if (node.Parent == null)
            root = left; // The left child becomes new root of the tree
        else if (node == node.Parent.Right)
            node.Parent.Right = left; // Set left child to right child of parent
        else
            node.Parent.Left = left; // Set left child to left child of parent

        left.Right = node; // Original node becomes the right child of its left child
        node.Parent = left; // Update parent of the original node
    }

    // Public method to print the tree
    public void PrintTree()
    {
        PrintHelper(root, "", true);
    }

    // Helper method to print the tree
    private void PrintHelper(Node node, string indent, bool last)
    {
        if (node != null)
        {
            Console.Write(indent);
            if (last)
            {
                Console.Write("R----");
                indent += "   ";
            }
            else
            {
                Console.Write("L----");
                indent += "|  ";
            }
            var color = node.IsRed ? "RED" : "BLK";
            Console.WriteLine(node.Value + "(" + color + ")");
            PrintHelper(node.Left, indent, false);
            PrintHelper(node.Right, indent, true);
        }
    }

    // Find a node with a specific value
    private Node FindNode(Node SearchInNode, int value)
    {
        if (SearchInNode == null || value == SearchInNode.Value)
            return SearchInNode; // Return the node if found, or null if not found

        if (value < SearchInNode.Value)
            return FindNode(SearchInNode.Left, value); // Search in the left subtree
        else
            return FindNode(SearchInNode.Right, value); // Search in the right subtree
    }

    // Public method to search for a value in the tree and return the node
    public Node Find(int value)
    {
        return FindNode(root, value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        RedBlackTree rbTree = new RedBlackTree();

        // Test values to be inserted into the tree
        int[] values = { 10, 20, 30, 15, 25, 35, 5, 19 };
        foreach (var value in values)
        {
          //  Console.WriteLine($"Inserting {value} to the tree\n");
            rbTree.Insert(value);
           // rbTree.PrintTree();
           // Console.WriteLine("\n--------------------------------\n");
        }
        rbTree.PrintTree();
        Console.WriteLine("\n--------------------------------\n");

        // Search for a value in the tree
        int searchValue = 15;
        RedBlackTree.Node foundNode = rbTree.Find(searchValue);
        if (foundNode != null)
        {
            Console.WriteLine($"Node with value {searchValue} found with color {(foundNode.IsRed ? "RED" : "BLACK")}");
        }
        else
        {
            Console.WriteLine($"Node with value {searchValue} not found");
        }

        searchValue = 100;
        foundNode = rbTree.Find(searchValue);
        if (foundNode != null)
        {
            Console.WriteLine($"Node with value {searchValue} found with color {(foundNode.IsRed ? "RED" : "BLACK")}");
        }
        else
        {
            Console.WriteLine($"Node with value {searchValue} not found");
        }

        Console.ReadKey();
    }
}
