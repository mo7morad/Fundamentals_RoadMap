using System;
using System.Collections.Generic;

class Graph
{
    // Enum to specify the type of graph: Directed or Undirected
    public enum enGraphDirectionType { Directed, unDirected }

    // Dictionary to store the adjacency list (vertex -> list of edges)
    private Dictionary<string, List<Tuple<string, int>>> _adjacencyList;

    // Dictionary to map string vertices to their neighbors
    private Dictionary<string, int> _vertexDictionary;

    // Number of vertices in the graph
    private int _numberOfVertices;

    // Variable to store the type of graph (Directed or Undirected)
    private enGraphDirectionType _GraphDirectionType = enGraphDirectionType.unDirected;

    // Constructor: Initializes the adjacency list and the vertex mapping
    public Graph(List<string> vertices, enGraphDirectionType GraphDirectionType)
    {
        // Set the type of graph (Directed or Undirected)
        _GraphDirectionType = GraphDirectionType;

        // Set the number of vertices
        _numberOfVertices = vertices.Count;

        // Initialize the adjacency list
        _adjacencyList = new Dictionary<string, List<Tuple<string, int>>>();

        // Initialize the dictionary to map vertex names to indices
        _vertexDictionary = new Dictionary<string, int>();

        // Populate the dictionary with vertices and initialize adjacency list entries
        for (int i = 0; i < vertices.Count; i++)
        {
            _vertexDictionary[vertices[i]] = i;
            _adjacencyList[vertices[i]] = new List<Tuple<string, int>>();  // Initialize an empty list for each vertex
        }
    }


    // Method to add a weighted edge between two vertices (source and destination)
    public void AddEdge(string source, string destination, int weight)
    {
        // Check if both source and destination vertices exist in the map
        if (_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(destination))
        {
            // Add the edge from source to destination with the given weight
            _adjacencyList[source].Add(new Tuple<string, int>(destination, weight));

            // If the graph is undirected, add the reverse edge (from destination to source)
            if (_GraphDirectionType == enGraphDirectionType.unDirected)
            {
                _adjacencyList[destination].Add(new Tuple<string, int>(source, weight));  // Add reverse edge
            }
        }
        else
        {
            // If either vertex is invalid, show an error message
            Console.WriteLine($"\n\nIgnored: Invalid vertices. {source} ==> {destination}\n\n");
        }
    }

    // Method to remove an edge between two vertices
    public void RemoveEdge(string source, string destination)
    {
        // Check if both source and destination vertices exist in the map
        if (_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(destination))
        {
            // Remove the edge from source to destination
            _adjacencyList[source].RemoveAll(edge => edge.Item1 == destination);

            // If the graph is undirected, also remove the reverse edge
            if (_GraphDirectionType == enGraphDirectionType.unDirected)
            {
                _adjacencyList[destination].RemoveAll(edge => edge.Item1 == source);
            }
        }
        else
        {
            // If either vertex is invalid, show an error message
            Console.WriteLine("Invalid vertices.");
        }
    }

    // Method to display the adjacency list (graph representation)
    public void DisplayGraph(string Message)
    {
        Console.WriteLine("\n" + Message + "\n");

        // Loop through each vertex in the adjacency list
        foreach (var vertex in _adjacencyList)
        {
            Console.Write(vertex.Key + " -> ");  // Print the vertex label

            // Print all edges for the vertex
            foreach (var edge in vertex.Value)
            {
                Console.Write($"{edge.Item1}({edge.Item2}) ");  // Print destination vertex and weight
            }
            Console.WriteLine();
        }
    }

    // Method to check if there's an edge between two vertices
    public bool IsEdge(string source, string destination)
    {
        // Check if both source and destination vertices exist in the map
        if (_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(destination))
        {
            // Check if an edge exists from source to destination
            foreach (var edge in _adjacencyList[source])
            {
                if (edge.Item1 == destination)
                {
                    return true;  // Edge found
                }
            }
        }

        return false;  // No edge found
    }

