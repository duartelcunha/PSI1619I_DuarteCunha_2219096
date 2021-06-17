
namespace WindowsFormsApp1
{
    partial class VerUtente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerUtente));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.generoComboBox = new System.Windows.Forms.ComboBox();
            this.unTextBox = new System.Windows.Forms.TextBox();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.pnTextBox = new System.Windows.Forms.TextBox();
            this.Un = new System.Windows.Forms.Label();
            this.Contacto = new System.Windows.Forms.Label();
            this.Genero = new System.Windows.Forms.Label();
            this.Pn = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Apagar = new System.Windows.Forms.Button();
            this.NIF = new System.Windows.Forms.Label();
            this.procnifTextBox = new System.Windows.Forms.TextBox();
            this.Header = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(38, 161);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(612, 342);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.generoComboBox);
            this.panel2.Controls.Add(this.unTextBox);
            this.panel2.Controls.Add(this.contactoTextBox);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(this.pnTextBox);
            this.panel2.Controls.Add(this.Un);
            this.panel2.Controls.Add(this.Contacto);
            this.panel2.Controls.Add(this.Genero);
            this.panel2.Controls.Add(this.Pn);
            this.panel2.Controls.Add(this.Email);
            this.panel2.Controls.Add(this.Atualizar);
            this.panel2.Controls.Add(this.Apagar);
            this.panel2.Location = new System.Drawing.Point(24, 509);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 184);
            this.panel2.TabIndex = 27;
            // 
            // generoComboBox
            // 
            this.generoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.generoComboBox.Location = new System.Drawing.Point(152, 124);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(121, 29);
            this.generoComboBox.TabIndex = 28;
            // 
            // unTextBox
            // 
            this.unTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unTextBox.Location = new System.Drawing.Point(151, 72);
            this.unTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.unTextBox.Name = "unTextBox";
            this.unTextBox.Size = new System.Drawing.Size(181, 29);
            this.unTextBox.TabIndex = 24;
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactoTextBox.Location = new System.Drawing.Point(439, 72);
            this.contactoTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(187, 29);
            this.contactoTextBox.TabIndex = 26;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(439, 21);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(187, 29);
            this.emailTextBox.TabIndex = 27;
            // 
            // pnTextBox
            // 
            this.pnTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTextBox.Location = new System.Drawing.Point(151, 21);
            this.pnTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnTextBox.Name = "pnTextBox";
            this.pnTextBox.Size = new System.Drawing.Size(181, 29);
            this.pnTextBox.TabIndex = 23;
            // 
            // Un
            // 
            this.Un.AutoSize = true;
            this.Un.BackColor = System.Drawing.Color.SandyBrown;
            this.Un.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Un.Location = new System.Drawing.Point(26, 76);
            this.Un.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Un.Name = "Un";
            this.Un.Size = new System.Drawing.Size(121, 22);
            this.Un.TabIndex = 16;
            this.Un.Text = "Último Nome";
            // 
            // Contacto
            // 
            this.Contacto.AutoSize = true;
            this.Contacto.BackColor = System.Drawing.Color.SandyBrown;
            this.Contacto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contacto.Location = new System.Drawing.Point(351, 76);
            this.Contacto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Contacto.Name = "Contacto";
            this.Contacto.Size = new System.Drawing.Size(84, 22);
            this.Contacto.TabIndex = 19;
            this.Contacto.Text = "Contacto";
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.BackColor = System.Drawing.Color.SandyBrown;
            this.Genero.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genero.Location = new System.Drawing.Point(79, 127);
            this.Genero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(68, 22);
            this.Genero.TabIndex = 17;
            this.Genero.Text = "Género";
            // 
            // Pn
            // 
            this.Pn.AutoSize = true;
            this.Pn.BackColor = System.Drawing.Color.SandyBrown;
            this.Pn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pn.Location = new System.Drawing.Point(10, 24);
            this.Pn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pn.Name = "Pn";
            this.Pn.Size = new System.Drawing.Size(136, 22);
            this.Pn.TabIndex = 15;
            this.Pn.Text = "Primeiro Nome";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.SandyBrown;
            this.Email.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(381, 24);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(54, 22);
            this.Email.TabIndex = 18;
            this.Email.Text = "Email";
            // 
            // Atualizar
            // 
            this.Atualizar.BackColor = System.Drawing.Color.Chocolate;
            this.Atualizar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualizar.ForeColor = System.Drawing.Color.White;
            this.Atualizar.Location = new System.Drawing.Point(527, 115);
            this.Atualizar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(99, 46);
            this.Atualizar.TabIndex = 20;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = false;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Apagar
            // 
            this.Apagar.BackColor = System.Drawing.Color.Chocolate;
            this.Apagar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apagar.ForeColor = System.Drawing.Color.White;
            this.Apagar.Location = new System.Drawing.Point(427, 115);
            this.Apagar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(96, 46);
            this.Apagar.TabIndex = 21;
            this.Apagar.Text = "Apagar";
            this.Apagar.UseVisualStyleBackColor = false;
            this.Apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // NIF
            // 
            this.NIF.AutoSize = true;
            this.NIF.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIF.Location = new System.Drawing.Point(172, 123);
            this.NIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NIF.Name = "NIF";
            this.NIF.Size = new System.Drawing.Size(129, 22);
            this.NIF.TabIndex = 29;
            this.NIF.Text = "NIF do Utente:";
            // 
            // procnifTextBox
            // 
            this.procnifTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procnifTextBox.Location = new System.Drawing.Point(305, 121);
            this.procnifTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.procnifTextBox.Name = "procnifTextBox";
            this.procnifTextBox.Size = new System.Drawing.Size(188, 27);
            this.procnifTextBox.TabIndex = 28;
            this.procnifTextBox.TextChanged += new System.EventHandler(this.procnifTextBox_TextChanged_1);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(87, 37);
            this.Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(176, 39);
            this.Header.TabIndex = 16;
            this.Header.Text = "Ver Utente";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 18);
            this.Logo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(71, 71);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 17;
            this.Logo.TabStop = false;
            // 
            // PT
            // 
            this.PT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PT.ForeColor = System.Drawing.Color.SandyBrown;
            this.PT.Image = ((System.Drawing.Image)(resources.GetObject("PT.Image")));
            this.PT.Location = new System.Drawing.Point(583, 37);
            this.PT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PT.Name = "PT";
            this.PT.Size = new System.Drawing.Size(43, 46);
            this.PT.TabIndex = 25;
            this.PT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PT.UseVisualStyleBackColor = true;
            this.PT.Click += new System.EventHandler(this.PT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.PT);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.Header);
            this.panel1.Location = new System.Drawing.Point(24, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 105);
            this.panel1.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SandyBrown;
            this.panel6.Location = new System.Drawing.Point(24, 113);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 390);
            this.panel6.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Location = new System.Drawing.Point(646, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 390);
            this.panel3.TabIndex = 31;
            // 
            // VerUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 14);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 526);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.NIF);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.procnifTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VerUtente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "⠀⠀⠀⠀⠀⠀⠀⠀⠀";
            this.Load += new System.EventHandler(this.VerUtente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox unTextBox;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox pnTextBox;
        private System.Windows.Forms.Label Un;
        private System.Windows.Forms.Label Contacto;
        private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.Label Pn;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Apagar;
        private System.Windows.Forms.Label NIF;
        private System.Windows.Forms.TextBox procnifTextBox;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button PT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox generoComboBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
    }
}