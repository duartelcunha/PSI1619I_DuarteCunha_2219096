
namespace WindowsFormsApp1
{
    partial class InserirLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirLivro));
            this.nomelivroTextBox = new System.Windows.Forms.TextBox();
            this.nomeautorTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Inserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomelivroTextBox
            // 
            this.nomelivroTextBox.Location = new System.Drawing.Point(180, 160);
            this.nomelivroTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.nomelivroTextBox.Name = "nomelivroTextBox";
            this.nomelivroTextBox.Size = new System.Drawing.Size(412, 29);
            this.nomelivroTextBox.TabIndex = 0;
            // 
            // nomeautorTextBox
            // 
            this.nomeautorTextBox.Location = new System.Drawing.Point(180, 212);
            this.nomeautorTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.nomeautorTextBox.Name = "nomeautorTextBox";
            this.nomeautorTextBox.Size = new System.Drawing.Size(412, 29);
            this.nomeautorTextBox.TabIndex = 1;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.Location = new System.Drawing.Point(180, 363);
            this.quantidadeTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(111, 29);
            this.quantidadeTextBox.TabIndex = 2;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.Chocolate;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(332, 388);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(125, 53);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Inserir
            // 
            this.Inserir.BackColor = System.Drawing.Color.Chocolate;
            this.Inserir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inserir.ForeColor = System.Drawing.Color.White;
            this.Inserir.Location = new System.Drawing.Point(467, 388);
            this.Inserir.Margin = new System.Windows.Forms.Padding(5);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(125, 53);
            this.Inserir.TabIndex = 4;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = false;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do Livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome do Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantidade";
            // 
            // anoTextBox
            // 
            this.anoTextBox.Location = new System.Drawing.Point(180, 262);
            this.anoTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(111, 29);
            this.anoTextBox.TabIndex = 12;
            // 
            // precoTextBox
            // 
            this.precoTextBox.Location = new System.Drawing.Point(180, 314);
            this.precoTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(111, 29);
            this.precoTextBox.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 67);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(82, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 39);
            this.label6.TabIndex = 15;
            this.label6.Text = "Inserir Livros";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 121);
            this.panel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.SandyBrown;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(577, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 39);
            this.button1.TabIndex = 24;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InserirLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 481);
            this.ControlBox = false;
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.anoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(this.nomeautorTextBox);
            this.Controls.Add(this.nomelivroTextBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "InserirLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "⠀⠀⠀⠀⠀⠀⠀⠀⠀";
            this.Load += new System.EventHandler(this.InserirLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomelivroTextBox;
        private System.Windows.Forms.TextBox nomeautorTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}