    // Method to get the indegree of a vertex (i.e., how many edges are connected to it (can reach it))
    public int GetInDegree(string vertex)
    {
        int inDegree = 0;  // Initialize the indegree count to zero

        // Check if the vertex exists in the map
        if (_vertexDictionary.ContainsKey(vertex))
        {
            // Loop through each vertex in the adjacency list
            foreach (var source in _adjacencyList)
            {
                // Loop through the edges of the current vertex
                foreach (var edge in source.Value)
                {
                    // If the destination of the edge is the given vertex, increment the indegree
                    if (edge.Item1 == vertex)
                    {
                        inDegree++;
                    }
                }
            }
        }

        return inDegree;  // Return the total indegree of the vertex
    }

    // Method to get the outdegree of a vertex (i.e., how many edges are outgoing from it)
    public int GetOutDegree(string vertex)
    {
        int outDegree = 0;  // Initialize the outdegree count to zero

        // Check if the vertex exists in the map
        if (_vertexDictionary.ContainsKey(vertex))
        {
            // The outdegree is simply the number of edges in the adjacency list of the vertex
            outDegree = _adjacencyList[vertex].Count;
        }

        return outDegree;  // Return the total outdegree of the vertex
    }

    // Main method: Entry point to test the graph implementation
    public static void Main(string[] args)
    {
        // Create a list of vertices with string labels
        List<string> vertices = new List<string> { "A", "B", "C", "D", "E" };

        // Example 1 in Slides: Undirected Graph
        Graph graph1 = new Graph(vertices, enGraphDirectionType.unDirected);

        // Add some edges with default weights=1 between vertices
        graph1.AddEdge("A", "B", 1);
        graph1.AddEdge("A", "C", 1);
        graph1.AddEdge("B", "D", 1);
        graph1.AddEdge("C", "D", 1);
        graph1.AddEdge("B", "E", 1);
        graph1.AddEdge("D", "E", 1);

        // Display the adjacency list to visualize the graph
        graph1.DisplayGraph("Adjacency List for Example1 (Undirected Graph):");

        Console.WriteLine("\n------------------------------\n");

        // Example 2 in Slides: Directed Graph
        Graph graph2 = new Graph(vertices, enGraphDirectionType.Directed);

        // Add some edges with weights between vertices
        graph2.AddEdge("A", "A", 1);
        graph2.AddEdge("A", "B", 1);
        graph2.AddEdge("A", "C", 1);
        graph2.AddEdge("B", "E", 1);
        graph2.AddEdge("D", "B", 1);
        graph2.AddEdge("D", "C", 1);
        graph2.AddEdge("D", "E", 1);

        // Display the adjacency list to visualize the graph
        graph2.DisplayGraph("Adjacency List for Example2 (Directed Graph):");

        // Get and display the indegree and outdegree of vertex 'D'
        Console.WriteLine("\nInDegree of vertex D: " + graph2.GetInDegree("D"));
        Console.WriteLine("\nOutDegree of vertex D: " + graph2.GetOutDegree("D"));

        Console.WriteLine("\n------------------------------\n");

        // Example 3 in Slides: Weighted Graph
        Graph graph3 = new Graph(vertices, enGraphDirectionType.unDirected);

        // Add some edges with weights between vertices
        graph3.AddEdge("A", "B", 5);
        graph3.AddEdge("A", "C", 3);
        graph3.AddEdge("B", "D", 12);
        graph3.AddEdge("C", "D", 10);
        graph3.AddEdge("B", "E", 2);
        graph3.AddEdge("D", "E", 7);

        // Display the adjacency list to visualize the graph
        graph3.DisplayGraph("Adjacency List for Example3 (Weighted Graph):");

        // Check if there is an edge between 'A' and 'B' and display the result
        Console.WriteLine("\nIs there an edge between A and B in Graph3? " + graph3.IsEdge("A", "B"));

        // Remove the edge between 'E' and 'D'
        graph3.RemoveEdge("E", "D");

        // Display the updated adjacency list after removing the edge
        graph3.DisplayGraph("After Removing Edge between E and D:");

        Console.ReadKey ();

    }
}
