
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
            this.Header = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Devolver = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ProcInfo = new System.Windows.Forms.Label();
            this.Procurar = new System.Windows.Forms.Button();
            this.DataDev = new System.Windows.Forms.Label();
            this.datareturnDataPicker = new System.Windows.Forms.DateTimePicker();
            this.NomeLivro = new System.Windows.Forms.Label();
            this.DataReq = new System.Windows.Forms.Label();
            this.datareqTextBox = new System.Windows.Forms.TextBox();
            this.nomelivroTextBox = new System.Windows.Forms.TextBox();
            this.NIF = new System.Windows.Forms.Label();
            this.nifTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.Sair);
            this.panel1.Controls.Add(this.Header);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.ForeColor = System.Drawing.Color.SandyBrown;
            this.panel1.Location = new System.Drawing.Point(13, 0);
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
            this.Sair.Location = new System.Drawing.Point(760, 31);
            this.Sair.Margin = new System.Windows.Forms.Padding(4);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(46, 52);
            this.Sair.TabIndex = 26;
            this.Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(87, 32);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(299, 39);
            this.Header.TabIndex = 17;
            this.Header.Text = "Devolução de Livro";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(16, 16);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(63, 67);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Devolver
            // 
            this.Devolver.BackColor = System.Drawing.Color.Chocolate;
            this.Devolver.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devolver.ForeColor = System.Drawing.Color.White;
            this.Devolver.Location = new System.Drawing.Point(674, 349);
            this.Devolver.Name = "Devolver";
            this.Devolver.Size = new System.Drawing.Size(116, 59);
            this.Devolver.TabIndex = 32;
            this.Devolver.Text = "Devolver";
            this.Devolver.UseVisualStyleBackColor = false;
            this.Devolver.Click += new System.EventHandler(this.Devolver_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SandyBrown;
            this.panel4.Location = new System.Drawing.Point(12, 432);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(832, 33);
            this.panel4.TabIndex = 46;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SandyBrown;
            this.panel5.Location = new System.Drawing.Point(13, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 313);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SandyBrown;
            this.panel6.Location = new System.Drawing.Point(829, 113);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 313);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SandyBrown;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(56, 130);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(230, 225);
            this.panel7.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.ProcInfo);
            this.panel8.Controls.Add(this.Procurar);
            this.panel8.Location = new System.Drawing.Point(14, 17);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(202, 188);
            this.panel8.TabIndex = 6;
            // 
            // ProcInfo
            // 
            this.ProcInfo.AutoSize = true;
            this.ProcInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcInfo.Location = new System.Drawing.Point(15, 155);
            this.ProcInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProcInfo.Name = "ProcInfo";
            this.ProcInfo.Size = new System.Drawing.Size(177, 22);
            this.ProcInfo.TabIndex = 7;
            this.ProcInfo.Text = "Procurar Informação";
            // 
            // Procurar
            // 
            this.Procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Procurar.ForeColor = System.Drawing.Color.White;
            this.Procurar.Image = ((System.Drawing.Image)(resources.GetObject("Procurar.Image")));
            this.Procurar.Location = new System.Drawing.Point(0, 0);
            this.Procurar.Name = "Procurar";
            this.Procurar.Size = new System.Drawing.Size(202, 147);
            this.Procurar.TabIndex = 8;
            this.Procurar.UseVisualStyleBackColor = true;
            this.Procurar.Click += new System.EventHandler(this.Procurar_Click);
            // 
            // DataDev
            // 
            this.DataDev.AutoSize = true;
            this.DataDev.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataDev.Location = new System.Drawing.Point(324, 302);
            this.DataDev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataDev.Name = "DataDev";
            this.DataDev.Size = new System.Drawing.Size(171, 24);
            this.DataDev.TabIndex = 43;
            this.DataDev.Text = "Data da Devolução";
            // 
            // datareturnDataPicker
            // 
            this.datareturnDataPicker.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datareturnDataPicker.Location = new System.Drawing.Point(503, 297);
            this.datareturnDataPicker.Margin = new System.Windows.Forms.Padding(4);
            this.datareturnDataPicker.Name = "datareturnDataPicker";
            this.datareturnDataPicker.Size = new System.Drawing.Size(287, 29);
            this.datareturnDataPicker.TabIndex = 38;
            this.datareturnDataPicker.Value = new System.DateTime(2021, 6, 17, 16, 18, 46, 0);
            // 
            // NomeLivro
            // 
            this.NomeLivro.AutoSize = true;
            this.NomeLivro.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeLivro.Location = new System.Drawing.Point(360, 197);
            this.NomeLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NomeLivro.Name = "NomeLivro";
            this.NomeLivro.Size = new System.Drawing.Size(136, 24);
            this.NomeLivro.TabIndex = 47;
            this.NomeLivro.Text = "Nome do Livro";
            // 
            // DataReq
            // 
            this.DataReq.AutoSize = true;
            this.DataReq.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataReq.Location = new System.Drawing.Point(323, 251);
            this.DataReq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataReq.Name = "DataReq";
            this.DataReq.Size = new System.Drawing.Size(173, 24);
            this.DataReq.TabIndex = 48;
            this.DataReq.Text = "Data de Requisição";
            // 
            // datareqTextBox
            // 
            this.datareqTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datareqTextBox.Location = new System.Drawing.Point(503, 249);
            this.datareqTextBox.Name = "datareqTextBox";
            this.datareqTextBox.ReadOnly = true;
            this.datareqTextBox.Size = new System.Drawing.Size(288, 29);
            this.datareqTextBox.TabIndex = 49;
            // 
            // nomelivroTextBox
            // 
            this.nomelivroTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomelivroTextBox.Location = new System.Drawing.Point(503, 197);
            this.nomelivroTextBox.Name = "nomelivroTextBox";
            this.nomelivroTextBox.ReadOnly = true;
            this.nomelivroTextBox.Size = new System.Drawing.Size(289, 29);
            this.nomelivroTextBox.TabIndex = 50;
            // 
            // NIF
            // 
            this.NIF.AutoSize = true;
            this.NIF.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIF.Location = new System.Drawing.Point(457, 149);
            this.NIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NIF.Name = "NIF";
            this.NIF.Size = new System.Drawing.Size(39, 24);
            this.NIF.TabIndex = 51;
            this.NIF.Text = "NIF";
            // 
            // nifTextBox
            // 
            this.nifTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nifTextBox.Location = new System.Drawing.Point(504, 147);
            this.nifTextBox.Name = "nifTextBox";
            this.nifTextBox.ReadOnly = true;
            this.nifTextBox.Size = new System.Drawing.Size(288, 29);
            this.nifTextBox.TabIndex = 52;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(268, 538);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(288, 29);
            this.idTextBox.TabIndex = 53;
            // 
            // Dev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 472);
            this.ControlBox = false;
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Devolver);
            this.Controls.Add(this.nifTextBox);
            this.Controls.Add(this.NIF);
            this.Controls.Add(this.nomelivroTextBox);
            this.Controls.Add(this.datareqTextBox);
            this.Controls.Add(this.DataReq);
            this.Controls.Add(this.NomeLivro);
            this.Controls.Add(this.DataDev);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
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
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button Devolver;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label ProcInfo;
        private System.Windows.Forms.Button Procurar;
        private System.Windows.Forms.Label DataDev;
        private System.Windows.Forms.DateTimePicker datareturnDataPicker;
        private System.Windows.Forms.Label NomeLivro;
        private System.Windows.Forms.Label DataReq;
        public System.Windows.Forms.TextBox datareqTextBox;
        public System.Windows.Forms.TextBox nomelivroTextBox;
        private System.Windows.Forms.Label NIF;
        public System.Windows.Forms.TextBox nifTextBox;
        public System.Windows.Forms.TextBox idTextBox;
    }
}