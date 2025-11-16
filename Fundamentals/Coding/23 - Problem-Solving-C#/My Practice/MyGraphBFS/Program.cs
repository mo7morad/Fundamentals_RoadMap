using System;
using System.Collections.Generic;

namespace MyGraphBFS_DFS
{
    public class Graph<T>
    {
        private Dictionary<int, Node> nodeLookup = new Dictionary<int, Node>();
        private List<Node> Nodes = new List<Node>();

        public class Node
        {
            public int ID;
            public T Value;
            public List<Node> Adjacents = new List<Node>();

            public Node(int id, T value)
            {
                ID = id;
                Value = value;
            }
        }

        public void AddNode(int id, T value)
        {
            if (nodeLookup.ContainsKey(id))
                return;

            Node node = new Node(id, value);
            Nodes.Add(node);
            nodeLookup[id] = node;
        }

        public void AddEdge(int fromId, int toId)
        {
            Node? from = GetNode(fromId);
            Node? to = GetNode(toId);
            if (from != null && to != null)
                from.Adjacents.Add(to);
        }

        public Node? GetNode(int id)
        {
            return nodeLookup.TryGetValue(id, out Node? node) ? node : null;
        }

        public bool HasPathDFS(int startNodeId, int destinationId)
        {
            Node? start = GetNode(startNodeId);
            Node? dest = GetNode(destinationId);
            if (start == null || dest == null)
                return false;

            HashSet<int> visited = new HashSet<int>();
            return DFS(start, destinationId, visited);
        }

        private bool DFS(Node current, int destinationId, HashSet<int> visited)
        {
            if (current.ID == destinationId)
                return true;

            if (visited.Contains(current.ID))
                return false;

            visited.Add(current.ID);

            foreach (Node neighbor in current.Adjacents)
            {
                if (DFS(neighbor, destinationId, visited))
                    return true;
            }

            return false;
        }

        public bool HasPathBFS(int startNodeId, int destinationId)
        {
            Node? start = GetNode(startNodeId);
            Node? dest = GetNode(destinationId);

            if (start == null || dest == null)
                return false;

            if (startNodeId == destinationId)
                return true;

            HashSet<int> visited = new HashSet<int>();
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();

                if (current.ID == destinationId)
                    return true;

                if (visited.Contains(current.ID))
                    continue;

                visited.Add(current.ID);

                foreach (Node neighbor in current.Adjacents)
                    queue.Enqueue(neighbor);
            }

            return false;
        }

        // ---------------------------
        // Graph Visualizer
        // ---------------------------
        public void PrintGraph()
        {
            Console.WriteLine("=== GRAPH (Adjacency List) ===");
            foreach (var node in Nodes)
            {
                Console.Write($"Node {node.ID} (value={node.Value}) -> [");

                for (int i = 0; i < node.Adjacents.Count; i++)
                {
                    Console.Write(node.Adjacents[i].ID);
                    if (i < node.Adjacents.Count - 1)
                        Console.Write(", ");
                }

                Console.WriteLine("]");
            }
            Console.WriteLine("==============================");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Graph<string> company = new Graph<string>();

            // Top Level
            company.AddNode(1, "CEO");

            // Second Level
            company.AddNode(2, "CTO");
            company.AddNode(3, "HR Manager");

            // Third Level
            company.AddNode(4, "Senior Developer");
            company.AddNode(5, "Junior Developer");
            company.AddNode(6, "Recruitment Specialist");
            company.AddNode(7, "Talent Acquisition");

            // Edges (reporting structure)
            company.AddEdge(1, 2);   // CEO → CTO
            company.AddEdge(1, 3);   // CEO → HR Manager

            company.AddEdge(2, 4);   // CTO → Senior Dev
            company.AddEdge(2, 5);   // CTO → Junior Dev

            company.AddEdge(3, 6);   // HR → Recruitment Specialist
            company.AddEdge(3, 7);   // HR → Talent Acquisition

            company.PrintGraph();

            Console.WriteLine("DFS 1 → 3: " + company.HasPathDFS(1, 3));  // true
            Console.WriteLine("DFS 3 → 1: " + company.HasPathDFS(3, 1));  // true
            Console.WriteLine("DFS 2 → 1: " + company.HasPathDFS(2, 1));  // true

            Console.WriteLine();
            Console.WriteLine("BFS 1 → 3: " + company.HasPathBFS(1, 3));  // true
            Console.WriteLine("BFS 3 → 1: " + company.HasPathBFS(3, 1));  // true
        }
    }
}
