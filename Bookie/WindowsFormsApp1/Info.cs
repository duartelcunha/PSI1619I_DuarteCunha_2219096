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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Info_Load(object sender, EventArgs e)
        {

            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT ReqID AS 'ID', DataReq AS 'Data de Requisição', DataEntrega AS 'Data de Entrega', DataReturn AS 'Data de Devolução', NomeLivro AS 'Nome do Livro', Nome, Contacto, Email, ID_NIF AS 'NIF' FROM Req WHERE DataReturn IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            cmd.CommandText = "SELECT ReqID AS 'ID', DataReq AS 'Data de Requisição', DataEntrega AS 'Data de Entrega', DataReturn AS 'Data de Devolução', NomeLivro AS 'Nome do Livro', Nome, Contacto, Email, ID_NIF AS 'NIF' FROM Req WHERE DataReturn IS NOT NULL";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];

        }

        private void Atualiza_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            string query = "SELECT ReqID AS 'ID', DataReq AS 'Data de Requisição', DataReturn AS 'Data de Devolução', NomeLivro AS 'Nome do Livro', Nome, Contacto, Email, ID_NIF AS 'NIF' FROM Req WHERE DataReturn IS NULL";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            string query1 = "SELECT ReqID AS 'ID', DataReq AS 'Data de Requisição', DataReturn AS 'Data de Devolução', NomeLivro AS 'Nome do Livro', Nome, Contacto, Email, ID_NIF AS 'NIF' FROM Req WHERE DataReturn IS NOT NULL";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.Connection = con;
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.ReadOnly = true;
            
        }


        private void Apagar_Click(object sender, EventArgs e)
        {

           
            if (MessageBox.Show("Tem a certeza que deseja eliminar a linha?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
                {

                    using (SqlConnection con = new SqlConnection())
                    {
                        con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                        SqlCommand cmd = con.CreateCommand();
                        int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                        cmd.CommandText = "DELETE FROM Req WHERE ReqID = @ID";
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                        dataGridView2.Rows.RemoveAt(this.dataGridView2.SelectedRows[0].Index);
                        con.Open();
                        cmd.ExecuteNonQuery();

                    }

                }
            }
        }

        private void procutenteTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if (procutenteTextBox.Text != "")
            {
                cmd.CommandText = "SELECT ReqID AS 'ID', DataReq AS 'Data de Requisição', DataReturn AS 'Data de Devolução', NomeLivro AS 'Nome do Livro', Nome, Contacto, Email, ID_NIF AS 'NIF' FROM Req WHERE ID_NIF LIKE @NIF AND DataReturn IS NULL";
                cmd.Parameters.Add("@NIF", SqlDbType.VarChar).Value = $"{procutenteTextBox.Text}%";
               

                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (textBox1.Text != "")
            {

                cmd.CommandText = "SELECT ReqID AS 'ID', DataReq AS 'Data de Requisição',DataReturn AS 'Data de Devolução', NomeLivro AS 'Nome do Livro', Nome, Contacto, Email, ID_NIF AS 'NIF' FROM Req WHERE ID_NIF LIKE @NIF AND DataReturn IS NOT NULL";
                cmd.Parameters.Add("@NIF", SqlDbType.VarChar).Value = $"{textBox1.Text}%";
                
             
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dt.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = new VerUtilizador();
            a.Show();
        }
    }
}

