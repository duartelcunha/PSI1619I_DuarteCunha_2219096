﻿
namespace WindowsFormsApp1
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sair = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.procutenteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Atualiza = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Apagar = new System.Windows.Forms.Button();
            this.Procurar = new System.Windows.Forms.Button();
            this.Utente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.Sair);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 93);
            this.panel1.TabIndex = 0;
            // 
            // Sair
            // 
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.ForeColor = System.Drawing.Color.SandyBrown;
            this.Sair.Image = ((System.Drawing.Image)(resources.GetObject("Sair.Image")));
            this.Sair.Location = new System.Drawing.Point(1119, 26);
            this.Sair.Margin = new System.Windows.Forms.Padding(4);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(46, 39);
            this.Sair.TabIndex = 29;
            this.Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(91, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 39);
            this.label6.TabIndex = 28;
            this.label6.Text = "Informações";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Location = new System.Drawing.Point(12, 611);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1185, 27);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(533, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // procutenteTextBox
            // 
            this.procutenteTextBox.AllowDrop = true;
            this.procutenteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.procutenteTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procutenteTextBox.Location = new System.Drawing.Point(81, 108);
            this.procutenteTextBox.Name = "procutenteTextBox";
            this.procutenteTextBox.Size = new System.Drawing.Size(101, 29);
            this.procutenteTextBox.TabIndex = 2;
            this.procutenteTextBox.TextChanged += new System.EventHandler(this.procutenteTextBox_TextChanged);
            this.procutenteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.procutenteTextBox_KeyPress);
            this.procutenteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.procutenteTextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "NIF:";
            // 
            // Atualiza
            // 
            this.Atualiza.AutoSize = true;
            this.Atualiza.BackColor = System.Drawing.Color.White;
            this.Atualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atualiza.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualiza.ForeColor = System.Drawing.Color.White;
            this.Atualiza.Image = ((System.Drawing.Image)(resources.GetObject("Atualiza.Image")));
            this.Atualiza.Location = new System.Drawing.Point(576, 315);
            this.Atualiza.Margin = new System.Windows.Forms.Padding(4);
            this.Atualiza.Name = "Atualiza";
            this.Atualiza.Size = new System.Drawing.Size(43, 51);
            this.Atualiza.TabIndex = 20;
            this.Atualiza.UseVisualStyleBackColor = false;
            this.Atualiza.Click += new System.EventHandler(this.Atualiza_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SandyBrown;
            this.panel6.Location = new System.Drawing.Point(12, 98);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(14, 507);
            this.panel6.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Location = new System.Drawing.Point(1183, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 507);
            this.panel3.TabIndex = 33;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(626, 179);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(551, 426);
            this.dataGridView2.TabIndex = 34;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "Livros Requisitados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "Livros Devolvidos:";
            // 
            // Apagar
            // 
            this.Apagar.AutoSize = true;
            this.Apagar.BackColor = System.Drawing.Color.White;
            this.Apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apagar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apagar.ForeColor = System.Drawing.Color.Transparent;
            this.Apagar.Image = ((System.Drawing.Image)(resources.GetObject("Apagar.Image")));
            this.Apagar.Location = new System.Drawing.Point(576, 374);
            this.Apagar.Margin = new System.Windows.Forms.Padding(4);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(43, 48);
            this.Apagar.TabIndex = 37;
            this.Apagar.UseVisualStyleBackColor = false;
            this.Apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // Procurar
            // 
            this.Procurar.AutoSize = true;
            this.Procurar.BackColor = System.Drawing.Color.White;
            this.Procurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Procurar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procurar.ForeColor = System.Drawing.Color.White;
            this.Procurar.Image = ((System.Drawing.Image)(resources.GetObject("Procurar.Image")));
            this.Procurar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Procurar.Location = new System.Drawing.Point(189, 101);
            this.Procurar.Margin = new System.Windows.Forms.Padding(4);
            this.Procurar.Name = "Procurar";
            this.Procurar.Size = new System.Drawing.Size(40, 40);
            this.Procurar.TabIndex = 41;
            this.Procurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Procurar.UseVisualStyleBackColor = false;
            this.Procurar.Click += new System.EventHandler(this.Procurar_Click);
            // 
            // Utente
            // 
            this.Utente.AutoSize = true;
            this.Utente.BackColor = System.Drawing.Color.White;
            this.Utente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Utente.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Utente.ForeColor = System.Drawing.Color.White;
            this.Utente.Image = ((System.Drawing.Image)(resources.GetObject("Utente.Image")));
            this.Utente.Location = new System.Drawing.Point(576, 263);
            this.Utente.Margin = new System.Windows.Forms.Padding(4);
            this.Utente.Name = "Utente";
            this.Utente.Size = new System.Drawing.Size(43, 40);
            this.Utente.TabIndex = 40;
            this.Utente.UseVisualStyleBackColor = false;
            this.Utente.Click += new System.EventHandler(this.Utente_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1209, 641);
            this.ControlBox = false;
            this.Controls.Add(this.Procurar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Atualiza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.procutenteTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Apagar);
            this.Controls.Add(this.Utente);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "⠀⠀⠀⠀⠀⠀⠀⠀⠀";
            this.Load += new System.EventHandler(this.Info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox procutenteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Atualiza;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Apagar;
        private System.Windows.Forms.Button Procurar;
        private System.Windows.Forms.Button Utente;
    }
}