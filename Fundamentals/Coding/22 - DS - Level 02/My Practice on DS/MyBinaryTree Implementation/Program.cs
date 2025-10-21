using System;
using System.Collections.Generic;

public class Tree<T>
{
    private class TreeNode
    {
        public T Value { get; set; }
        public TreeNode? LeftChild { get; private set; }
        public TreeNode? RightChild { get; private set; }

        public TreeNode(T value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }

        public void AddLeftChild(T value)
        {
            if (LeftChild != null)
                throw new InvalidOperationException("Left child already exists.");
            LeftChild = new TreeNode(value);
        }

        public void AddRightChild(T value)
        {
            if (RightChild != null)
                throw new InvalidOperationException("Right child already exists.");
            RightChild = new TreeNode(value);
        }

        public override string ToString()
        {
            return Value?.ToString() ?? "null";
        }
    }

    private TreeNode? Root { get; set; }

    public Tree()
    {
        Root = null;
    }

    public Tree(T value)
    {
        Root = new TreeNode(value);
    }

    public void AddRoot(T value)
    {
        if (Root != null)
            throw new InvalidOperationException("Root already exists.");
        Root = new TreeNode(value);
    }

    public void AddLeftChild(T parentValue, T value)
    {
        TreeNode? parent = FindNode(Root, parentValue);
        if (parent == null)
            throw new ArgumentException("Parent node not found.");
        parent.AddLeftChild(value);
    }

    public void AddRightChild(T parentValue, T value)
    {
        TreeNode? parent = FindNode(Root, parentValue);
        if (parent == null)
            throw new ArgumentException("Parent node not found.");
        parent.AddRightChild(value);
    }

    private TreeNode? FindNode(TreeNode? node, T value)
    {
        if (node == null)
            return null;
        if (EqualityComparer<T>.Default.Equals(node.Value, value))
            return node;
        TreeNode? leftResult = FindNode(node.LeftChild, value);
        if (leftResult != null)
            return leftResult;
        return FindNode(node.RightChild, value);
    }

    public IEnumerable<T> PreOrder()
    {
        foreach (var value in PreOrderTraversal(Root))
            yield return value;
    }

    private IEnumerable<T> PreOrderTraversal(TreeNode? node)
    {
        if (node == null)
            yield break;

        yield return node.Value; // yielding root first

        foreach (var value in PreOrderTraversal(node.LeftChild)) // then left child (cascading)
            yield return value;

        foreach (var value in PreOrderTraversal(node.RightChild)) // then right child (cascading)
            yield return value;
    }

    public IEnumerable<T> InOrder()
    {
        foreach (var value in InOrderTraversal(Root))
            yield return value;
    }

    private IEnumerable<T> InOrderTraversal(TreeNode? node)
    {
        if (node == null)
            yield break;

        foreach (var value in InOrderTraversal(node.LeftChild))
            yield return value;

        yield return node.Value;

        foreach (var value in InOrderTraversal(node.RightChild))
            yield return value;
    }

    public IEnumerable<T> PostOrder()
    {
        foreach (var value in PostOrderTraversal(Root))
            yield return value;
    }

    private IEnumerable<T> PostOrderTraversal(TreeNode? node)
    {
        if (node == null)
            yield break;

        foreach (var value in PostOrderTraversal(node.LeftChild))
            yield return value;

        foreach (var value in PostOrderTraversal(node.RightChild))
            yield return value;

        yield return node.Value;
    }

    public bool Contains(T value)
    {
        return FindNode(Root, value) != null;
    }

    public void PrintTree()
    {
        PrintTree(Root, 0);
    }

    private void PrintTree(TreeNode? node, int level)
    {
        if (node == null)
            return;
        // Indent based on level to show hierarchy
        Console.WriteLine(new string(' ', level * 2) + node.Value);
        PrintTree(node.LeftChild, level + 1);
        PrintTree(node.RightChild, level + 1);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a family tree with strings
        Tree<string> familyTree = new Tree<string>("Grandparent");
        familyTree.AddLeftChild("Grandparent", "Father");
        familyTree.AddRightChild("Grandparent", "Mother");
        familyTree.AddLeftChild("Father", "Kimmy");
        familyTree.AddRightChild("Father", "Chanel");
        familyTree.AddRightChild("Mother", "Kimmy");
        familyTree.AddLeftChild("Mother", "Chanel");


        Console.WriteLine("Family Tree (Hierarchical):");
        familyTree.PrintTree();

        Console.WriteLine("\nPre-Order Traversal: " + String.Join(", ", familyTree.PreOrder()));
        Console.WriteLine("In-Order Traversal: " + String.Join(", ", familyTree.InOrder()));
        Console.WriteLine("Post-Order Traversal: " + String.Join(", ", familyTree.PostOrder()));
        Console.WriteLine("Contains 'Child1': " + familyTree.Contains("Child1"));
        Console.WriteLine("Contains 'Grandchild': " + familyTree.Contains("Grandchild"));

        // Example with a Person class
        Tree<Person> personTree = new Tree<Person>(new Person("Grandparent", 70));
        personTree.AddLeftChild(new Person("Grandparent", 70), new Person("Father", 40));
        personTree.AddRightChild(new Person("Grandparent", 70), new Person("Mother", 38));
        personTree.AddLeftChild(new Person("Father", 40), new Person("Kimmy", 15));
        personTree.AddRightChild(new Person("Father", 40), new Person("Chanel", 18));
        personTree.AddLeftChild(new Person("Mother", 38), new Person("Kimmy", 15));
        personTree.AddRightChild(new Person("Mother", 38), new Person("Chanel", 18));

        Console.WriteLine("\nPerson Family Tree (Hierarchical):");
        Console.WriteLine(String.Join(", ", personTree.PostOrder()));
    }
}

// Person class for richer family tree
public class Person
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString() => $"{Name} ({Age})";

    // For FindNode to work with Person
    public override bool Equals(object? obj)
    {
        if (obj is Person other)
            return Name == other.Name && Age == other.Age;
        return false;
    }

    public override int GetHashCode() => HashCode.Combine(Name, Age);
}
