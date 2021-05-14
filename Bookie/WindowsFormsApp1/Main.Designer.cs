
namespace WindowsFormsApp1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUtilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirUtilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requisitarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retornarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalhesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem,
            this.utilizadorToolStripMenuItem,
            this.livrosToolStripMenuItem1,
            this.requisitarLivroToolStripMenuItem,
            this.retornarLivroToolStripMenuItem,
            this.detalhesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(269, 549);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.livrosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("livrosToolStripMenuItem.Image")));
            this.livrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(256, 115);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // utilizadorToolStripMenuItem
            // 
            this.utilizadorToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.utilizadorToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.utilizadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verUtilizadoresToolStripMenuItem,
            this.inserirUtilizadoresToolStripMenuItem});
            this.utilizadorToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilizadorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("utilizadorToolStripMenuItem.Image")));
            this.utilizadorToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.utilizadorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.utilizadorToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.utilizadorToolStripMenuItem.Name = "utilizadorToolStripMenuItem";
            this.utilizadorToolStripMenuItem.Size = new System.Drawing.Size(253, 68);
            this.utilizadorToolStripMenuItem.Text = "Utilizador";
            // 
            // verUtilizadoresToolStripMenuItem
            // 
            this.verUtilizadoresToolStripMenuItem.Name = "verUtilizadoresToolStripMenuItem";
            this.verUtilizadoresToolStripMenuItem.Size = new System.Drawing.Size(234, 30);
            this.verUtilizadoresToolStripMenuItem.Text = "Ver Utilizador";
            this.verUtilizadoresToolStripMenuItem.Click += new System.EventHandler(this.verUtilizadoresToolStripMenuItem_Click);
            // 
            // inserirUtilizadoresToolStripMenuItem
            // 
            this.inserirUtilizadoresToolStripMenuItem.Name = "inserirUtilizadoresToolStripMenuItem";
            this.inserirUtilizadoresToolStripMenuItem.Size = new System.Drawing.Size(234, 30);
            this.inserirUtilizadoresToolStripMenuItem.Text = "Inserir Utilizador";
            this.inserirUtilizadoresToolStripMenuItem.Click += new System.EventHandler(this.inserirUtilizadoresToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem1
            // 
            this.livrosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verLivrosToolStripMenuItem,
            this.inserirLivrosToolStripMenuItem});
            this.livrosToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livrosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("livrosToolStripMenuItem1.Image")));
            this.livrosToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.livrosToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.livrosToolStripMenuItem1.Name = "livrosToolStripMenuItem1";
            this.livrosToolStripMenuItem1.Size = new System.Drawing.Size(256, 68);
            this.livrosToolStripMenuItem1.Text = "Livros";
            // 
            // verLivrosToolStripMenuItem
            // 
            this.verLivrosToolStripMenuItem.Name = "verLivrosToolStripMenuItem";
            this.verLivrosToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.verLivrosToolStripMenuItem.Text = "Ver Livros";
            this.verLivrosToolStripMenuItem.Click += new System.EventHandler(this.verLivrosToolStripMenuItem_Click);
            // 
            // inserirLivrosToolStripMenuItem
            // 
            this.inserirLivrosToolStripMenuItem.Name = "inserirLivrosToolStripMenuItem";
            this.inserirLivrosToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.inserirLivrosToolStripMenuItem.Text = "Inserir Livros";
            this.inserirLivrosToolStripMenuItem.Click += new System.EventHandler(this.inserirLivrosToolStripMenuItem_Click);
            // 
            // requisitarLivroToolStripMenuItem
            // 
            this.requisitarLivroToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requisitarLivroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("requisitarLivroToolStripMenuItem.Image")));
            this.requisitarLivroToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.requisitarLivroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.requisitarLivroToolStripMenuItem.Name = "requisitarLivroToolStripMenuItem";
            this.requisitarLivroToolStripMenuItem.Size = new System.Drawing.Size(256, 68);
            this.requisitarLivroToolStripMenuItem.Text = "Requisição";
            this.requisitarLivroToolStripMenuItem.Click += new System.EventHandler(this.requisitarLivroToolStripMenuItem_Click);
            // 
            // retornarLivroToolStripMenuItem
            // 
            this.retornarLivroToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retornarLivroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("retornarLivroToolStripMenuItem.Image")));
            this.retornarLivroToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.retornarLivroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retornarLivroToolStripMenuItem.Name = "retornarLivroToolStripMenuItem";
            this.retornarLivroToolStripMenuItem.Size = new System.Drawing.Size(256, 68);
            this.retornarLivroToolStripMenuItem.Text = "Devolução";
            // 
            // detalhesToolStripMenuItem
            // 
            this.detalhesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalhesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detalhesToolStripMenuItem.Image")));
            this.detalhesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detalhesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detalhesToolStripMenuItem.Name = "detalhesToolStripMenuItem";
            this.detalhesToolStripMenuItem.Size = new System.Drawing.Size(256, 68);
            this.detalhesToolStripMenuItem.Text = "Detalhes";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sairToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(256, 68);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 549);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilizadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUtilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirUtilizadoresToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem requisitarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retornarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalhesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirLivrosToolStripMenuItem;
    }
}