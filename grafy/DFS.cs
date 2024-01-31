using System.Collections.Generic;

namespace grafy
{
    internal class DFS : Algorithm
    {
        Vertex Node;
        public DFS(Graph Graph) : base(Graph)
        {
            Node = Graph.StartNode;
        }

        public override void Execute()
        {
            Visited.Add(Node);
            List<Vertex> Neighbours = GetNeighbours(Node);
            foreach (Vertex neighbour in Neighbours)
            {
                if (!Visited.Contains(neighbour))
                {
                    Node = neighbour;
                    Execute();
                }
            }
        }
    }
}
