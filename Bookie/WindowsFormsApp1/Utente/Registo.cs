﻿using System;
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

        private void Registo_Load(object sender, EventArgs e)
        {
            primeiroNomeTextBox.Select();
        }


        private void Registar_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection con;
            connectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            con = new SqlConnection(connectionString);
            con.Open();
            if (string.IsNullOrEmpty(primeiroNomeTextBox.Text) || string.IsNullOrEmpty(contactoTextBox.Text) || string.IsNullOrEmpty(generoTextBox.Text) || string.IsNullOrEmpty(contactoTextBox.Text) || string.IsNullOrEmpty(contactocomboBox.Text) || string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(txtContribuinte.Text))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                string consulta = "SELECT NIF from Utente where NIF = @NIF";
                SqlCommand cmd = new SqlCommand(consulta, con);
                cmd.Parameters.AddWithValue("@NIF", txtContribuinte.Text);
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    MessageBox.Show("Usuario existe");


                }

                else
                {
                    MessageBox.Show("Usuario NÃO existe");

                    SqlCommand sqlCmd = new SqlCommand("UserAdd", con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.Add("@Pn", SqlDbType.VarChar).Value = primeiroNomeTextBox.Text.Trim();
                    sqlCmd.Parameters.Add("@Un", SqlDbType.VarChar).Value = ultimoNomeTextBox.Text.Trim();
                    sqlCmd.Parameters.Add("@Genero", SqlDbType.VarChar).Value = generoTextBox.Text.Trim();
                    sqlCmd.Parameters.Add("@Contacto", SqlDbType.VarChar).Value = contactocomboBox.Text + ' ' + contactoTextBox.Text.Trim();
                    sqlCmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = emailTextBox.Text.Trim();
                    sqlCmd.Parameters.Add("@NIF", SqlDbType.Int).Value = txtContribuinte.Text.Trim();
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Registo Completo");
                    primeiroNomeTextBox.Clear();
                    ultimoNomeTextBox.Clear();
                    contactoTextBox.Clear();
                    emailTextBox.Clear();
                    txtContribuinte.Clear();
                    generoTextBox.Items.Clear();
                    contactocomboBox.Items.Clear();
                }
            }

           
        }
        
    

        private void Cancelar_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
            
        }
       

        private void contactoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void contactoTextBox_TextChanged(object sender, EventArgs e)
        {
            this.contactoTextBox.MaxLength = 9;

            if (System.Text.RegularExpressions.Regex.IsMatch(contactoTextBox.Text, "  ^ [0-9]"))
            {
                contactoTextBox.Text = "";
            }
        }

        private void contactoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (contactoTextBox.Text.Length == 0) return;

            if (contactoTextBox.Text.Length < 9)
            {
                e.Cancel = true;
                MessageBox.Show("Digite 9 números", "Contacto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void ultimoNomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Digite letras do alfabeto", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ultimoNomeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (ultimoNomeTextBox.Text.Length == 0) return;

            if (ultimoNomeTextBox.Text.Length < 2 || ultimoNomeTextBox.Text.Length > 20)
            {
                e.Cancel = true;
                MessageBox.Show("Digite entre 2 a 20 caracteres", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void primeiroNomeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (primeiroNomeTextBox.Text.Length == 0) return;

            if (primeiroNomeTextBox.Text.Length < 2 || primeiroNomeTextBox.Text.Length > 20)
            {
                e.Cancel = true;
                MessageBox.Show("Digite entre 2 a 20 caracteres", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void primeiroNomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Digite letras do alfabeto", "Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Digite um email válido","Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtContribuinte_TextChanged(object sender, EventArgs e)
        {
            this.txtContribuinte.MaxLength = 9;

            if (System.Text.RegularExpressions.Regex.IsMatch(txtContribuinte.Text, "  ^ [0-9]"))
            {
                txtContribuinte.Text = "";
            }
        }
        private void txtContribuinte_Validating(object sender, CancelEventArgs e)
        {
            if (txtContribuinte.Text.Length == 0) return;

            if (txtContribuinte.Text.Length < 9)
            {
                e.Cancel = true;
                MessageBox.Show("Digite 9 caracteres", "NIF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
