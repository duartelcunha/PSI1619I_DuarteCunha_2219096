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
using System.Text.RegularExpressions;
namespace WindowsFormsApp1
{
    public partial class Registo : Form
    {
        public Registo()
        {
            InitializeComponent();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
        private void Registo_Load(object sender, EventArgs e)
        {
            usernameTextBox.Select();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            string con = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {

                using (SqlConnection sqlCon = new SqlConnection(con))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Username", usernameTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", passwordTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PrimeiroNome", primeiroNomeTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@UltimoNome", ultimoNomeTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Sexo", sexoTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Contacto", contactoTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", emailTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@NContribuinte", txtContribuinte.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registro Completo");
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    primeiroNomeTextBox.Clear();
                    ultimoNomeTextBox.Clear();
                    contactoTextBox.Clear();
                    emailTextBox.Clear();
                    txtContribuinte.Clear();
                }
            }
            
        }

        private void Cancelar_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void contactoTextBox_TextChanged(object sender, EventArgs e)
        {
            this.contactoTextBox.MaxLength = 9;

            if (System.Text.RegularExpressions.Regex.IsMatch(contactoTextBox.Text, "  ^ [0-9]"))
            {
                contactoTextBox.Text = "";
            }
        }

        
        private void ultimoNomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Digite letras do alfabeto");
            }
        }

        private void ultimoNomeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (ultimoNomeTextBox.Text.Length == 0) return;

            if (ultimoNomeTextBox.Text.Length < 2 || ultimoNomeTextBox.Text.Length > 20)
            {
                e.Cancel = true;
                MessageBox.Show("Digite entre 2 a 20 caracteres");
            }
        }

        private void primeiroNomeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (primeiroNomeTextBox.Text.Length == 0) return;

            if (primeiroNomeTextBox.Text.Length < 2 || primeiroNomeTextBox.Text.Length > 20)
            {
                e.Cancel = true;
                MessageBox.Show("Digite entre 2 a 20 caracteres");
            }
        }

        private void primeiroNomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Digite letras do alfabeto");
            }
        }

     
        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
           
            if (passwordTextBox.Text.Length == 0) return;

            if (passwordTextBox.Text.Length < 7 || passwordTextBox.Text.Length > 15)
            {
                e.Cancel = true;
                MessageBox.Show("Digite entre 7 a 15 caracteres");
            }
        }

        private void usernameTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (usernameTextBox.Text.Length == 0) return;

            if (usernameTextBox.Text.Length < 4 || usernameTextBox.Text.Length > 20)
            {
                e.Cancel = true;
                MessageBox.Show("Digite entre 4 a 20 caracteres");
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if(Regex.IsMatch(emailTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.emailTextBox, "Digite um email válido");
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtContribuinte_TextChanged(object sender, EventArgs e)
        {
            this.txtContribuinte.MaxLength = 9;

            if (System.Text.RegularExpressions.Regex.IsMatch(txtContribuinte.Text, "  ^ [0-9]"))
            {
                txtContribuinte.Text = "";
            }
        }
    }
}
