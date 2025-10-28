using System;

namespace BinarySearchTreeDemo
{
    public class BinarySearchTreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public BinarySearchTreeNode<T> Left { get; set; }
        public BinarySearchTreeNode<T> Right { get; set; }

        public BinarySearchTreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public BinarySearchTreeNode<T> Root { get; private set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(T value)
        {
            Root = Insert(Root, value);
        }

        private BinarySearchTreeNode<T> Insert(BinarySearchTreeNode<T> node, T value)
        {
            if (node == null)
            {
                return new BinarySearchTreeNode<T>(value);
            }
            else if (value.CompareTo(node.Value) < 0)
            {
                node.Left = Insert(node.Left, value);
            }
            else if (value.CompareTo(node.Value) > 0)
            {
                node.Right = Insert(node.Right, value);
            }

            return node;
        }

        public bool Search(T value)
        {
            return Search(Root, value) != null;
        }

        private BinarySearchTreeNode<T> Search(BinarySearchTreeNode<T> node, T value)
        {
            if (node == null || node.Value.Equals(value))
            {
                return node;
            }
            if (value.CompareTo(node.Value) < 0)
            {
                return Search(node.Left, value);
            }
            else
            {
                return Search(node.Right, value);
            }
        }

        // DELETE FUNCTION
        public void Delete(T value)
        {
            Root = DeleteNode(Root, value);
        }

        private BinarySearchTreeNode<T> DeleteNode(BinarySearchTreeNode<T> root, T value)
        {
            if (root == null)
                return null;

            // Traverse left or right
            if (value.CompareTo(root.Value) < 0)
            {
                root.Left = DeleteNode(root.Left, value);
            }
            else if (value.CompareTo(root.Value) > 0)
            {
                root.Right = DeleteNode(root.Right, value);
            }
            else
            {
                // Case 1: No child
                if (root.Left == null && root.Right == null)
                    return null;

                // Case 2: One child
                else if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                // Case 3: Two children
                else
                {
                    // Find inorder successor (smallest in right subtree)
                    var successor = FindMin(root.Right);
                    root.Value = successor.Value;
                    root.Right = DeleteNode(root.Right, successor.Value);
                }
            }

            return root;
        }

        private BinarySearchTreeNode<T> FindMin(BinarySearchTreeNode<T> node)
        {
            while (node.Left != null)
                node = node.Left;
            return node;
        }

        // Traversals
        public void InOrderTraversal()
        {
            InOrderTraversal(Root);
            Console.WriteLine();
        }

        private void InOrderTraversal(BinarySearchTreeNode<T> node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.Write(node.Value + " ");
                InOrderTraversal(node.Right);
            }
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversal(Root);
            Console.WriteLine();
        }

        private void PreOrderTraversal(BinarySearchTreeNode<T> node)
        {
            if (node != null)
            {
                Console.Write(node.Value + " ");
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(Root);
            Console.WriteLine();
        }

        private void PostOrderTraversal(BinarySearchTreeNode<T> node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.Write(node.Value + " ");
            }
        }

        // Print the tree visually
        public void PrintTree()
        {
            PrintTree(Root, 0);
        }

        private void PrintTree(BinarySearchTreeNode<T> root, int space)
        {
            int COUNT = 10;  // Distance between levels
            if (root == null)
                return;

            space += COUNT;
            PrintTree(root.Right, space);

            Console.WriteLine();
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.WriteLine(root.Value);

            PrintTree(root.Left, space);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInserting : 45, 15, 79, 90, 10, 55, 12, 20, 50\r\n");

            var bst = new BinarySearchTree<int>();
            bst.Insert(45);
            bst.Insert(15);
            bst.Insert(79);
            bst.Insert(90);
            bst.Insert(10);
            bst.Insert(55);
            bst.Insert(12);
            bst.Insert(20);
            bst.Insert(50);

            Console.WriteLine("Initial Tree:");
            bst.PrintTree();

            Console.WriteLine("\nDeleting 79 (node with one child)...");
            bst.Delete(79);
            bst.PrintTree();

            Console.WriteLine("\nDeleting 15 (node with two children)...");
            bst.Delete(15);
            bst.PrintTree();

            Console.WriteLine("\nDeleting 10 (leaf node)...");
            bst.Delete(10);
            bst.PrintTree();

            Console.WriteLine("\nInOrder Traversal After Deletions:");
            bst.InOrderTraversal();

            Console.ReadKey();
        }
    }
}
