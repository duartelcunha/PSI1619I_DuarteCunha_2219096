
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feitoPorDuarteCunhaTGPSITurmaIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tempo = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.livrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feitoPorDuarteCunhaTGPSITurmaIToolStripMenuItem});
            this.livrosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("livrosToolStripMenuItem.Image")));
            this.livrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(256, 115);
            this.livrosToolStripMenuItem.Text = "Livros";
            // 
            // feitoPorDuarteCunhaTGPSITurmaIToolStripMenuItem
            // 
            this.feitoPorDuarteCunhaTGPSITurmaIToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feitoPorDuarteCunhaTGPSITurmaIToolStripMenuItem.Name = "feitoPorDuarteCunhaTGPSITurmaIToolStripMenuItem";
            this.feitoPorDuarteCunhaTGPSITurmaIToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.feitoPorDuarteCunhaTGPSITurmaIToolStripMenuItem.Text = "Feito por: Duarte Cunha - TGPSI - Turma I";
            // 
            // utilizadorToolStripMenuItem
            // 
            this.utilizadorToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.utilizadorToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.utilizadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verUtilizadoresToolStripMenuItem,
            this.inserirUtilizadoresToolStripMenuItem});
            this.utilizadorToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilizadorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("utilizadorToolStripMenuItem.Image")));
            this.utilizadorToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.utilizadorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.utilizadorToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.utilizadorToolStripMenuItem.Name = "utilizadorToolStripMenuItem";
            this.utilizadorToolStripMenuItem.Size = new System.Drawing.Size(253, 68);
            this.utilizadorToolStripMenuItem.Text = "Utente";
            // 
            // verUtilizadoresToolStripMenuItem
            // 
            this.verUtilizadoresToolStripMenuItem.Name = "verUtilizadoresToolStripMenuItem";
            this.verUtilizadoresToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.verUtilizadoresToolStripMenuItem.Text = "Ver Utente";
            this.verUtilizadoresToolStripMenuItem.Click += new System.EventHandler(this.verUtenteToolStripMenuItem_Click);
            // 
            // inserirUtilizadoresToolStripMenuItem
            // 
            this.inserirUtilizadoresToolStripMenuItem.Name = "inserirUtilizadoresToolStripMenuItem";
            this.inserirUtilizadoresToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.inserirUtilizadoresToolStripMenuItem.Text = "Inserir Utente";
            this.inserirUtilizadoresToolStripMenuItem.Click += new System.EventHandler(this.inserirUtilizadoresToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem1
            // 
            this.livrosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verLivrosToolStripMenuItem,
            this.inserirLivrosToolStripMenuItem});
            this.livrosToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.verLivrosToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.verLivrosToolStripMenuItem.Text = "Ver Livros";
            this.verLivrosToolStripMenuItem.Click += new System.EventHandler(this.verLivrosToolStripMenuItem_Click);
            // 
            // inserirLivrosToolStripMenuItem
            // 
            this.inserirLivrosToolStripMenuItem.Name = "inserirLivrosToolStripMenuItem";
            this.inserirLivrosToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.inserirLivrosToolStripMenuItem.Text = "Inserir Livros";
            this.inserirLivrosToolStripMenuItem.Click += new System.EventHandler(this.inserirLivrosToolStripMenuItem_Click);
            // 
            // requisitarLivroToolStripMenuItem
            // 
            this.requisitarLivroToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.retornarLivroToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retornarLivroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("retornarLivroToolStripMenuItem.Image")));
            this.retornarLivroToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.retornarLivroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retornarLivroToolStripMenuItem.Name = "retornarLivroToolStripMenuItem";
            this.retornarLivroToolStripMenuItem.Size = new System.Drawing.Size(256, 68);
            this.retornarLivroToolStripMenuItem.Text = "Devolução";
            this.retornarLivroToolStripMenuItem.Click += new System.EventHandler(this.devolverLivroToolStripMenuItem_Click);
            // 
            // detalhesToolStripMenuItem
            // 
            this.detalhesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalhesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detalhesToolStripMenuItem.Image")));
            this.detalhesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detalhesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detalhesToolStripMenuItem.Name = "detalhesToolStripMenuItem";
            this.detalhesToolStripMenuItem.Size = new System.Drawing.Size(256, 68);
            this.detalhesToolStripMenuItem.Text = "Informações";
            this.detalhesToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sairToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(256, 68);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 553);
            this.panel1.TabIndex = 3;
            // 
            // Tempo
            // 
            this.Tempo.AutoSize = true;
            this.Tempo.BackColor = System.Drawing.Color.SandyBrown;
            this.Tempo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tempo.ForeColor = System.Drawing.Color.White;
            this.Tempo.Location = new System.Drawing.Point(1023, 9);
            this.Tempo.Name = "Tempo";
            this.Tempo.Size = new System.Drawing.Size(53, 20);
            this.Tempo.TabIndex = 5;
            this.Tempo.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Location = new System.Drawing.Point(1092, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 553);
            this.panel2.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 549);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Tempo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Opacity = 0D;
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
        private System.Windows.Forms.ToolStripMenuItem feitoPorDuarteCunhaTGPSITurmaIToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Tempo;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel2;
    }
}