using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace grafy
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ResetBtn = new System.Windows.Forms.Button();
            this.BFSBtn = new System.Windows.Forms.Button();
            this.DFSBtn = new System.Windows.Forms.Button();
            this.AStarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ResetBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ResetBtn, "ResetBtn");
            this.ResetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // BFSBtn
            // 
            this.BFSBtn.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.BFSBtn, "BFSBtn");
            this.BFSBtn.FlatAppearance.BorderSize = 0;
            this.BFSBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.BFSBtn.Name = "BFSBtn";
            this.BFSBtn.UseVisualStyleBackColor = false;
            this.BFSBtn.Click += new System.EventHandler(this.BFS_Click);
            // 
            // DFSBtn
            // 
            this.DFSBtn.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.DFSBtn, "DFSBtn");
            this.DFSBtn.FlatAppearance.BorderSize = 0;
            this.DFSBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.DFSBtn.Name = "DFSBtn";
            this.DFSBtn.UseVisualStyleBackColor = false;
            this.DFSBtn.Click += new System.EventHandler(this.DFS_Click);
            // 
            // AStarBtn
            // 
            this.AStarBtn.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.AStarBtn, "AStarBtn");
            this.AStarBtn.FlatAppearance.BorderSize = 0;
            this.AStarBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.AStarBtn.Name = "AStarBtn";
            this.AStarBtn.UseVisualStyleBackColor = false;
            this.AStarBtn.Click += new System.EventHandler(this.AStarBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.label5.Name = "label5";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AStarBtn);
            this.Controls.Add(this.DFSBtn);
            this.Controls.Add(this.BFSBtn);
            this.Controls.Add(this.ResetBtn);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button BFSBtn;
        private System.Windows.Forms.Button DFSBtn;
        private System.Windows.Forms.Button AStarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

