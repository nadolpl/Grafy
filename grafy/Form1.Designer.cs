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
            this.ResetBtn = new System.Windows.Forms.Button();
            this.BFS = new System.Windows.Forms.Button();
            this.DFS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(12, 12);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 39);
            this.ResetBtn.TabIndex = 0;
            this.ResetBtn.Text = "RESET";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // BFS
            // 
            this.BFS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BFS.Location = new System.Drawing.Point(13, 58);
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(75, 44);
            this.BFS.TabIndex = 1;
            this.BFS.Text = "BFS";
            this.BFS.UseVisualStyleBackColor = true;
            this.BFS.Click += new System.EventHandler(this.BFS_Click);
            // 
            // DFS
            // 
            this.DFS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DFS.Location = new System.Drawing.Point(13, 108);
            this.DFS.Name = "DFS";
            this.DFS.Size = new System.Drawing.Size(75, 44);
            this.DFS.TabIndex = 2;
            this.DFS.Text = "DFS";
            this.DFS.UseVisualStyleBackColor = true;
            this.DFS.Click += new System.EventHandler(this.DFS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(820, 665);
            this.Controls.Add(this.DFS);
            this.Controls.Add(this.BFS);
            this.Controls.Add(this.ResetBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button BFS;
        private System.Windows.Forms.Button DFS;
    }
}

