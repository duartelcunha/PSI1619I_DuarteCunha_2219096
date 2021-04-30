using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public string UserID = "";

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        
        public Login()
        {
            InitializeComponent();
        }

 
        private void loginButton_Click(object sender, EventArgs e)
        {
            String result = "";
            try
            {
                con = new SqlConnection(@"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21");
                cmd = new SqlCommand("SELECT * FROM registo WHERE Username=@uid and Password=@password", con);
                con.Open();
                cmd.Parameters.AddWithValue("@uid", usernameTextBox.Text.ToString());
                cmd.Parameters.AddWithValue("@password", passwordTextBox.Text.ToString());
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["Password"].ToString().Equals(passwordTextBox.Text.ToString(), StringComparison.InvariantCulture))
                    {
                        UserID = reader["Username"].ToString();
                        result = "1";
                    }
                    else
                        result = "Credênciais Inválidas";
                }
                else
                    MessageBox.Show(" Nome de Utilizador ou Password inválido", " Erro ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTextBox.Clear();
                passwordTextBox.Clear();
                reader.Close();
                cmd.Dispose();
                con.Close();

            }
            catch (Exception)
            {

            }

            if (result == "1")
            {
                this.Hide();
                var Main = new Main();
                Main.Closed += (s, args) => this.Close();
                Main.Show();

            }
            else
                MessageBox.Show(result);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(MPCheckBox.Checked == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
            usernameTextBox.Select();
        }

        private void RegistoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Registo = new Registo();
            Registo.Closed += (s, args) => this.Close();
            Registo.Show();
        }
    }
}
