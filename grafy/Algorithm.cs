using System.Collections.Generic;


namespace grafy
{
    internal abstract class Algorithm
    {
        private List<Vertex> _visited = new List<Vertex>();
        private List<Vertex> _AStarVisited = new List<Vertex>();
        public List<Vertex> Visited
        {
            get { return _visited; }
        }
        
        public List<Vertex> AStarVisited
        {
            get { return _AStarVisited; }
        }
        private Graph Graph;

        public Algorithm(Graph Graph)
        {
            this.Graph = Graph;
        }

        protected List<Vertex> GetNeighbours(Vertex vertex)
        {
            List<Vertex> neighbours = new List<Vertex>();

            foreach (Edge edge in Graph.Edges)
            {
                if (edge.Start == vertex)
                {
                    neighbours.Add(edge.End);
                }
                else if (edge.End == vertex)
                {
                    neighbours.Add(edge.Start);
                }
            }
            return neighbours;
        }

        public abstract void Execute();
    }
}
