using System;
using System.Collections.Generic;
using System.Linq;
using grafy;

internal class AStar : Algorithm
{
    private Vertex StartNode;
    private Vertex EndNode;

    public AStar(Graph graph) : base(graph)
    {
        StartNode = graph.StartNode;
        EndNode = graph.EndNode;
    }
    public override void Execute()
    {
        HashSet<Vertex> openSet = new HashSet<Vertex> { StartNode };
        Dictionary<Vertex, double> distances = new Dictionary<Vertex, double> { { StartNode, 0 } };
        Dictionary<Vertex, Vertex> predecessors = new Dictionary<Vertex, Vertex>();

        while (openSet.Any())
        {
            Vertex currentVertex = BestVertex(openSet, distances);

            openSet.Remove(currentVertex);

            AStarVisited.Add(currentVertex);

            if (currentVertex == EndNode)
            {
                GetPath(predecessors);
            }

            foreach (Vertex neighbour in GetNeighbours(currentVertex))
            {
                double newCost = distances[currentVertex] + DistanceBetweenVertexes(currentVertex, neighbour);

                if (!distances.ContainsKey(neighbour) || newCost < distances[neighbour])
                {
                    distances[neighbour] = newCost;
                    predecessors[neighbour] = currentVertex;

                    if (!openSet.Contains(neighbour))
                    {
                        openSet.Add(neighbour);
                    }
                }
            }
        }
    }
    private static Vertex BestVertex(HashSet<Vertex> openSet, Dictionary<Vertex, double> distances)
    {
        return openSet.OrderBy(v => distances[v]).First();
    }

    private void GetPath(Dictionary<Vertex, Vertex> predecessors)
    {
        while (EndNode != null)
        {
            Visited.Add(EndNode);
            EndNode = predecessors.ContainsKey(EndNode) ? predecessors[EndNode] : null;
        }

        Visited.Reverse();
    }

    private double DistanceBetweenVertexes(Vertex a, Vertex b)
    {
        return Math.Sqrt(Math.Pow(a.Location.X - b.Location.X, 2) + Math.Pow(a.Location.Y - b.Location.Y, 2));
    }
}
