using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace grafy
{
    public partial class Form1 : Form
    {
        private readonly List<Button> Tops = new List<Button>();
        private readonly List<Edge> Edges = new List<Edge>();
        private int topCounter = 0;
        private int edgeCounter = 0;
        private Button EdgeStart = null;
        public class Edge
        {
            public Button EdgeStart { get; set; }
            public Button EdgeEnd { get; set; }
            public int ID {  get; set; }

            public void Draw(Graphics g, Pen pen)
            {
                Point startPoint = new Point(EdgeStart.Left + EdgeStart.Width / 2, EdgeStart.Top + EdgeStart.Height / 2);
                Point endPoint = new Point(EdgeEnd.Left + EdgeEnd.Width / 2, EdgeEnd.Top + EdgeEnd.Height / 2);

                g.DrawLine(pen, startPoint, endPoint);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateTop(Point location)
        {
            Button top = new Button
            {
                Size = new Size(80, 80),
                BackColor = Color.CadetBlue,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Text = topCounter.ToString(),
                ForeColor = Color.Gainsboro,
                Font = new Font("Arial", 25, FontStyle.Bold),
                Location = location
            };

            top.MouseDown += Top_MouseDown;
            top.MouseMove += Top_MouseMove;

            topCounter++;

            Tops.Add(top);
            Controls.Add(top);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CreateTop(e.Location);
            }
        }

        private void Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MoveTop((Control)sender, e.Location);
                UpdateEdges();
            }
        }

        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                HandleRightMouseDown((Button)sender);
            }
        }

        private void MoveTop(Control top, Point location)
        {
            int deltaX = location.X - (top.Width / 2);
            int deltaY = location.Y - (top.Height / 2);

            top.Location = new Point(top.Location.X + deltaX, top.Location.Y + deltaY);
        }

        private void HandleRightMouseDown(Button top)
        {
            if (EdgeStart == null)
            {
                EdgeStart = top;
                EdgeStart.BackColor = Color.WhiteSmoke;
            }
            else
            {
                EdgeStart.BackColor = Color.CadetBlue;

                DrawEdge(EdgeStart, top, edgeCounter);

                EdgeStart = null;
            }
        }

        private void DrawEdge(Button start, Button end, int edgeCounter)
        {
            Edge newEdge = new Edge
            {
                EdgeStart = start,
                EdgeEnd = end,
                ID = edgeCounter
            };

            bool edgeExists = false;

            foreach (Edge edge in Edges)
            {
                if ((edge.EdgeStart == newEdge.EdgeStart && edge.EdgeEnd == newEdge.EdgeEnd) ||
                    (edge.EdgeStart == newEdge.EdgeEnd && edge.EdgeEnd == newEdge.EdgeStart))
                {
                    edgeExists = true;
                    Console.WriteLine("Krawędź już istnieje");
                    break;
                }
            }

            if (!edgeExists)
            {
                using (Graphics g = CreateGraphics())
                {
                    using (Pen edgePen = new Pen(Color.CadetBlue, 5))
                    {
                        newEdge.Draw(g, edgePen);
                    }
                }

                Edges.Add(newEdge);
            }
        }

        private void UpdateEdges()
        {
            using (Graphics g = CreateGraphics())
            {
                g.Clear(BackColor);

                foreach (Edge edge in Edges)
                {
                    using (Pen edgePen = new Pen(Color.CadetBlue, 5))
                    {
                        edge.Draw(g, edgePen);
                    }
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            foreach (Button top in Tops)
            {
                Controls.Remove(top);
            }

            topCounter = 0;
            edgeCounter = 0;
            EdgeStart = null;

            Tops.Clear();
            Edges.Clear();

            visited.Clear();
            queue.Clear();

            Refresh();
        }

        private void BFS_Click(object sender, EventArgs e)
        {
            Button startNode = Tops.Find(top => top.Text == "0");

            BFS_Start();
            visited.Clear();
            queue.Clear();
        }

        private readonly List<Button> visited = new List<Button>();
        private readonly List<Button> queue = new List<Button>();

        private void BFS_Start()
        {
            foreach(Button top in Tops)
            {
                queue.Add(top);
            }

            while (queue.Count > 0)
            {
                Button node = queue[0];
                queue.RemoveAt(0);

                if (!visited.Contains(node))
                {
                    visited.Add(node);
                    List<Button> neighbours = GetNeighbours(node);
                    foreach (var item in neighbours)
                    {
                        if (!visited.Contains(item))
                        {
                            queue.Add(item);
                        }
                    }
                }
            }
            ShowAnimation();
        }


        private List<Button> GetNeighbours(Button currentNode)
        {
            var neighbours = new List<Button>();

            foreach (Edge edge in Edges)
            {
                if (edge.EdgeStart == currentNode)
                {
                    neighbours.Add(edge.EdgeEnd);
                }
                else if (edge.EdgeEnd == currentNode)
                {
                    neighbours.Add(edge.EdgeStart);
                }
            }

            return neighbours;
        }

        private void DFS_Click(object sender, EventArgs e)
        {
            Button startNode = Tops.Find(top => top.Text == "0");

            DFS_Start(startNode);

            ShowAnimation();
            visited.Clear();
        }

        private void DFS_Start(Button node)
        {
            visited.Add(node);
            List<Button> neighbours =  GetNeighbours(node);
            foreach (var item in neighbours)
            {
                if (!visited.Contains(item))
                {
                    DFS_Start(item);
                }
            }
        }

        private void ShowAnimation()
        {
            foreach (Button item in visited)
            {
                item.BackColor = Color.White;
                Refresh();
                UpdateEdges();
                Thread.Sleep(500);
            }
            Thread.Sleep(1000);
            foreach (Button top in Tops)
            {
                top.BackColor = Color.CadetBlue;
            }
        }
    }
}
