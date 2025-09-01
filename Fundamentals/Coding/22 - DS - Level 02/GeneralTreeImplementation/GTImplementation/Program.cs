using System;
using System.Collections.Generic;

namespace GeneralTreeExample
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T value)
        {
            this.Value = value;
            Children = new List<TreeNode<T>>();
        }

        public void AddChild(TreeNode<T> child)
        {
            Children.Add(child);
        }
    }

    public class Tree<T>
    {
        public TreeNode<T> Root { get; private set; }

        public Tree(T rootValue)
        {
            Root = new TreeNode<T>(rootValue);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating the tree
            var CompanyTree = new Tree<string>("CEO");
            var Finance = new TreeNode<string>("CFO");
            var Tech = new TreeNode<string>("CTO");
            var Marketing = new TreeNode<string>("CMO");

            // Adding departments to the CEO node
            CompanyTree.Root.AddChild(Finance);
            CompanyTree.Root.AddChild(Tech);
            CompanyTree.Root.AddChild(Marketing);

            // Adding employees to departments
            Finance.AddChild(new TreeNode<string>("Accountant"));
            Tech.AddChild(new TreeNode<string>("Developer"));
            Tech.AddChild(new TreeNode<string>("UX Designer"));
            Marketing.AddChild(new TreeNode<string>("Social Media Manager"));

            // Printing the tree
            PrintTree(CompanyTree.Root);
            Console.ReadKey();

        }

        public static void PrintTree<T>(TreeNode<T> node, string indent = " ")
        {
            Console.WriteLine(indent + node.Value);
            foreach (var child in node.Children)
            {
                PrintTree(child, indent + "  ");
            }
        }
    }
}
