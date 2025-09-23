using System;
using System.Collections;
using System.Collections.Generic;

class Graph
{
   public enum enGraphDirectionType { Directed, unDirected }


    // Adjacency matrix to store the weights of edges between vertices
    private int[,] _adjacencyMatrix;

    // Dictionary to map string vertices to integer indices for adjacency matrix
    private Dictionary<string, int> _vertexDictionary;
    Hashtable
    // Number of vertices in the graph
    private int _numberOfVertices;
    private enGraphDirectionType _GraphDirectionType= enGraphDirectionType.unDirected;


    // Constructor: Initializes the adjacency matrix and the vertex mapping
    public Graph(List<string> vertices, enGraphDirectionType GraphDirectionType)
    {
     
        _GraphDirectionType = GraphDirectionType;

        // Set the number of vertices
        _numberOfVertices = vertices.Count;

        // Initialize a 2D array (matrix) of size vertices x vertices
        _adjacencyMatrix = new int[_numberOfVertices, _numberOfVertices];

        // Initialize the dictionary to map vertex names to matrix indices
        _vertexDictionary = new Dictionary<string, int>();

        // Populate the dictionary with vertices (e.g., 'A' -> 0, 'B' -> 1, etc.)
        for (int i = 0; i < vertices.Count; i++)
        {
            _vertexDictionary[vertices[i]] = i;
        }
    }

    // Method to add a weighted edge between two vertices (source and destination)
    public void AddEdge(string source, string destination, int weight)
    {
        // Check if both source and destination vertices exist in the map
        if (_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(destination))
        {
            // Retrieve the indices for the source and destination vertices
            int sourceIndex = _vertexDictionary[source];
            int destinationIndex = _vertexDictionary[destination];

            // Set the matrix value to the weight for  [sourceIndex, destinationIndex] : one way
            _adjacencyMatrix[sourceIndex, destinationIndex] = weight;

            //Set the matrix value to the weight for  [destinationIndex,sourceIndex ] : Two ways incase of undirected graph
            if (_GraphDirectionType==enGraphDirectionType.unDirected)
            {
                _adjacencyMatrix[destinationIndex, sourceIndex] = weight;  // For undirected graph
            }
           
        }
        else
        {
            // If either vertex is invalid, show an error message
            Console.WriteLine($"\n\nIgnored:Invalid vertices.{source} ==> {destination}\n\n");
        }
    }

    // Method to remove an edge between two vertices
    public void RemoveEdge(string source, string destination)
    {
        // Check if both source and destination vertices exist in the map
        if (_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(destination))
        {
            // Retrieve the indices for the source and destination vertices
            int sourceIndex = _vertexDictionary[source];
            int destinationIndex = _vertexDictionary[destination];

            // Set the matrix value to 0 for both [sourceIndex, destinationIndex] and [destinationIndex, sourceIndex]
            _adjacencyMatrix[sourceIndex, destinationIndex] = 0;
            _adjacencyMatrix[destinationIndex, sourceIndex] = 0;  // For undirected graph
        }
        else
        {
            // If either vertex is invalid, show an error message
            Console.WriteLine("Invalid vertices.");
        }
    }

