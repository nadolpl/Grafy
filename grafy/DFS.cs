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
            foreach (Vertex item in Neighbours)
            {
                if (!Visited.Contains(item))
                {
                    Node = item;
                    Execute();
                }
            }
        }
    }
}
