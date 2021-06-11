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

        static public bool login = false;
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

                cmd = new SqlCommand("SELECT * FROM Login WHERE Username COLLATE Latin1_general_CS_AS = @uid and Password COLLATE Latin1_general_CS_AS = @password", con);

                con.Open();
                cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = usernameTextBox.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordTextBox.Text;
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["Password"].ToString().Equals(passwordTextBox.Text.ToString(), StringComparison.InvariantCulture))
                    {
                        UserID = reader["Username"].ToString();
                        result = "1";
                        login = true;
                    }
                    else
                    {
                        result = "Credênciais Inválidas";
                    }
                }
                else
                {
                    MessageBox.Show(" Nome de Utilizador ou Password Inválido", " Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    usernameTextBox.Clear();
                    passwordTextBox.Clear();

                    reader.Close();
                    cmd.Dispose();
                    con.Close();
                }

            }
            catch (Exception)
            { }

            if (result == "1")
            {
               this.Hide();
               var main = new Main();
               main.Show();

            }
            
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

        
    }
}
