﻿
namespace WindowsFormsApp1
{
    partial class VerLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerLivro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Apagar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomelivrotextBox = new System.Windows.Forms.TextBox();
            this.nomeautortextBox = new System.Windows.Forms.TextBox();
            this.anotextBox = new System.Windows.Forms.TextBox();
            this.qtdtextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linguagemTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nomelivroproctextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Atualiza = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SandyBrown;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(508, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SandyBrown;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade";
            // 
            // Atualizar
            // 
            this.Atualizar.BackColor = System.Drawing.Color.Chocolate;
            this.Atualizar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualizar.ForeColor = System.Drawing.Color.White;
            this.Atualizar.Location = new System.Drawing.Point(478, 126);
            this.Atualizar.Margin = new System.Windows.Forms.Padding(4);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(105, 45);
            this.Atualizar.TabIndex = 6;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = false;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Apagar
            // 
            this.Apagar.BackColor = System.Drawing.Color.Chocolate;
            this.Apagar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apagar.ForeColor = System.Drawing.Color.White;
            this.Apagar.Location = new System.Drawing.Point(591, 126);
            this.Apagar.Margin = new System.Windows.Forms.Padding(4);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(105, 45);
            this.Apagar.TabIndex = 7;
            this.Apagar.Text = "Apagar";
            this.Apagar.UseVisualStyleBackColor = false;
            this.Apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.Chocolate;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(365, 126);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(105, 45);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(45, 167);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(670, 469);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nomelivrotextBox
            // 
            this.nomelivrotextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomelivrotextBox.Location = new System.Drawing.Point(155, 25);
            this.nomelivrotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomelivrotextBox.Name = "nomelivrotextBox";
            this.nomelivrotextBox.Size = new System.Drawing.Size(261, 29);
            this.nomelivrotextBox.TabIndex = 10;
            // 
            // nomeautortextBox
            // 
            this.nomeautortextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeautortextBox.Location = new System.Drawing.Point(155, 64);
            this.nomeautortextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeautortextBox.Name = "nomeautortextBox";
            this.nomeautortextBox.Size = new System.Drawing.Size(261, 29);
            this.nomeautortextBox.TabIndex = 11;
            // 
            // anotextBox
            // 
            this.anotextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anotextBox.Location = new System.Drawing.Point(559, 25);
            this.anotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.anotextBox.Name = "anotextBox";
            this.anotextBox.Size = new System.Drawing.Size(137, 29);
            this.anotextBox.TabIndex = 12;
            // 
            // qtdtextBox
            // 
            this.qtdtextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdtextBox.Location = new System.Drawing.Point(559, 64);
            this.qtdtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.qtdtextBox.Name = "qtdtextBox";
            this.qtdtextBox.Size = new System.Drawing.Size(137, 29);
            this.qtdtextBox.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.linguagemTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.categoriaTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.nomeautortextBox);
            this.panel1.Controls.Add(this.qtdtextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.anotextBox);
            this.panel1.Controls.Add(this.nomelivrotextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Cancelar);
            this.panel1.Controls.Add(this.Apagar);
            this.panel1.Controls.Add(this.Atualizar);
            this.panel1.Location = new System.Drawing.Point(22, 643);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 201);
            this.panel1.TabIndex = 15;
            // 
            // linguagemTextBox
            // 
            this.linguagemTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linguagemTextBox.Location = new System.Drawing.Point(155, 142);
            this.linguagemTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.linguagemTextBox.Name = "linguagemTextBox";
            this.linguagemTextBox.Size = new System.Drawing.Size(192, 29);
            this.linguagemTextBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SandyBrown;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Linguagem";
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaTextBox.Location = new System.Drawing.Point(155, 104);
            this.categoriaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(192, 29);
            this.categoriaTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SandyBrown;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(86, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 39);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ver Livros";
            // 
            // nomelivroproctextBox
            // 
            this.nomelivroproctextBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomelivroproctextBox.Location = new System.Drawing.Point(246, 123);
            this.nomelivroproctextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomelivroproctextBox.Name = "nomelivroproctextBox";
            this.nomelivroproctextBox.Size = new System.Drawing.Size(297, 27);
            this.nomelivroproctextBox.TabIndex = 17;
            this.nomelivroproctextBox.TextChanged += new System.EventHandler(this.nomelivroproctextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nome do Livro:";
            // 
            // Atualiza
            // 
            this.Atualiza.AutoSize = true;
            this.Atualiza.BackColor = System.Drawing.Color.White;
            this.Atualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atualiza.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualiza.ForeColor = System.Drawing.Color.White;
            this.Atualiza.Image = ((System.Drawing.Image)(resources.GetObject("Atualiza.Image")));
            this.Atualiza.Location = new System.Drawing.Point(562, 113);
            this.Atualiza.Margin = new System.Windows.Forms.Padding(4);
            this.Atualiza.Name = "Atualiza";
            this.Atualiza.Size = new System.Drawing.Size(46, 46);
            this.Atualiza.TabIndex = 19;
            this.Atualiza.UseVisualStyleBackColor = false;
            this.Atualiza.Click += new System.EventHandler(this.Atualiza_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.PT);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(22, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 105);
            this.panel2.TabIndex = 21;
            // 
            // PT
            // 
            this.PT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PT.ForeColor = System.Drawing.Color.SandyBrown;
            this.PT.Image = ((System.Drawing.Image)(resources.GetObject("PT.Image")));
            this.PT.Location = new System.Drawing.Point(649, 39);
            this.PT.Margin = new System.Windows.Forms.Padding(4);
            this.PT.Name = "PT";
            this.PT.Size = new System.Drawing.Size(43, 42);
            this.PT.TabIndex = 23;
            this.PT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PT.UseVisualStyleBackColor = true;
            this.PT.Click += new System.EventHandler(this.PT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 68);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SandyBrown;
            this.panel6.Location = new System.Drawing.Point(22, 112);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(16, 524);
            this.panel6.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Location = new System.Drawing.Point(722, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 524);
            this.panel3.TabIndex = 32;
            // 
            // VerLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 14);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 675);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Atualiza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nomelivroproctextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VerLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "⠀⠀⠀⠀⠀⠀⠀⠀⠀";
            this.Load += new System.EventHandler(this.VerLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Apagar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nomelivrotextBox;
        private System.Windows.Forms.TextBox nomeautortextBox;
        private System.Windows.Forms.TextBox anotextBox;
        private System.Windows.Forms.TextBox qtdtextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nomelivroproctextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Atualiza;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PT;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox linguagemTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.Label label8;
    }
}