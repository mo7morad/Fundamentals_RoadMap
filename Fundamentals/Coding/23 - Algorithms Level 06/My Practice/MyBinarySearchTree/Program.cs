using System;

namespace MyBinarySearchTree
{
    public class BinarySearchTreeNode<T>
    {
        public T Value { get; set; }
        public BinarySearchTreeNode<T>? LeftChild { get; set; }
        public BinarySearchTreeNode<T>? RightChild { get; set; }

        public BinarySearchTreeNode(T value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }
    }

    public class BinarySearchTree<T>
    {
        public BinarySearchTreeNode<T>? Root { get; private set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public BinarySearchTree(T value)
        {
            Root = new BinarySearchTreeNode<T>(value);
        }

        public void Insert(T value)
        {
            BinarySearchTreeNode<T> newNode = new BinarySearchTreeNode<T>(value);

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            BinarySearchTreeNode<T> current = Root;

            while (true)
            {
                if (Comparer<T>.Default.Compare(value, current.Value) < 0)
                {
                    if (current.LeftChild == null)
                    {
                        current.LeftChild = newNode;
                        break;
                    }
                    current = current.LeftChild;
                }
                else
                {
                    if (current.RightChild == null)
                    {
                        current.RightChild = newNode;
                        break;
                    }
                    current = current.RightChild;
                }
            }
        }

        public bool Search(T value)
        {
            BinarySearchTreeNode<T>? current = Root;

            if (Root == null)
                return false;

            while (current != null)
            {
                int comparison = Comparer<T>.Default.Compare(value, current.Value);
                if (comparison == 0)
                    return true;
                else if (comparison < 0)
                    current = current.LeftChild;
                else
                    current = current.RightChild;
            }

            return false;
        }

        public BinarySearchTreeNode<T>? GetNode(T value)
        {
            BinarySearchTreeNode<T>? current = Root;

            while (current != null)
            {
                int comparison = Comparer<T>.Default.Compare(value, current.Value);
                if (comparison == 0)
                    return current;
                else if (comparison < 0)
                    current = current.LeftChild;
                else
                    current = current.RightChild;
            }
            return null;
        }

        public void Delete(T value)
        {
            Root = DeleteNode(Root, value);
        }

        private BinarySearchTreeNode<T>? DeleteNode(BinarySearchTreeNode<T>? root, T value)
        {
            if (root == null)
                return null;

            // Navigate left or right
            if (Comparer<T>.Default.Compare(value, root.Value) < 0)
                root.LeftChild = DeleteNode(root.LeftChild, value);
            else if (Comparer<T>.Default.Compare(value, root.Value) > 0)
                root.RightChild = DeleteNode(root.RightChild, value);
            else
            {
                // Case 1: No child
                if (root.LeftChild == null && root.RightChild == null)
                    return null;
                // Case 2: One child
                else if (root.LeftChild == null)
                    return root.RightChild;
                else if (root.RightChild == null)
                    return root.LeftChild;
                // Case 3: Two children
                else
                {
                    var successorValue = FindMin(root.RightChild).Value;
                    root.Value = successorValue;
                    root.RightChild = DeleteNode(root.RightChild, successorValue);
                }
            }

            return root;
        }

        private BinarySearchTreeNode<T> FindMin(BinarySearchTreeNode<T> node)
        {
            while (node.LeftChild != null)
                node = node.LeftChild;
            return node;
        }

        public void PrintTree()
        {
            PrintTree(Root, 0);
        }

        private void PrintTree(BinarySearchTreeNode<T>? node, int space)
        {
            int COUNT = 8; // Adjust spacing between levels
            if (node == null)
                return;

            space += COUNT;

            PrintTree(node.LeftChild, space);

            Console.WriteLine();
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.WriteLine(node.Value);

            PrintTree(node.RightChild, space);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            int[] values = { 8, 4, 12, 2, 6, 10, 14, 1, 3, 5, 7, 9, 11, 13, 15 };
            foreach (int val in values)
                bst.Insert(val);

            Console.WriteLine("Binary Search Tree:");
            bst.PrintTree();

            int searchValue = 7;
            bool found = bst.Search(searchValue);
            Console.WriteLine($"\n\nSearch for {searchValue}: " + (found ? "Found" : "Not Found"));

            // Test Deletion
            Console.WriteLine("\nDeleting 12 (has two children):");
            bst.Delete(12);
            bst.PrintTree();

            Console.WriteLine("\nDeleting 1 (leaf node):");
            bst.Delete(1);
            bst.PrintTree();

            Console.WriteLine("\nDeleting 4 (one child):");
            bst.Delete(4);
            bst.PrintTree();

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}