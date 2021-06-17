
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
            this.Header = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.procnifTextBox = new System.Windows.Forms.TextBox();
            this.NIF = new System.Windows.Forms.Label();
            this.RefreshBD = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Apagar = new System.Windows.Forms.Button();
            this.Procurar = new System.Windows.Forms.Button();
            this.VerUtente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.Sair);
            this.panel1.Controls.Add(this.Header);
            this.panel1.Controls.Add(this.Logo);
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
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(91, 26);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(199, 39);
            this.Header.TabIndex = 28;
            this.Header.Text = "Informações";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(20, 14);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(63, 63);
            this.Logo.TabIndex = 27;
            this.Logo.TabStop = false;
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
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(36, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(533, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // procnifTextBox
            // 
            this.procnifTextBox.AllowDrop = true;
            this.procnifTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.procnifTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procnifTextBox.Location = new System.Drawing.Point(81, 108);
            this.procnifTextBox.Name = "procnifTextBox";
            this.procnifTextBox.Size = new System.Drawing.Size(101, 29);
            this.procnifTextBox.TabIndex = 2;
            this.procnifTextBox.TextChanged += new System.EventHandler(this.procnifTextBox_TextChanged);
            this.procnifTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.procnifTextBox_KeyPress);
            this.procnifTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.procnifTextBox_Validating);
            // 
            // NIF
            // 
            this.NIF.AutoSize = true;
            this.NIF.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIF.Location = new System.Drawing.Point(32, 110);
            this.NIF.Name = "NIF";
            this.NIF.Size = new System.Drawing.Size(43, 22);
            this.NIF.TabIndex = 3;
            this.NIF.Text = "NIF:";
            // 
            // RefreshBD
            // 
            this.RefreshBD.AutoSize = true;
            this.RefreshBD.BackColor = System.Drawing.Color.White;
            this.RefreshBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBD.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBD.ForeColor = System.Drawing.Color.White;
            this.RefreshBD.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBD.Image")));
            this.RefreshBD.Location = new System.Drawing.Point(576, 315);
            this.RefreshBD.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshBD.Name = "RefreshBD";
            this.RefreshBD.Size = new System.Drawing.Size(43, 51);
            this.RefreshBD.TabIndex = 20;
            this.RefreshBD.UseVisualStyleBackColor = false;
            this.RefreshBD.Click += new System.EventHandler(this.RefreshBD_Click);
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
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersHeight = 45;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(626, 179);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 35;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // VerUtente
            // 
            this.VerUtente.AutoSize = true;
            this.VerUtente.BackColor = System.Drawing.Color.White;
            this.VerUtente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerUtente.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerUtente.ForeColor = System.Drawing.Color.White;
            this.VerUtente.Image = ((System.Drawing.Image)(resources.GetObject("VerUtente.Image")));
            this.VerUtente.Location = new System.Drawing.Point(576, 263);
            this.VerUtente.Margin = new System.Windows.Forms.Padding(4);
            this.VerUtente.Name = "VerUtente";
            this.VerUtente.Size = new System.Drawing.Size(43, 40);
            this.VerUtente.TabIndex = 40;
            this.VerUtente.UseVisualStyleBackColor = false;
            this.VerUtente.Click += new System.EventHandler(this.VerUtente_Click);
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
            this.Controls.Add(this.RefreshBD);
            this.Controls.Add(this.NIF);
            this.Controls.Add(this.procnifTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Apagar);
            this.Controls.Add(this.VerUtente);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "⠀⠀⠀⠀⠀⠀⠀⠀⠀";
            this.Load += new System.EventHandler(this.Info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.PictureBox Logo;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox procnifTextBox;
        private System.Windows.Forms.Label NIF;
        private System.Windows.Forms.Button RefreshBD;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Apagar;
        private System.Windows.Forms.Button Procurar;
        private System.Windows.Forms.Button VerUtente;
    }
}