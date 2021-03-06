using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            using (SqlConnection con = new SqlConnection())
            {
             con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
           
             try
             {

                    if (string.IsNullOrEmpty(nomelivroTextBox.Text) || string.IsNullOrEmpty(nomeautorTextBox.Text) || string.IsNullOrEmpty(anoTextBox.Text) || string.IsNullOrEmpty(quantidadeTextBox.Text) || string.IsNullOrEmpty(categoriaTextBox.Text) || string.IsNullOrEmpty(linguagemTextBox.Text))
                    {
                        MessageBox.Show("Preencha todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;

                        con.Open();
                        cmd.CommandText = "INSERT INTO Livro (Nome,Autor,Ano,Quantidade,Categoria,Linguagem) VALUES (@Nome,@Autor,@Ano,@Quantidade,@Categoria,@Linguagem)";
                        cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = nomelivroTextBox.Text;
                        cmd.Parameters.Add("@Autor", SqlDbType.VarChar).Value = nomeautorTextBox.Text;
                        cmd.Parameters.Add("@Ano", SqlDbType.VarChar).Value = anoTextBox.Text;
                        cmd.Parameters.Add("@Quantidade", SqlDbType.VarChar).Value = quantidadeTextBox.Text;
                        cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = categoriaTextBox.Text;
                        cmd.Parameters.Add("@Linguagem", SqlDbType.VarChar).Value = linguagemTextBox.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Livro Inserido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    nomelivroTextBox.Clear();
                    nomeautorTextBox.Clear();
                    nomelivroTextBox.Clear();
                    anoTextBox.Clear();
                    categoriaTextBox.Clear();
                    quantidadeTextBox.Clear();
                    linguagemTextBox.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message , "Erro no Evento: Inserir_Click", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todos os campos serão apagados", "Confirmação",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }


        private void PT_Click(object sender, EventArgs e)
        {
            this.Close();
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
            this.anoTextBox.MaxLength = 4;

            if (System.Text.RegularExpressions.Regex.IsMatch(anoTextBox.Text, "  ^ [0-9]"))
            {
                anoTextBox.Text = "";
            }
        }

        private void anoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (anoTextBox.Text.Length == 0) return;

            if (anoTextBox.Text.Length < 4)
            {
                e.Cancel = true;
                MessageBox.Show("Digite 4 números", "Ano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(Int32.Parse(anoTextBox.Text) > 2021)
            {
                MessageBox.Show("Digite um ano válido", "Ano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void quantidadeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void quantidadeTextBox_TextChanged(object sender, EventArgs e)
        {
            this.quantidadeTextBox.MaxLength = 5;

            if (System.Text.RegularExpressions.Regex.IsMatch(quantidadeTextBox.Text, "  ^ [0-9]"))
            {
                quantidadeTextBox.Text = "";
            }
        }

        private void quantidadeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (quantidadeTextBox.Text.Length == 0) return;

            if (quantidadeTextBox.Text.Length < 0)
            {
                e.Cancel = true;
                MessageBox.Show("Digite pelo menos 1 número", "Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     
    }
}
