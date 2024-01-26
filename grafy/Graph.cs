using System.Collections.Generic;


namespace grafy
{
    internal class Graph
    {
        private readonly List<Vertex> _vertexes = new List<Vertex>();
        private readonly List<Edge> _edges = new List<Edge>();
        public Vertex EdgeStart = null;
        public Vertex StartNode = null;
        public Vertex EndNode = null;
        public List<Vertex> Vertexes { get { return _vertexes; } }
        public List<Edge> Edges { get { return _edges; } }

        public Graph()
        {

        }

        public void Clear()
        {
            _vertexes.Clear();
            _edges.Clear();
            EdgeStart = null;
            StartNode = null;
            EndNode = null;
        }
    }
}
