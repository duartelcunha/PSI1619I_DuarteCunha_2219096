﻿
namespace WindowsFormsApp1
{
    partial class Dev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dev));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sair = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Devolver = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Procurar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.procutenteTextBox = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.datareturnDataPicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datareqTextBox = new System.Windows.Forms.TextBox();
            this.nomelivroTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.Sair);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.SandyBrown;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 106);
            this.panel1.TabIndex = 1;
            // 
            // Sair
            // 
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.ForeColor = System.Drawing.Color.SandyBrown;
            this.Sair.Image = ((System.Drawing.Image)(resources.GetObject("Sair.Image")));
            this.Sair.Location = new System.Drawing.Point(769, 31);
            this.Sair.Margin = new System.Windows.Forms.Padding(4);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(46, 52);
            this.Sair.TabIndex = 26;
            this.Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(87, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 39);
            this.label6.TabIndex = 17;
            this.label6.Text = "Devolução de Livro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 67);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Devolver
            // 
            this.Devolver.BackColor = System.Drawing.Color.Chocolate;
            this.Devolver.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devolver.ForeColor = System.Drawing.Color.White;
            this.Devolver.Location = new System.Drawing.Point(604, 490);
            this.Devolver.Name = "Devolver";
            this.Devolver.Size = new System.Drawing.Size(153, 72);
            this.Devolver.TabIndex = 32;
            this.Devolver.Text = "Devolver";
            this.Devolver.UseVisualStyleBackColor = false;
            this.Devolver.Click += new System.EventHandler(this.Devolver_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SandyBrown;
            this.panel4.Location = new System.Drawing.Point(13, 597);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(831, 40);
            this.panel4.TabIndex = 46;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SandyBrown;
            this.panel5.Location = new System.Drawing.Point(13, 126);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 465);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SandyBrown;
            this.panel6.Location = new System.Drawing.Point(829, 126);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 465);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SandyBrown;
            this.panel7.Controls.Add(this.Atualizar);
            this.panel7.Controls.Add(this.Procurar);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.procutenteTextBox);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(35, 126);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(263, 315);
            this.panel7.TabIndex = 23;
            // 
            // Atualizar
            // 
            this.Atualizar.BackColor = System.Drawing.Color.Chocolate;
            this.Atualizar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualizar.ForeColor = System.Drawing.Color.White;
            this.Atualizar.Location = new System.Drawing.Point(15, 244);
            this.Atualizar.Margin = new System.Windows.Forms.Padding(4);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(96, 52);
            this.Atualizar.TabIndex = 8;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = false;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Procurar
            // 
            this.Procurar.BackColor = System.Drawing.Color.Chocolate;
            this.Procurar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procurar.ForeColor = System.Drawing.Color.White;
            this.Procurar.Location = new System.Drawing.Point(152, 244);
            this.Procurar.Margin = new System.Windows.Forms.Padding(4);
            this.Procurar.Name = "Procurar";
            this.Procurar.Size = new System.Drawing.Size(96, 52);
            this.Procurar.TabIndex = 7;
            this.Procurar.Text = "Procurar";
            this.Procurar.UseVisualStyleBackColor = false;
            this.Procurar.Click += new System.EventHandler(this.Procurar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nº de Identificação Fiscal:";
            // 
            // procutenteTextBox
            // 
            this.procutenteTextBox.BackColor = System.Drawing.Color.White;
            this.procutenteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.procutenteTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procutenteTextBox.Location = new System.Drawing.Point(84, 194);
            this.procutenteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.procutenteTextBox.Name = "procutenteTextBox";
            this.procutenteTextBox.Size = new System.Drawing.Size(95, 29);
            this.procutenteTextBox.TabIndex = 0;
            this.procutenteTextBox.TextChanged += new System.EventHandler(this.procutenteTextBox_TextChanged);
            this.procutenteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.procutenteTextBox_KeyPress);
            this.procutenteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.procutenteTextBox_Validating);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.button2);
            this.panel8.Location = new System.Drawing.Point(15, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(233, 137);
            this.panel8.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 108);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = "Procurar Utente";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(49, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 107);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 553);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 24);
            this.label10.TabIndex = 43;
            this.label10.Text = "Data da Devolução";
            // 
            // datareturnDataPicker
            // 
            this.datareturnDataPicker.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datareturnDataPicker.Location = new System.Drawing.Point(238, 553);
            this.datareturnDataPicker.Margin = new System.Windows.Forms.Padding(4);
            this.datareturnDataPicker.Name = "datareturnDataPicker";
            this.datareturnDataPicker.Size = new System.Drawing.Size(273, 27);
            this.datareturnDataPicker.TabIndex = 38;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 316);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 476);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nome do Livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 514);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Data de Requisição";
            // 
            // datareqTextBox
            // 
            this.datareqTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datareqTextBox.Location = new System.Drawing.Point(239, 514);
            this.datareqTextBox.Name = "datareqTextBox";
            this.datareqTextBox.ReadOnly = true;
            this.datareqTextBox.Size = new System.Drawing.Size(272, 27);
            this.datareqTextBox.TabIndex = 49;
            // 
            // nomelivroTextBox
            // 
            this.nomelivroTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomelivroTextBox.Location = new System.Drawing.Point(238, 476);
            this.nomelivroTextBox.Name = "nomelivroTextBox";
            this.nomelivroTextBox.ReadOnly = true;
            this.nomelivroTextBox.Size = new System.Drawing.Size(273, 27);
            this.nomelivroTextBox.TabIndex = 50;
            // 
            // Dev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 649);
            this.ControlBox = false;
            this.Controls.Add(this.nomelivroTextBox);
            this.Controls.Add(this.datareqTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Devolver);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datareturnDataPicker);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "⠀⠀⠀⠀⠀⠀⠀⠀⠀";
            this.Load += new System.EventHandler(this.Dev_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Devolver;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Procurar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox procutenteTextBox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datareturnDataPicker;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox datareqTextBox;
        private System.Windows.Forms.TextBox nomelivroTextBox;
    }
}