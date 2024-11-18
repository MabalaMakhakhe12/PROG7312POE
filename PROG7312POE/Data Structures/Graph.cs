using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROG7312POE
{
    public class Graph<T>
    {
        private Dictionary<T, List<T>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<T, List<T>>();
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Adds a vertex to the graph.
        /// </summary>
        public void AddVertex(T vertex)
        {
            if (!adjacencyList.ContainsKey(vertex))
            {
                adjacencyList[vertex] = new List<T>();
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Adds an edge between two vertices in the graph.
        /// </summary>
        public void AddEdge(T vertex1, T vertex2)
        {
            if (adjacencyList.ContainsKey(vertex1) && adjacencyList.ContainsKey(vertex2))
            {
                adjacencyList[vertex1].Add(vertex2);
                adjacencyList[vertex2].Add(vertex1);
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Checks if the graph contains a specific vertex.
        /// </summary>
        public bool ContainsVertex(T vertex)
        {
            return adjacencyList.ContainsKey(vertex);
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Checks if there is an edge between two vertices in the graph.
        /// </summary>
        public bool ContainsEdge(T vertex1, T vertex2)
        {
            return adjacencyList.ContainsKey(vertex1) && adjacencyList[vertex1].Contains(vertex2);
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Gets the neighbors of a specific vertex.
        /// </summary>
        public IEnumerable<T> GetNeighbors(T vertex)
        {
            if (adjacencyList.ContainsKey(vertex))
            {
                return adjacencyList[vertex];
            }
            return new List<T>();
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Removes a vertex from the graph.
        /// </summary>
        public void RemoveVertex(T vertex)
        {
            if (adjacencyList.ContainsKey(vertex))
            {
                adjacencyList.Remove(vertex);
                foreach (var key in adjacencyList.Keys)
                {
                    adjacencyList[key].Remove(vertex);
                }
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Removes an edge between two vertices in the graph.
        /// </summary>
        public void RemoveEdge(T vertex1, T vertex2)
        {
            if (adjacencyList.ContainsKey(vertex1) && adjacencyList.ContainsKey(vertex2))
            {
                adjacencyList[vertex1].Remove(vertex2);
                adjacencyList[vertex2].Remove(vertex1);
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Gets all vertices in the graph.
        /// </summary>
        public IEnumerable<T> GetVertices()
        {
            return adjacencyList.Keys;
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Performs a depth-first search (DFS) starting from a specific vertex.
        /// </summary>
        public void DFS(T start, Action<T> action)
        {
            var visited = new HashSet<T>();
            DFSRecursive(start, visited, action);
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Helper method for performing a depth-first search (DFS).
        /// </summary>
        private void DFSRecursive(T vertex, HashSet<T> visited, Action<T> action)
        {
            try
            {
                if (visited.Contains(vertex))
                    return;

                visited.Add(vertex);
                action(vertex);

                foreach (var neighbor in adjacencyList[vertex])
                {
                    DFSRecursive(neighbor, visited, action);
                }
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show($"Key not found: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"Argument is null: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Performs a breadth-first search (BFS) starting from a specific vertex.
        /// </summary>
        public void BFS(T start, Action<T> action)
        {
            try
            {
                var visited = new HashSet<T>();
                var queue = new Queue<T>();
                queue.Enqueue(start);

                while (queue.Count > 0)
                {
                    var vertex = queue.Dequeue();

                    if (!visited.Contains(vertex))
                    {
                        visited.Add(vertex);
                        action(vertex);

                        foreach (var neighbor in adjacencyList[vertex])
                        {
                            if (!visited.Contains(neighbor))
                            {
                                queue.Enqueue(neighbor);
                            }
                        }
                    }
                }
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show($"Key not found: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"Argument is null: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Gets all vertices in the graph.
        /// </summary>
        public IEnumerable<T> GetAllVertices()
        {
            return adjacencyList.Keys;
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Performs a depth-first search (DFS) on a binary search tree.
        /// </summary>
        public void DepthFirstSearch<TK, TV>(BinarySearchTree<TK, TV> tree, Action<TK, TV> action) where TK : IComparable<TK>
        {
            DepthFirstSearchRecursive(tree.Root, action);
        }
        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Helper method for performing a depth-first search (DFS) on a binary search tree.
        /// </summary>
        private void DepthFirstSearchRecursive<TK, TV>(BinarySearchTree<TK, TV>.Node node, Action<TK, TV> action) where TK : IComparable<TK>
        {
            if (node == null)
                return;

            action(node.Key, node.Value);
            DepthFirstSearchRecursive(node.Left, action);
            DepthFirstSearchRecursive(node.Right, action);
        }

        //<----------------------------------------------------------------------------------------------------------------------------------------------->//

        /// <summary>
        /// Performs a breadth-first search (BFS) on a binary search tree.
        /// </summary>
        public void BreadthFirstSearch<TK, TV>(BinarySearchTree<TK, TV> tree, Action<TK, TV> action) where TK : IComparable<TK>
        {
            if (tree.Root == null)
                return;

            var queue = new Queue<BinarySearchTree<TK, TV>.Node>();
            queue.Enqueue(tree.Root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                action(node.Key, node.Value);

                if (node.Left != null)
                    queue.Enqueue(node.Left);
                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
        }
    }
}
//<-------------------------------------------------------------------END OF FILE-------------------------------------------------------------------------------->//
