
namespace WindowsFormsApp1
{
    partial class Registo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registo));
            this.Bookie = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Registar = new System.Windows.Forms.Button();
            this.Contacto = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Genero = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.generoTextBox = new System.Windows.Forms.ComboBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Pn = new System.Windows.Forms.Label();
            this.Un = new System.Windows.Forms.Label();
            this.primeiroNomeTextBox = new System.Windows.Forms.TextBox();
            this.ultimoNomeTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Logo = new System.Windows.Forms.PictureBox();
            this.NIF = new System.Windows.Forms.Label();
            this.txtContribuinte = new System.Windows.Forms.TextBox();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.contactocomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bookie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Bookie
            // 
            this.Bookie.Image = ((System.Drawing.Image)(resources.GetObject("Bookie.Image")));
            this.Bookie.Location = new System.Drawing.Point(132, 25);
            this.Bookie.Name = "Bookie";
            this.Bookie.Size = new System.Drawing.Size(168, 79);
            this.Bookie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bookie.TabIndex = 1;
            this.Bookie.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-45, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(418, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Registar
            // 
            this.Registar.BackColor = System.Drawing.Color.Chocolate;
            this.Registar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Registar.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registar.ForeColor = System.Drawing.Color.White;
            this.Registar.Location = new System.Drawing.Point(183, 466);
            this.Registar.Name = "Registar";
            this.Registar.Size = new System.Drawing.Size(120, 57);
            this.Registar.TabIndex = 9;
            this.Registar.Text = "Registar";
            this.Registar.UseVisualStyleBackColor = false;
            this.Registar.Click += new System.EventHandler(this.Registar_Click);
            // 
            // Contacto
            // 
            this.Contacto.AutoSize = true;
            this.Contacto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contacto.Location = new System.Drawing.Point(30, 312);
            this.Contacto.Name = "Contacto";
            this.Contacto.Size = new System.Drawing.Size(89, 22);
            this.Contacto.TabIndex = 11;
            this.Contacto.Text = "Contacto ";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(97, 363);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(54, 22);
            this.Email.TabIndex = 12;
            this.Email.Text = "Email";
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genero.Location = new System.Drawing.Point(83, 259);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(68, 22);
            this.Genero.TabIndex = 15;
            this.Genero.Text = "Género";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(157, 362);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(146, 25);
            this.emailTextBox.TabIndex = 16;
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // generoTextBox
            // 
            this.generoTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoTextBox.FormattingEnabled = true;
            this.generoTextBox.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.generoTextBox.Location = new System.Drawing.Point(157, 258);
            this.generoTextBox.Name = "generoTextBox";
            this.generoTextBox.Size = new System.Drawing.Size(146, 27);
            this.generoTextBox.TabIndex = 17;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.Chocolate;
            this.Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(31, 466);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(120, 57);
            this.Cancelar.TabIndex = 18;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click_1);
            // 
            // Pn
            // 
            this.Pn.AutoSize = true;
            this.Pn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pn.Location = new System.Drawing.Point(15, 158);
            this.Pn.Name = "Pn";
            this.Pn.Size = new System.Drawing.Size(136, 22);
            this.Pn.TabIndex = 19;
            this.Pn.Text = "Primeiro Nome";
            // 
            // Un
            // 
            this.Un.AutoSize = true;
            this.Un.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Un.Location = new System.Drawing.Point(30, 211);
            this.Un.Name = "Un";
            this.Un.Size = new System.Drawing.Size(121, 22);
            this.Un.TabIndex = 20;
            this.Un.Text = "Último Nome";
            // 
            // primeiroNomeTextBox
            // 
            this.primeiroNomeTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeiroNomeTextBox.Location = new System.Drawing.Point(157, 157);
            this.primeiroNomeTextBox.Name = "primeiroNomeTextBox";
            this.primeiroNomeTextBox.Size = new System.Drawing.Size(146, 25);
            this.primeiroNomeTextBox.TabIndex = 21;
            this.primeiroNomeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.primeiroNomeTextBox_KeyPress);
            this.primeiroNomeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.primeiroNomeTextBox_Validating);
            // 
            // ultimoNomeTextBox
            // 
            this.ultimoNomeTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimoNomeTextBox.Location = new System.Drawing.Point(157, 210);
            this.ultimoNomeTextBox.Name = "ultimoNomeTextBox";
            this.ultimoNomeTextBox.Size = new System.Drawing.Size(146, 25);
            this.ultimoNomeTextBox.TabIndex = 22;
            this.ultimoNomeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ultimoNomeTextBox_KeyPress);
            this.ultimoNomeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ultimoNomeTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(46, 25);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(80, 79);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 23;
            this.Logo.TabStop = false;
            // 
            // NIF
            // 
            this.NIF.AutoSize = true;
            this.NIF.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIF.Location = new System.Drawing.Point(113, 412);
            this.NIF.Name = "NIF";
            this.NIF.Size = new System.Drawing.Size(38, 22);
            this.NIF.TabIndex = 24;
            this.NIF.Text = "NIF";
            // 
            // txtContribuinte
            // 
            this.txtContribuinte.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContribuinte.Location = new System.Drawing.Point(157, 411);
            this.txtContribuinte.Name = "txtContribuinte";
            this.txtContribuinte.Size = new System.Drawing.Size(146, 25);
            this.txtContribuinte.TabIndex = 25;
            this.txtContribuinte.TextChanged += new System.EventHandler(this.txtContribuinte_TextChanged);
            this.txtContribuinte.Validating += new System.ComponentModel.CancelEventHandler(this.txtContribuinte_Validating);
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactoTextBox.Location = new System.Drawing.Point(196, 312);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(107, 25);
            this.contactoTextBox.TabIndex = 14;
            this.contactoTextBox.TextChanged += new System.EventHandler(this.contactoTextBox_TextChanged);
            this.contactoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactoTextBox_KeyPress);
            this.contactoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.contactoTextBox_Validating);
            // 
            // contactocomboBox
            // 
            this.contactocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactocomboBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactocomboBox.FormattingEnabled = true;
            this.contactocomboBox.Items.AddRange(new object[] {
            "+351 "});
            this.contactocomboBox.Location = new System.Drawing.Point(120, 310);
            this.contactocomboBox.MaxDropDownItems = 4;
            this.contactocomboBox.Name = "contactocomboBox";
            this.contactocomboBox.Size = new System.Drawing.Size(70, 27);
            this.contactocomboBox.TabIndex = 27;
            // 
            // Registo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(333, 548);
            this.ControlBox = false;
            this.Controls.Add(this.contactocomboBox);
            this.Controls.Add(this.txtContribuinte);
            this.Controls.Add(this.NIF);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.ultimoNomeTextBox);
            this.Controls.Add(this.primeiroNomeTextBox);
            this.Controls.Add(this.Un);
            this.Controls.Add(this.Pn);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.generoTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.contactoTextBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Registar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Bookie);
            this.Controls.Add(this.Contacto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Registo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Registo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bookie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Bookie;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Registar;
        private System.Windows.Forms.Label Contacto;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox generoTextBox;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label Pn;
        private System.Windows.Forms.Label Un;
        private System.Windows.Forms.TextBox primeiroNomeTextBox;
        private System.Windows.Forms.TextBox ultimoNomeTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox txtContribuinte;
        private System.Windows.Forms.Label NIF;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.ComboBox contactocomboBox;
    }
}