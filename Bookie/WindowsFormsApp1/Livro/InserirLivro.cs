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

            
            String bLivro = nomelivroTextBox.Text;
            String bAutor = nomeautorTextBox.Text;
            String bAno = anoTextBox.Text;
            Int64 Preco = Int64.Parse(precoTextBox.Text);
            Int64 Quantidade = Int64.Parse(quantidadeTextBox.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "INSERT INTO NovoLivro (Livro,Autor,Ano,Aluguer,Quantidade) values ('" + bLivro + "','" + bAutor + "', '" + bAno + "', " + Preco + "," + Quantidade + ") ";
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

        private void InserirLivro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
