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
    public partial class InserirLivro : Form
    {
        public InserirLivro()
        {
            InitializeComponent();
        }

        

        private void Inserir_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(nomelivroTextBox.Text) && string.IsNullOrEmpty(nomeautorTextBox.Text) && string.IsNullOrEmpty(anoTextBox.Text) && string.IsNullOrEmpty(quantidadeTextBox.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "INSERT INTO Livro (Nome,Autor,Ano,Quantidade,Categoria,Linguagem) VALUES (@Nome,@Autor,@Ano,@Quantidade,@Categoria,@Linguagem)";
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = nomelivroTextBox.Text;
                cmd.Parameters.Add("@Autor", SqlDbType.VarChar).Value = nomeautorTextBox.Text;
                cmd.Parameters.Add("@Ano", SqlDbType.Int).Value = anoTextBox.Text;
                cmd.Parameters.Add("@Quantidade", SqlDbType.Int).Value = quantidadeTextBox.Text;
                cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = categoriaTextBox.Text;
                cmd.Parameters.Add("@Linguagem", SqlDbType.VarChar).Value = linguagemTextBox.Text;
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Livro Inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nomelivroTextBox.Clear();
                nomeautorTextBox.Clear();
                nomelivroTextBox.Clear();
                anoTextBox.Clear();
                categoriaTextBox.Clear();
                quantidadeTextBox.Clear();
                linguagemTextBox.Clear();
            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todos os campos serão apagados", "Tem a certeza?",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }


        private void PT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void anoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void anoTextBox_TextChanged(object sender, EventArgs e)
        {
            this.anoTextBox.MaxLength = 9;

            if (System.Text.RegularExpressions.Regex.IsMatch(anoTextBox.Text, "  ^ [0-9]"))
            {
                anoTextBox.Text = "";
            }
        }

        private void anoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (anoTextBox.Text.Length == 0) return;

            if (anoTextBox.Text.Length < 9)
            {
                e.Cancel = true;
                MessageBox.Show("Digite 4 números", "Ano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

 
    }
}
