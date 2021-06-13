
namespace SpeisePlan_Linhart_Gebauer
{
    partial class frmZutatenliste
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zutatHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zutatBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zutatLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zutatEinerSpeiseHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(536, 303);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Menge";
            this.columnHeader6.Width = 108;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Einheit";
            this.columnHeader7.Width = 93;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Bezeichnung";
            this.columnHeader8.Width = 253;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Allergene";
            this.columnHeader9.Width = 147;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zutatHinzufügenToolStripMenuItem,
            this.zutatBearbeitenToolStripMenuItem,
            this.zutatLöschenToolStripMenuItem,
            this.zutatEinerSpeiseHinzufügenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(337, 124);
            // 
            // zutatHinzufügenToolStripMenuItem
            // 
            this.zutatHinzufügenToolStripMenuItem.Name = "zutatHinzufügenToolStripMenuItem";
            this.zutatHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(336, 30);
            this.zutatHinzufügenToolStripMenuItem.Text = "Zutat hinzufügen";
            this.zutatHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.zutatHinzufügenToolStripMenuItem_Click);
            // 
            // zutatBearbeitenToolStripMenuItem
            // 
            this.zutatBearbeitenToolStripMenuItem.Name = "zutatBearbeitenToolStripMenuItem";
            this.zutatBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(336, 30);
            this.zutatBearbeitenToolStripMenuItem.Text = "Zutat bearbeiten";
            this.zutatBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.zutatBearbeitenToolStripMenuItem_Click);
            // 
            // zutatLöschenToolStripMenuItem
            // 
            this.zutatLöschenToolStripMenuItem.Name = "zutatLöschenToolStripMenuItem";
            this.zutatLöschenToolStripMenuItem.Size = new System.Drawing.Size(336, 30);
            this.zutatLöschenToolStripMenuItem.Text = "Zutat löschen";
            this.zutatLöschenToolStripMenuItem.Click += new System.EventHandler(this.zutatLöschenToolStripMenuItem_Click);
            // 
            // zutatEinerSpeiseHinzufügenToolStripMenuItem
            // 
            this.zutatEinerSpeiseHinzufügenToolStripMenuItem.Name = "zutatEinerSpeiseHinzufügenToolStripMenuItem";
            this.zutatEinerSpeiseHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(336, 30);
            this.zutatEinerSpeiseHinzufügenToolStripMenuItem.Text = "Zutat einer Speise hinzufügen";
            this.zutatEinerSpeiseHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.zutatEinerSpeiseHinzufügenToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zutatenliste:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpeisePlan_Linhart_Gebauer.Properties.Resources._214597619;
            this.pictureBox1.Location = new System.Drawing.Point(20, 381);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmZutatenliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(579, 618);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmZutatenliste";
            this.Text = "Zutatenliste";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmZutatenliste_FormClosing);
            this.Load += new System.EventHandler(this.frmZutatenliste_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zutatHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zutatBearbeitenToolStripMenuItem;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem zutatLöschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zutatEinerSpeiseHinzufügenToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}