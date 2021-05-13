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
        public VerLivro()
        {
            InitializeComponent();
        }

        private void VerLivro_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM NovoLivro";
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        int bid;
        Int64 rowid;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
               // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
               
            }
            panel1.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
                
            cmd.CommandText = "SELECT * FROM NovoLivro WHERE Id = "+bid+"";
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            nomelivrotextBox.Text = ds.Tables[0].Rows[0]["Livro"].ToString();
            nomeautortextBox.Text = ds.Tables[0].Rows[0]["Autor"].ToString();
            anotextBox.Text = ds.Tables[0].Rows[0]["Ano"].ToString();
            precotextBox.Text = ds.Tables[0].Rows[0]["Preco"].ToString();
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
                cmd.CommandText = "SELECT * FROM NovoLivro WHERE Livro LIKE '"+nomelivroproctextBox.Text+"%'";
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
                cmd.CommandText = "SELECT * FROM NovoLivro";
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dt.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Atualiza_Click(object sender, EventArgs e)
        {
            nomelivroproctextBox.Clear();
            panel1.Visible = false;
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Os campos serão atualizados.", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String bLivro = nomelivrotextBox.Text;
                String bAutor = nomeautortextBox.Text;
                String bAno = anotextBox.Text;
                Int64 Preco = Int64.Parse(precotextBox.Text);
                Int64 Quantidade = Int64.Parse(qtdtextBox.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "UPDATE NovoLivro SET Livro = '" + bLivro + "', Autor = '" + bAutor + "', Ano = '" + bAno + "', Preco = " + Preco + ", Quantidade = " + Quantidade + " WHERE Id = " + rowid + "";
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dt.Fill(ds);
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Os campos serão apagados.", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                String bLivro = nomelivrotextBox.Text;
                String bAutor = nomeautortextBox.Text;
                String bAno = anotextBox.Text;
                Int64 Preco = Int64.Parse(precotextBox.Text);
                Int64 Quantidade = Int64.Parse(qtdtextBox.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM NovoLivro WHERE Id  = "+rowid+"";
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dt.Fill(ds);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