    // Method to display the adjacency matrix (graph representation) with string labels
    public void DisplayGraph(string Message)
    {
        Console.WriteLine("\n"+ Message +"\n");

        // Print the header row (vertex labels)
        Console.Write("  ");
        foreach (var vertex in _vertexDictionary.Keys)
        {
            Console.Write(vertex + " ");
        }
        Console.WriteLine();

        // Loop through the rows (vertices)
        foreach (var source in _vertexDictionary)
        {
            // Print the row label (vertex name)
            Console.Write(source.Key + " ");

            // Loop through the columns (vertices)
            for (int j = 0; j < _numberOfVertices; j++)
            {
                // Print the value at _adjacencyMatrix[source.Value, j]
                Console.Write(_adjacencyMatrix[source.Value, j] + " ");
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
            int sourceIndex = _vertexDictionary[source];
            int destinationIndex = _vertexDictionary[destination];

            //if weight >0 this means there is an edge between two verticies.
            return _adjacencyMatrix[sourceIndex, destinationIndex] > 0;
        }

        return false;
    }

    // Method to get the Indegree of a vertex (i.e., how many edges are connected to it (can reach it))
    public int GetInDegree(string vertex)
    {
        int degree = 0; // Initialize the degree count to zero

        // Check if the vertex exists in the map
        if (_vertexDictionary.ContainsKey(vertex))
        {
            int vertexIndex = _vertexDictionary[vertex];

            // Loop through all possible connections (columns) for the given vertex (row)
            for (int i = 0; i < _numberOfVertices; i++)
            {
                // If there's an edge (i.e., weight is greater than 0), increment the degree count
                if (_adjacencyMatrix[i, vertexIndex] > 0)
                    degree++;
            }
        }

        return degree;
    }

    // Method to get the Outdegree of a vertex (i.e., how many edges out of it and can go to)
    public int GetOutDegree(string vertex)
    {
        int degree = 0; // Initialize the degree count to zero

        // Check if the vertex exists in the map
        if (_vertexDictionary.ContainsKey(vertex))
        {
            int vertexIndex = _vertexDictionary[vertex];

            // Loop through all possible connections (columns) for the given vertex (row)
            for (int i = 0; i < _numberOfVertices; i++)
            {
                // If there's an edge (i.e., weight is greater than 0), increment the degree count
                if (_adjacencyMatrix[vertexIndex, i] > 0)
                    degree++;
            }
        }

        return degree;
    }

  
    // Main method: Entry point to test the graph implementation
    public static void Main(string[] args)
    {
        // Create a list of vertices with string labels
        List<string> vertices = new List<string> { "A", "B", "C", "D","E" };


        //Example 1 in Slides: Undirected Graph
        // Create a new graph object with the specified vertices
        Graph graph1 = new Graph(vertices, enGraphDirectionType.unDirected);

        // Add some edges with default weights=1 between vertices
        graph1.AddEdge("A", "B", 1);  
        graph1.AddEdge("A", "C", 1);  
        graph1.AddEdge("B", "D", 1);  
        graph1.AddEdge("C", "D", 1);  
        graph1.AddEdge("B", "E", 1);  
        graph1.AddEdge("D", "E", 1);

       

        // Display the adjacency matrix with weights to visualize the graph
        graph1.DisplayGraph("Adjacency Matrix for Example1 (Undirected Graph):");

        Console.WriteLine("\n------------------------------\n");

        //Example 2 in Slides: Directed Graph
        // Create a new graph object with the specified vertices
        Graph graph2 = new Graph(vertices, enGraphDirectionType.Directed);

        // Add some edges with weights between vertices
        graph2.AddEdge("A", "A", 1);
        graph2.AddEdge("A", "B", 1);
        graph2.AddEdge("A", "C", 1);
        graph2.AddEdge("B", "E", 1);
        graph2.AddEdge("D", "B", 1);
        graph2.AddEdge("D", "C", 1);
        graph2.AddEdge("D", "E", 1);

        // Display the adjacency matrix with weights to visualize the graph
        graph2.DisplayGraph("Adjacency Matrix for Example2 (Directed Graph):");

       
        // Get and display the Indegree (number of edges) of vertex 'D'
        Console.WriteLine("\nInDegree of vertex D: " + graph2.GetInDegree("D"));

        // Get and display the Outdegree (number of edges) of vertex 'D'
        Console.WriteLine("\nOutDegree of vertex D: " + graph2.GetOutDegree("D"));
       
        Console.WriteLine("\n------------------------------\n");

        //Example 3 in Slides: Weighted Graph
        // Create a new graph object with the specified vertices
        Graph graph3 = new Graph(vertices, enGraphDirectionType.unDirected);

        // Add some edges with weights between vertices
        graph3.AddEdge("A", "B", 5);
        graph3.AddEdge("A", "C", 3);
        graph3.AddEdge("B", "D", 12);
        graph3.AddEdge("C", "D", 10);
        graph3.AddEdge("B", "E", 2);
        graph3.AddEdge("D", "E", 7);

        // Display the adjacency matrix with weights to visualize the graph
        graph3.DisplayGraph("Adjacency Matrix for Example3 (Weighted Graph):");


        // Check if there is an edge between 'A' and 'B' and display the result
        Console.WriteLine("\nIs there an edge between A and B in Graph3? " + graph3.IsEdge("A", "B"));


        // Check if there is an edge between 'A' and 'B' and display the result
        Console.WriteLine("\nIs there an edge between B and C in Graph3? " + graph3.IsEdge("B", "C"));


        // Check if there is an edge between 'A' and 'A' and display the result
        Console.WriteLine("\nIs there an edge between E and D in Graph3? " + graph3.IsEdge("E", "D"));

        // Check if there is an edge between 'A' and 'A' and display the result
        Console.WriteLine("\nIs there an edge between A and A in Graph3? " + graph3.IsEdge("A", "A"));


        // Get and display the Indegree (number of edges) of vertex 'A'
        Console.WriteLine("\nInDegree of vertex A: " + graph3.GetInDegree("A"));

        // Get and display the Indegree (number of edges) of vertex 'A'
        Console.WriteLine("\nOutDegree of vertex A: " + graph3.GetOutDegree("A"));

        Console.WriteLine("\n------------------------------\n");


        Console.WriteLine("\nRemoveing Edge between E and D:");
        // Remove the edge between 'E' and 'D'
        graph3.RemoveEdge("E", "D");

        // Display the updated adjacency matrix after removing the edge
        graph3.DisplayGraph("After Removeing Edge between E and D:");


        // Check if there is an edge between 'A' and 'A' and display the result
        Console.WriteLine("\nIs there an edge between E and D in Graph3? " + graph3.IsEdge("E", "D"));

      
        Console.ReadKey();





        int[,] myAdjMatrix = new int[5,5];
        
    }
}
