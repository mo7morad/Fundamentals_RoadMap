using System;
using System.Collections.Generic;
using System.Linq;

class Graph
{
    // Enum for graph direction type: Directed or Undirected
    public enum enGraphDirectionType { Directed, unDirected }

    // Adjacency matrix to represent the graph
    private int[,] _adjacencyMatrix;

    // Dictionary to map vertex names to indices
    private Dictionary<string, int> _vertexDictionary;

    // Total number of vertices in the graph
    private int _numberOfVertices;

    // Specifies whether the graph is directed or undirected
    private enGraphDirectionType _GraphDirectionType;

    // Constructor to initialize the graph
    public Graph(List<string> vertices, enGraphDirectionType GraphDirectionType)
    {
        _GraphDirectionType = GraphDirectionType; // Set graph direction type
        _numberOfVertices = vertices.Count; // Total vertices
        _adjacencyMatrix = new int[_numberOfVertices, _numberOfVertices]; // Initialize adjacency matrix
        _vertexDictionary = new Dictionary<string, int>(); // Initialize vertex dictionary

        // Map each vertex name to an index
        for (int i = 0; i < vertices.Count; i++)
        {
            _vertexDictionary[vertices[i]] = i;
        }
    }

    // Adds an edge between two vertices with a given weight
    public void AddEdge(string source, string destination, int weight)
    {
        // Check if both vertices exist in the graph
        if (_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(destination))
        {
            int sourceIndex = _vertexDictionary[source]; // Get index of source vertex
            int destinationIndex = _vertexDictionary[destination]; // Get index of destination vertex

            // Add the edge to the adjacency matrix
            _adjacencyMatrix[sourceIndex, destinationIndex] = weight;

            // If the graph is undirected, add the edge in the opposite direction as well
            if (_GraphDirectionType == enGraphDirectionType.unDirected)
            {
                _adjacencyMatrix[destinationIndex, sourceIndex] = weight;
            }
        }
        else
        {
            // If either vertex is invalid, print an error message
            Console.WriteLine($"Invalid vertices: {source} or {destination}");
        }
    }

    // Displays the graph as an adjacency matrix
    public void DisplayGraph(string message)
    {
        Console.WriteLine("\n" + message + "\n"); // Print the message
        Console.Write("  "); // Spacer for formatting

        // Print column headers (vertex names)
        foreach (var vertex in _vertexDictionary.Keys)
        {
            Console.Write(vertex + " ");
        }
        Console.WriteLine();

        // Print each row of the adjacency matrix with row headers (vertex names)
        foreach (var source in _vertexDictionary)
        {
            Console.Write(source.Key + " "); // Print the row header (vertex name)
            for (int j = 0; j < _numberOfVertices; j++)
            {
                Console.Write(_adjacencyMatrix[source.Value, j] + " "); // Print the weight
            }
            Console.WriteLine();
        }
    }

    // Dijkstra's Algorithm using Priority Queue (Min-Heap)
    public void Dijkstra(string startVertex)
    {
        // Validate the starting vertex
        if (!_vertexDictionary.ContainsKey(startVertex))
        {
            Console.WriteLine("Invalid start vertex.");
            return;
        }

        int startIndex = _vertexDictionary[startVertex]; // Get the index of the starting vertex

        // Array to store the shortest distance from the start vertex to each vertex
        int[] distances = new int[_numberOfVertices];

        // Boolean array to track if a vertex has been visited
        bool[] visited = new bool[_numberOfVertices];

        // Array to store the predecessor of each vertex in the shortest path
        string[] predecessors = new string[_numberOfVertices];

        // Initialize distances to infinity and predecessors to null
        for (int i = 0; i < _numberOfVertices; i++)
        {
            distances[i] = int.MaxValue; // Distance set to "infinity"
            predecessors[i] = null; // No predecessor initially
        }
        distances[startIndex] = 0; // Distance to the starting vertex is 0

        // Priority queue (Min-Heap) to store vertices with their distances
        var priorityQueue = new SortedSet<(int distance, int vertexIndex)>(
            Comparer<(int distance, int vertexIndex)>.Create((x, y) =>
                x.distance == y.distance ? x.vertexIndex.CompareTo(y.vertexIndex) : x.distance.CompareTo(y.distance))
        );

        // Add the starting vertex to the priority queue
        priorityQueue.Add((0, startIndex));

        // Process all vertices in the priority queue
        while (priorityQueue.Count > 0)
        {
            // Extract the vertex with the smallest distance
            var (currentDistance, currentIndex) = priorityQueue.Min;
            priorityQueue.Remove(priorityQueue.Min);

            // Skip the vertex if it's already visited
            if (visited[currentIndex]) continue;
            visited[currentIndex] = true; // Mark the vertex as visited

            // Update the distances for all neighbors of the current vertex
            for (int neighbor = 0; neighbor < _numberOfVertices; neighbor++)
            {
                // Check if there is an edge and the neighbor is unvisited
                if (_adjacencyMatrix[currentIndex, neighbor] > 0 && !visited[neighbor])
                {
                    // Calculate the new distance to the neighbor
                    int newDistance = distances[currentIndex] + _adjacencyMatrix[currentIndex, neighbor];

                    // If the new distance is shorter, update it
                    if (newDistance < distances[neighbor])
                    {
                        priorityQueue.Remove((distances[neighbor], neighbor)); // Remove the old distance
                        distances[neighbor] = newDistance; // Update to the new distance
                        predecessors[neighbor] = GetVertexName(currentIndex); // Update the predecessor
                        priorityQueue.Add((newDistance, neighbor)); // Add the updated distance to the queue
                    }
                }
            }
        }

        // Print the shortest paths and their distances
        Console.WriteLine("\nShortest paths from vertex " + startVertex + ":");
        for (int i = 0; i < _numberOfVertices; i++)
        {
            Console.WriteLine($"{startVertex} -> {GetVertexName(i)}: Distance = {distances[i]}, Path = {GetPath(predecessors, i)}");
        }
    }

    // Helper method to get the name of a vertex by its index
    private string GetVertexName(int index)
    {
        return _vertexDictionary.FirstOrDefault(pair => pair.Value == index).Key;
    }

    // Helper method to reconstruct the shortest path from the source to a vertex
    private string GetPath(string[] predecessors, int currentIndex)
    {
        // Base case: If there is no predecessor, return the current vertex
        if (predecessors[currentIndex] == null)
            return GetVertexName(currentIndex);

        // Recursive case: Build the path using predecessors
        return GetPath(predecessors, _vertexDictionary[predecessors[currentIndex]]) + " -> " + GetVertexName(currentIndex);
    }

    // Main method to test the program
    public static void Main(string[] args)
    {
        // Define vertices
        List<string> vertices = new List<string> { "A", "B", "C", "D", "E" };

        // Create a directed graph
        Graph graph = new Graph(vertices, enGraphDirectionType.Directed);

        // Add edges with weights
        graph.AddEdge("A", "B", 4);
        graph.AddEdge("A", "C", 1);
        graph.AddEdge("C", "B", 2);
        graph.AddEdge("C", "D", 4);
        graph.AddEdge("B", "E", 4);
        graph.AddEdge("D", "E", 1);

        // Display the graph
        graph.DisplayGraph("Adjacency Matrix:");

        // Run Dijkstra's Algorithm from vertex "A"
        graph.Dijkstra("A");

        Console.ReadKey();
    }
}