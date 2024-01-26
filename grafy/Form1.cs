using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace grafy
{
    public partial class Form1 : Form
    {
        Graph Graph = new Graph();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CreateVertex(e.Location);
            }
        }
        private void CreateVertex(Point location)
        {
            Vertex Vertex = new Vertex(location);

            Vertex.MouseDown += Vertex_MouseDown;
            Vertex.MouseMove += Vertex_MouseMove;

            if(Graph.Vertexes.Count() == 0)
            {
                Vertex.BackColor = Color.RoyalBlue;
                Graph.StartNode = Vertex;
            }

            Graph.Vertexes.Add(Vertex);
            Controls.Add(Vertex);
        }
        
        private void Vertex_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MoveVertex((Control)sender, e.Location);
                UpdateEdges();
            }
        }

        private void Vertex_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (Graph.EdgeStart == null)
                {
                    Graph.EdgeStart = (Vertex)sender;
                    Graph.EdgeStart.BackColor = Color.SlateGray;
                }
                else
                {
                    Graph.EdgeStart.BackColor = Color.CadetBlue;

                    DrawEdge(Graph.EdgeStart, (Vertex)sender);

                    Graph.EdgeStart = null;
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                if ((Vertex)sender == Graph.EndNode)
                {
                    return;
                }
                else if (Graph.StartNode != null)
                {
                    Graph.StartNode.BackColor = Color.CadetBlue;
                }

                Graph.StartNode = (Vertex)sender;
                Graph.StartNode.BackColor = Color.RoyalBlue;
            }
            else if (e.Button == MouseButtons.Middle)
            {
                if (Graph.EndNode == (Vertex)sender) {
                    Graph.EndNode.BackColor = Color.CadetBlue;
                    Graph.EndNode = null;
                    return;
                }
                else if ((Vertex)sender == Graph.StartNode)
                {
                    return;
                }
                else if (Graph.EndNode != null)
                {
                    Graph.EndNode.BackColor = Color.CadetBlue;
                }
                Graph.EndNode = (Vertex)sender;
                Graph.EndNode.BackColor = Color.DodgerBlue;
            }
        }

        private void MoveVertex(Control Vertex, Point location)
        {
            int deltaX = location.X - (Vertex.Width / 2);
            int deltaY = location.Y - (Vertex.Height / 2);

            Vertex.Location = new Point(Vertex.Location.X + deltaX, Vertex.Location.Y + deltaY);
        }
        private void DrawEdge(Vertex Start, Vertex End)
        {
            Edge NewEdge = new Edge(Start, End);

            if (!EdgeExists(NewEdge))
            {
                using (Graphics g = CreateGraphics())
                {
                    NewEdge.Draw(g);
                }

                Graph.Edges.Add(NewEdge);
            }

            Graph.StartNode.BackColor = Color.RoyalBlue;

            if(Graph.EndNode != null)
            {
                Graph.EndNode.BackColor = Color.DodgerBlue;
            }
        }

        private bool EdgeExists(Edge NewEdge)
        {
            foreach (Edge Edge in Graph.Edges)
            {
                if ((Edge.Start == NewEdge.Start && Edge.End == NewEdge.End) ||
                    (Edge.Start == NewEdge.End && Edge.End == NewEdge.Start))
                {
                    Graph.Edges.Remove(Edge);
                    UpdateEdges();
                    return true;
                }
            }
            return false;
        }

        private void UpdateEdges()
        {
            using (Graphics g = CreateGraphics())
            {
                g.Clear(BackColor);

                foreach (Edge Edge in Graph.Edges)
                {
                    using (Pen edgePen = new Pen(Color.CadetBlue, 5))
                    {
                        Edge.Draw(g);
                    }
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            foreach (Vertex Vertex in Graph.Vertexes)
            {
                Controls.Remove(Vertex);
            }

            Vertex.ClearID();
            Graph.Clear();

            Refresh();
        }

        private void ShowAnimation(List<Vertex> Visited, int delay, int pause)
        {

            foreach (Vertex item in Visited)
            {
                item.BackColor = Color.Khaki;
                Refresh();
                UpdateEdges();
                Thread.Sleep(delay);
            }

            Thread.Sleep(pause);

            foreach (Vertex Vertex in Graph.Vertexes)
            {
                Vertex.BackColor = Color.CadetBlue;
            }

            Graph.StartNode.BackColor = Color.RoyalBlue;

            if(Graph.EndNode != null )
            {
                Graph.EndNode.BackColor = Color.DodgerBlue;
            }
        }

        private void BFS_Click(object sender, EventArgs e)
        {
            if(Graph.Vertexes.Count > 0)
            {
                BFS BFS = new BFS(Graph);
                BFS.Execute();
                ShowAnimation(BFS.Visited, 300, 700);
            }
        }

        private void DFS_Click(object sender, EventArgs e)
        {
            if(Graph.Vertexes.Count > 0)
            {
                DFS DFS = new DFS(Graph);
                DFS.Execute();
                ShowAnimation(DFS.Visited, 300, 700);
            }
        }

        private void AStarBtn_Click(object sender, EventArgs e)
        {
            if(Graph.EndNode!=null)
            {
                AStar AStar = new AStar(Graph);
                AStar.Execute();
                ShowAnimation(AStar.AStarVisited, 300, 1000);
                ShowAnimation(AStar.Visited, 500, 2500);
            }
        }
    }
}
