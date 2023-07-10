namespace User_Interface_For_Nea
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Djikstras = new System.Windows.Forms.Button();
            this.Kruskal = new System.Windows.Forms.Button();
            this.Prims = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Recommend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(572, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // Djikstras
            // 
            this.Djikstras.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.Djikstras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Djikstras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Djikstras.Location = new System.Drawing.Point(540, 128);
            this.Djikstras.Name = "Djikstras";
            this.Djikstras.Size = new System.Drawing.Size(228, 77);
            this.Djikstras.TabIndex = 1;
            this.Djikstras.Text = "Practice Djikstra\'s Algorithm";
            this.Djikstras.UseVisualStyleBackColor = false;
            this.Djikstras.Click += new System.EventHandler(this.Djikstras_Click);
            // 
            // Kruskal
            // 
            this.Kruskal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Kruskal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Kruskal.Location = new System.Drawing.Point(540, 245);
            this.Kruskal.Name = "Kruskal";
            this.Kruskal.Size = new System.Drawing.Size(228, 77);
            this.Kruskal.TabIndex = 2;
            this.Kruskal.Text = "Practice Kruskal\'s Algorithm";
            this.Kruskal.UseVisualStyleBackColor = false;
            this.Kruskal.Click += new System.EventHandler(this.Kruskal_Click);
            // 
            // Prims
            // 
            this.Prims.BackColor = System.Drawing.Color.Aqua;
            this.Prims.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Prims.Location = new System.Drawing.Point(540, 362);
            this.Prims.Name = "Prims";
            this.Prims.Size = new System.Drawing.Size(230, 77);
            this.Prims.TabIndex = 3;
            this.Prims.Text = "Practice Prim\'s Algorithm";
            this.Prims.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(12, 616);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(186, 78);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // Recommend
            // 
            this.Recommend.BackColor = System.Drawing.Color.HotPink;
            this.Recommend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Recommend.Location = new System.Drawing.Point(540, 478);
            this.Recommend.Name = "Recommend";
            this.Recommend.Size = new System.Drawing.Size(230, 75);
            this.Recommend.TabIndex = 5;
            this.Recommend.Text = "Practice Recommended Question";
            this.Recommend.UseVisualStyleBackColor = false;
            this.Recommend.Click += new System.EventHandler(this.Recommend_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1490, 828);
            this.Controls.Add(this.Recommend);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Prims);
            this.Controls.Add(this.Kruskal);
            this.Controls.Add(this.Djikstras);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Djikstras;
        private System.Windows.Forms.Button Kruskal;
        private System.Windows.Forms.Button Prims;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Recommend;
    }
}

