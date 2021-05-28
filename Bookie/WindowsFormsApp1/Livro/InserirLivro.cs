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
            if(nomelivroTextBox.Text!="" && nomeautorTextBox.Text!="" && anoTextBox.Text!="" && precoTextBox.Text != "" && quantidadeTextBox.Text != "")
            {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
                cmd.CommandText = "INSERT INTO Livro (Nome,Autor,Ano,Aluguer,Quantidade) VALUES (@bNome,@bAutor,@bAno,@Aluguer,@Quantidade)";
                cmd.Parameters.Add("@bNome", SqlDbType.VarChar).Value = nomelivroTextBox.Text;
                cmd.Parameters.Add("@bAutor", SqlDbType.VarChar).Value = nomeautorTextBox.Text;
                cmd.Parameters.Add("@bAno", SqlDbType.VarChar).Value = Int64.Parse(anoTextBox.Text);
                cmd.Parameters.Add("@Aluguer", SqlDbType.VarChar).Value = Int64.Parse(precoTextBox.Text);
                cmd.Parameters.Add("@Quantidade", SqlDbType.VarChar).Value = Int64.Parse(quantidadeTextBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Livro Inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nomelivroTextBox.Clear();
            nomeautorTextBox.Clear();
            nomelivroTextBox.Clear();
            anoTextBox.Clear();
            precoTextBox.Clear();
            quantidadeTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos","Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
    }
}
