using System.Drawing;
using System.Windows.Forms;

namespace grafy
{
    internal class Vertex : Button
    {
        private static uint ID = 0;
        public Vertex(Point location)
        {
            ID++;

            this.Size = new Size(80, 80);
            this.BackColor = Color.CadetBlue;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Text = ID.ToString();
            this.ForeColor = Color.Gainsboro;
            this.Font = new Font("Arial", 25, FontStyle.Bold);
            this.Location = location;
        }

        public static void ClearID()
        {
            ID = 0;
        }
    }
}