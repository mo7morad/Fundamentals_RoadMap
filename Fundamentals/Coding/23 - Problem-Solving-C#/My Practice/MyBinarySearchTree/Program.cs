using System;
using System.Collections.Generic;

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

        if(Root.Value == value)
            return true;
        while (current != null)
        {
          if (Comparer<T>.Default.Compare(value, current.Value) == 0)
              return true;
          else if (Comparer<T>.Default.Compare(value, current.Value) < 0)
              current = current.LeftChild;
          else
              current = current.RightChild;
        }
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

            // Print right child first (so it appears at the top)
            PrintTree(node.RightChild, space);

            // Print current node after space
            Console.WriteLine();
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.WriteLine(node.Value);

            // Print left child (so it appears below)
            PrintTree(node.LeftChild, space);
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
            Console.WriteLine($"\n\nSearch for {searchValue}: " + (found ?"Found" : "Not Found"));

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
