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
    public partial class VerLivro : Form
    {

        int id;
        Int64 ID;

        public VerLivro()
        {
            InitializeComponent();
        }

        private void VerLivro_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT LivroID AS 'ID', Nome AS 'Título', Categoria, Linguagem, Autor, Ano, Quantidade FROM Livro";

            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            panel1.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT LivroID AS 'ID', Nome AS 'Título', Categoria, Linguagem, Autor, Ano, Quantidade FROM Livro WHERE LivroID = @id";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);

            ID = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            nomelivrotextBox.Text = ds.Tables[0].Rows[0]["Título"].ToString();
            nomeautortextBox.Text = ds.Tables[0].Rows[0]["Autor"].ToString();
            categoriaTextBox.Text = ds.Tables[0].Rows[0]["Categoria"].ToString();
            linguagemTextBox.Text = ds.Tables[0].Rows[0]["Linguagem"].ToString();
            anotextBox.Text = ds.Tables[0].Rows[0]["Ano"].ToString();
            qtdtextBox.Text = ds.Tables[0].Rows[0]["Quantidade"].ToString();
           
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void nomelivroproctextBox_TextChanged(object sender, EventArgs e)
        {
            if(nomelivroproctextBox.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT LivroID AS 'ID', Nome AS 'Título', Categoria, Linguagem, Autor, Ano, Quantidade FROM Livro WHERE Nome LIKE @Nome";
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = $"{nomelivroproctextBox.Text}%";

                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dt.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT LivroID AS 'ID', Nome AS 'Título', Categoria, Linguagem, Autor, Ano, Quantidade FROM Livro";

                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dt.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Atualiza_Click(object sender, EventArgs e)
        {
            string con = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

            using (SqlConnection sqlcon = new SqlConnection(con))
            {

                string Query = "SELECT LivroID AS 'ID', Nome AS 'Título', Categoria, Linguagem, Autor, Ano, Quantidade FROM Livro";

                SqlCommand cmd = new SqlCommand(Query, sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            nomelivrotextBox.Clear();
            nomeautortextBox.Clear();
            categoriaTextBox.Clear();
            linguagemTextBox.Clear();
            anotextBox.Clear();
            qtdtextBox.Clear();

        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Os campos serão atualizados.", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "UPDATE Livro SET Nome = @Nome, Autor = @Autor, Categoria = @Categoria, Linguagem = @Linguagem, Ano = @Ano, Quantidade = @Quantidade WHERE LivroID = @ID";
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = nomelivrotextBox.Text;
                cmd.Parameters.Add("@Autor", SqlDbType.VarChar).Value = nomeautortextBox.Text;
                cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = categoriaTextBox.Text;
                cmd.Parameters.Add("@Linguagem", SqlDbType.VarChar).Value = linguagemTextBox.Text;
                cmd.Parameters.Add("@Ano", SqlDbType.Int).Value = anotextBox.Text;
                cmd.Parameters.Add("@Quantidade", SqlDbType.Int).Value = qtdtextBox.Text;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                cmd.ExecuteNonQuery();
                con.Close();
       
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Os campos serão apagados.", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM Livro WHERE LivroID  = @ID";
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void PT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

