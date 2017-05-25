using System;
using System.Collections.Generic;

namespace CSInterview.Algorithms
{

    public class Node
    {
        public int id;
        public List<Node> adjacent = new List<Node>();
        public Node(int id)
        {
            this.id = id;
        }
    }
    public class Graph
    {
        private Dictionary<int, Node> nodeLookup = new Dictionary<int, Node>();

        private Node GetNode(int id)
        {

        }

        public void AddEdge(int source, int distination)
        {
            Node s = GetNode(source);
            Node d = GetNode(distination);
            s.adjacent.Add(d);
        }

        public bool HasPathDFS(int source, int distination)
        {
            Node s = GetNode(source);
            Node d = GetNode(distination);

            HashSet<int> visited = new HashSet<int>();
            return HasPathDFS(s, d, visited);
        }

        private bool HasPathDFS(Node source, Node distination, HashSet<int> visited)
        {
            if (visited.Contains(source.id))
            {
                return false;
            }
            visited.Add(source.id);
            if (source == distination)
            {
                return true;
            }
            foreach (Node child in source.adjacent)
            {
                if (HasPathDFS(child, distination, visited))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasPathBFS(int source, int distination)
        {
            return HasPathBFS(GetNode(source), GetNode(distination));
        }
        private bool HasPathBFS(Node source, Node distination)
        {
            Queue<Node> nextToVisit = new Queue<Node>();
            HashSet<int> visited = new HashSet<int>();

            nextToVisit.Enqueue(source);
            while(nextToVisit.Count > 0)
            {
                Node node = nextToVisit.Dequeue();
                if(node == distination)
                {
                    return true;
                }
                if (visited.Contains(node.id))
                {
                    continue;
                }
                visited.Add(node.id);
                foreach(Node child in node.adjacent)
                {
                    nextToVisit.Enqueue(child);
                }
            }
            return false;
        }
    }
}