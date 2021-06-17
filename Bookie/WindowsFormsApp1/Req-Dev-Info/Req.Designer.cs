
namespace WindowsFormsApp1
{
    partial class Req
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Req));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PT = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.nifTextBox = new System.Windows.Forms.TextBox();
            this.nomecompletoTextBox = new System.Windows.Forms.TextBox();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProcUtente = new System.Windows.Forms.Label();
            this.ProcButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nomelivroComboBox = new System.Windows.Forms.ComboBox();
            this.datareqDataPicker = new System.Windows.Forms.DateTimePicker();
            this.NIF = new System.Windows.Forms.Label();
            this.NC = new System.Windows.Forms.Label();
            this.Contacto = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.NomeLivro = new System.Windows.Forms.Label();
            this.DataReq = new System.Windows.Forms.Label();
            this.Requisitar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.qtdTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.PT);
            this.panel1.Controls.Add(this.Header);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.ForeColor = System.Drawing.Color.SandyBrown;
            this.panel1.Location = new System.Drawing.Point(13, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 106);
            this.panel1.TabIndex = 0;
            // 
            // PT
            // 
            this.PT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PT.ForeColor = System.Drawing.Color.SandyBrown;
            this.PT.Image = ((System.Drawing.Image)(resources.GetObject("PT.Image")));
            this.PT.Location = new System.Drawing.Point(740, 32);
            this.PT.Margin = new System.Windows.Forms.Padding(4);
            this.PT.Name = "PT";
            this.PT.Size = new System.Drawing.Size(46, 41);
            this.PT.TabIndex = 26;
            this.PT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PT.UseVisualStyleBackColor = true;
            this.PT.Click += new System.EventHandler(this.PT_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(87, 32);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(302, 39);
            this.Header.TabIndex = 17;
            this.Header.Text = "Requisição de Livro";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(16, 16);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(63, 71);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // nifTextBox
            // 
            this.nifTextBox.BackColor = System.Drawing.Color.White;
            this.nifTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nifTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nifTextBox.Location = new System.Drawing.Point(223, 166);
            this.nifTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nifTextBox.Name = "nifTextBox";
            this.nifTextBox.ReadOnly = true;
            this.nifTextBox.Size = new System.Drawing.Size(277, 29);
            this.nifTextBox.TabIndex = 18;
            // 
            // nomecompletoTextBox
            // 
            this.nomecompletoTextBox.BackColor = System.Drawing.Color.White;
            this.nomecompletoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomecompletoTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomecompletoTextBox.Location = new System.Drawing.Point(223, 237);
            this.nomecompletoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomecompletoTextBox.Name = "nomecompletoTextBox";
            this.nomecompletoTextBox.ReadOnly = true;
            this.nomecompletoTextBox.Size = new System.Drawing.Size(277, 29);
            this.nomecompletoTextBox.TabIndex = 19;
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.BackColor = System.Drawing.Color.White;
            this.contactoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactoTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactoTextBox.Location = new System.Drawing.Point(223, 308);
            this.contactoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.ReadOnly = true;
            this.contactoTextBox.Size = new System.Drawing.Size(275, 29);
            this.contactoTextBox.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(546, 150);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 240);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ProcUtente);
            this.panel3.Controls.Add(this.ProcButton);
            this.panel3.Location = new System.Drawing.Point(15, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 207);
            this.panel3.TabIndex = 6;
            // 
            // ProcUtente
            // 
            this.ProcUtente.AutoSize = true;
            this.ProcUtente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcUtente.Location = new System.Drawing.Point(22, 169);
            this.ProcUtente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProcUtente.Name = "ProcUtente";
            this.ProcUtente.Size = new System.Drawing.Size(139, 22);
            this.ProcUtente.TabIndex = 7;
            this.ProcUtente.Text = "Procurar Utente";
            // 
            // ProcButton
            // 
            this.ProcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProcButton.ForeColor = System.Drawing.Color.White;
            this.ProcButton.Image = ((System.Drawing.Image)(resources.GetObject("ProcButton.Image")));
            this.ProcButton.Location = new System.Drawing.Point(0, 0);
            this.ProcButton.Name = "ProcButton";
            this.ProcButton.Size = new System.Drawing.Size(184, 166);
            this.ProcButton.TabIndex = 8;
            this.ProcButton.UseVisualStyleBackColor = true;
            this.ProcButton.Click += new System.EventHandler(this.ProcButton_Click_1);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(223, 379);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(275, 29);
            this.emailTextBox.TabIndex = 23;
            // 
            // nomelivroComboBox
            // 
            this.nomelivroComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomelivroComboBox.FormattingEnabled = true;
            this.nomelivroComboBox.ItemHeight = 21;
            this.nomelivroComboBox.Location = new System.Drawing.Point(223, 451);
            this.nomelivroComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomelivroComboBox.MaxDropDownItems = 6;
            this.nomelivroComboBox.Name = "nomelivroComboBox";
            this.nomelivroComboBox.Size = new System.Drawing.Size(277, 29);
            this.nomelivroComboBox.Sorted = true;
            this.nomelivroComboBox.TabIndex = 24;
            // 
            // datareqDataPicker
            // 
            this.datareqDataPicker.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datareqDataPicker.Location = new System.Drawing.Point(223, 518);
            this.datareqDataPicker.Margin = new System.Windows.Forms.Padding(4);
            this.datareqDataPicker.Name = "datareqDataPicker";
            this.datareqDataPicker.Size = new System.Drawing.Size(277, 29);
            this.datareqDataPicker.TabIndex = 25;
            this.datareqDataPicker.Value = new System.DateTime(2021, 6, 17, 0, 0, 0, 0);
            // 
            // NIF
            // 
            this.NIF.AutoSize = true;
            this.NIF.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIF.Location = new System.Drawing.Point(176, 167);
            this.NIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NIF.Name = "NIF";
            this.NIF.Size = new System.Drawing.Size(39, 24);
            this.NIF.TabIndex = 8;
            this.NIF.Text = "NIF";
            // 
            // NC
            // 
            this.NC.AutoSize = true;
            this.NC.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NC.Location = new System.Drawing.Point(65, 238);
            this.NC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NC.Name = "NC";
            this.NC.Size = new System.Drawing.Size(150, 24);
            this.NC.TabIndex = 26;
            this.NC.Text = "Nome Completo";
            // 
            // Contacto
            // 
            this.Contacto.AutoSize = true;
            this.Contacto.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contacto.Location = new System.Drawing.Point(128, 309);
            this.Contacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Contacto.Name = "Contacto";
            this.Contacto.Size = new System.Drawing.Size(87, 24);
            this.Contacto.TabIndex = 28;
            this.Contacto.Text = "Contacto";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(158, 380);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(57, 24);
            this.Email.TabIndex = 29;
            this.Email.Text = "Email";
            // 
            // NomeLivro
            // 
            this.NomeLivro.AutoSize = true;
            this.NomeLivro.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeLivro.Location = new System.Drawing.Point(79, 453);
            this.NomeLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NomeLivro.Name = "NomeLivro";
            this.NomeLivro.Size = new System.Drawing.Size(136, 24);
            this.NomeLivro.TabIndex = 30;
            this.NomeLivro.Text = "Nome do Livro";
            // 
            // DataReq
            // 
            this.DataReq.AutoSize = true;
            this.DataReq.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataReq.Location = new System.Drawing.Point(42, 523);
            this.DataReq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataReq.Name = "DataReq";
            this.DataReq.Size = new System.Drawing.Size(173, 24);
            this.DataReq.TabIndex = 31;
            this.DataReq.Text = "Data da Requisição";
            // 
            // Requisitar
            // 
            this.Requisitar.BackColor = System.Drawing.Color.Chocolate;
            this.Requisitar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Requisitar.ForeColor = System.Drawing.Color.White;
            this.Requisitar.Location = new System.Drawing.Point(587, 462);
            this.Requisitar.Name = "Requisitar";
            this.Requisitar.Size = new System.Drawing.Size(135, 67);
            this.Requisitar.TabIndex = 8;
            this.Requisitar.Text = "Requisitar";
            this.Requisitar.UseVisualStyleBackColor = false;
            this.Requisitar.Click += new System.EventHandler(this.Req_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SandyBrown;
            this.panel4.Location = new System.Drawing.Point(13, 587);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 40);
            this.panel4.TabIndex = 47;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SandyBrown;
            this.panel5.Location = new System.Drawing.Point(13, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 468);
            this.panel5.TabIndex = 48;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SandyBrown;
            this.panel6.Location = new System.Drawing.Point(798, 113);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 468);
            this.panel6.TabIndex = 9;
            // 
            // qtdTextBox
            // 
            this.qtdTextBox.Location = new System.Drawing.Point(607, 483);
            this.qtdTextBox.Name = "qtdTextBox";
            this.qtdTextBox.Size = new System.Drawing.Size(100, 25);
            this.qtdTextBox.TabIndex = 49;
            // 
            // Req
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 640);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Requisitar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.DataReq);
            this.Controls.Add(this.NomeLivro);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Contacto);
            this.Controls.Add(this.NC);
            this.Controls.Add(this.NIF);
            this.Controls.Add(this.datareqDataPicker);
            this.Controls.Add(this.nomelivroComboBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.contactoTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nifTextBox);
            this.Controls.Add(this.nomecompletoTextBox);
            this.Controls.Add(this.qtdTextBox);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Req";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "⠀⠀⠀⠀⠀⠀⠀⠀⠀";
            this.Load += new System.EventHandler(this.Requisitar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Header;
        public System.Windows.Forms.TextBox nifTextBox;
        public System.Windows.Forms.TextBox nomecompletoTextBox;
        public System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.Button PT;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox emailTextBox;
        public System.Windows.Forms.ComboBox nomelivroComboBox;
        private System.Windows.Forms.DateTimePicker datareqDataPicker;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ProcUtente;
        private System.Windows.Forms.Label NIF;
        private System.Windows.Forms.Label NC;
        private System.Windows.Forms.Label Contacto;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label NomeLivro;
        private System.Windows.Forms.Label DataReq;
        private System.Windows.Forms.Button Requisitar;
        private System.Windows.Forms.Button ProcButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox qtdTextBox;
    }
}