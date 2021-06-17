
namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Username = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Linha = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.Label();
            this.LogoUsername = new System.Windows.Forms.PictureBox();
            this.LogoPassword = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.BtLogin = new System.Windows.Forms.Button();
            this.MPCheckBox = new System.Windows.Forms.CheckBox();
            this.BtSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Linha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(44, 198);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(90, 22);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(-76, -55);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(428, 251);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // Linha
            // 
            this.Linha.Image = ((System.Drawing.Image)(resources.GetObject("Linha.Image")));
            this.Linha.Location = new System.Drawing.Point(-66, 123);
            this.Linha.Name = "Linha";
            this.Linha.Size = new System.Drawing.Size(418, 50);
            this.Linha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Linha.TabIndex = 2;
            this.Linha.TabStop = false;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(45, 255);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(89, 22);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // LogoUsername
            // 
            this.LogoUsername.Image = ((System.Drawing.Image)(resources.GetObject("LogoUsername.Image")));
            this.LogoUsername.Location = new System.Drawing.Point(12, 193);
            this.LogoUsername.Name = "LogoUsername";
            this.LogoUsername.Size = new System.Drawing.Size(29, 30);
            this.LogoUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoUsername.TabIndex = 5;
            this.LogoUsername.TabStop = false;
            // 
            // LogoPassword
            // 
            this.LogoPassword.Image = ((System.Drawing.Image)(resources.GetObject("LogoPassword.Image")));
            this.LogoPassword.Location = new System.Drawing.Point(12, 250);
            this.LogoPassword.Name = "LogoPassword";
            this.LogoPassword.Size = new System.Drawing.Size(29, 30);
            this.LogoPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPassword.TabIndex = 6;
            this.LogoPassword.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(138, 253);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(146, 27);
            this.passwordTextBox.TabIndex = 7;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(138, 196);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(146, 27);
            this.usernameTextBox.TabIndex = 8;
            // 
            // BtLogin
            // 
            this.BtLogin.BackColor = System.Drawing.Color.Chocolate;
            this.BtLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtLogin.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLogin.ForeColor = System.Drawing.Color.White;
            this.BtLogin.Location = new System.Drawing.Point(163, 344);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(111, 54);
            this.BtLogin.TabIndex = 9;
            this.BtLogin.Text = "Login";
            this.BtLogin.UseVisualStyleBackColor = false;
            this.BtLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // MPCheckBox
            // 
            this.MPCheckBox.AutoSize = true;
            this.MPCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPCheckBox.Location = new System.Drawing.Point(163, 285);
            this.MPCheckBox.Name = "MPCheckBox";
            this.MPCheckBox.Size = new System.Drawing.Size(121, 20);
            this.MPCheckBox.TabIndex = 10;
            this.MPCheckBox.Text = "Mostrar password";
            this.MPCheckBox.UseVisualStyleBackColor = true;
            this.MPCheckBox.CheckedChanged += new System.EventHandler(this.MPCheckBox_CheckedChanged);
            // 
            // BtSair
            // 
            this.BtSair.BackColor = System.Drawing.Color.Chocolate;
            this.BtSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtSair.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSair.ForeColor = System.Drawing.Color.White;
            this.BtSair.Location = new System.Drawing.Point(23, 344);
            this.BtSair.Name = "BtSair";
            this.BtSair.Size = new System.Drawing.Size(111, 54);
            this.BtSair.TabIndex = 12;
            this.BtSair.Text = "Sair";
            this.BtSair.UseVisualStyleBackColor = false;
            this.BtSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(296, 441);
            this.ControlBox = false;
            this.Controls.Add(this.BtSair);
            this.Controls.Add(this.MPCheckBox);
            this.Controls.Add(this.BtLogin);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.LogoPassword);
            this.Controls.Add(this.LogoUsername);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Linha);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Linha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox Linha;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.PictureBox LogoUsername;
        private System.Windows.Forms.PictureBox LogoPassword;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button BtLogin;
        private System.Windows.Forms.CheckBox MPCheckBox;
        private System.Windows.Forms.Button BtSair;
    }
}