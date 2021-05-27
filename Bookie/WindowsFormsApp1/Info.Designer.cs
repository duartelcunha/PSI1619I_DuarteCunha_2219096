
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Atualiza = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.Sair);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 86);
            this.panel1.TabIndex = 0;
            // 
            // Sair
            // 
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.ForeColor = System.Drawing.Color.SandyBrown;
            this.Sair.Image = ((System.Drawing.Image)(resources.GetObject("Sair.Image")));
            this.Sair.Location = new System.Drawing.Point(1135, 26);
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
            this.pictureBox1.Location = new System.Drawing.Point(20, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Location = new System.Drawing.Point(12, 477);
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
            this.dataGridView1.Location = new System.Drawing.Point(32, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1145, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(449, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 29);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Utente:";
            // 
            // Atualiza
            // 
            this.Atualiza.AutoSize = true;
            this.Atualiza.BackColor = System.Drawing.Color.White;
            this.Atualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atualiza.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualiza.ForeColor = System.Drawing.Color.White;
            this.Atualiza.Image = ((System.Drawing.Image)(resources.GetObject("Atualiza.Image")));
            this.Atualiza.Location = new System.Drawing.Point(733, 99);
            this.Atualiza.Margin = new System.Windows.Forms.Padding(4);
            this.Atualiza.Name = "Atualiza";
            this.Atualiza.Size = new System.Drawing.Size(46, 40);
            this.Atualiza.TabIndex = 20;
            this.Atualiza.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SandyBrown;
            this.panel6.Location = new System.Drawing.Point(12, 98);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(14, 373);
            this.panel6.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Location = new System.Drawing.Point(1183, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 373);
            this.panel3.TabIndex = 33;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1209, 507);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Atualiza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "⠀⠀⠀⠀⠀⠀⠀⠀⠀";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Atualiza;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
    }
}