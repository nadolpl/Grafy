using System.Collections.Generic;

namespace grafy
{
    internal class BFS : Algorithm
    {
        Queue<Vertex> queue = new Queue<Vertex>();
        Vertex Node;
        public BFS(Graph Graph) : base(Graph)
        {
            Node = Graph.StartNode;
        }
        public override void Execute()
        {
            Visited.Add(Node);
            queue.Enqueue(Node);

            while (queue.Count > 0)
            {
                Vertex currentNode = queue.Dequeue();
                List<Vertex> neighbours = GetNeighbours(currentNode);

                foreach (Vertex neighbour in neighbours)
                {
                    if (!Visited.Contains(neighbour))
                    {
                        Visited.Add(neighbour);
                        queue.Enqueue(neighbour);
                    }
                }
            }
        }
    }
}
