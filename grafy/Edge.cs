
using System.Drawing;


namespace grafy
{
    internal class Edge
    {
        public Edge(Vertex Start, Vertex End)
        {
            _VertexStart = Start;
            _VertexEnd = End;
        }
        private Vertex _VertexStart;
        private Vertex _VertexEnd;
        public Vertex Start
        {
            get { return _VertexStart; }
        }
        public Vertex End
        {
            get { return _VertexEnd; }
        }

        public void Draw(Graphics Graph)
        {
            Pen Pen = new Pen(Color.SlateGray, 5);
            Point StartPoint = new Point(_VertexStart.Left + _VertexStart.Width / 2, _VertexStart.Top + _VertexStart.Height / 2);
            Point EndPoint = new Point(_VertexEnd.Left + _VertexEnd.Width / 2, _VertexEnd.Top + _VertexEnd.Height / 2);

            Graph.DrawLine(Pen, StartPoint, EndPoint);
        }
    }
}
