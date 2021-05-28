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
            cmd.CommandText = "SELECT * FROM Livro";
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
               
            }
            panel1.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Livro WHERE LivroID = @bid";
            cmd.Parameters.Add("@bid", SqlDbType.VarChar).Value = bid;
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            nomelivrotextBox.Text = ds.Tables[0].Rows[0]["Livro"].ToString();
            nomeautortextBox.Text = ds.Tables[0].Rows[0]["Autor"].ToString();
            anotextBox.Text = ds.Tables[0].Rows[0]["Ano"].ToString();
            precotextBox.Text = ds.Tables[0].Rows[0]["Aluguer"].ToString();
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
                cmd.CommandText = "SELECT * FROM Livro WHERE Nome LIKE '" + nomelivroproctextBox.Text+"%'";     
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
                cmd.CommandText = "SELECT * FROM Livro";
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dt.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Atualiza_Click(object sender, EventArgs e)
        {
            string con = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            using (SqlConnection sqlCon = new SqlConnection(con))
            {

                string query = "SELECT * FROM Livro";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Os campos serão atualizados.", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Livro SET Nome = @bNome, Autor = @bAutor, Ano = @bAno, Aluguer = @Aluguer, Quantidade = @Quantidade WHERE LivroID = @rowid";
                cmd.Parameters.Add("@bNome", SqlDbType.VarChar).Value = nomelivrotextBox.Text;
                cmd.Parameters.Add("@bAutor", SqlDbType.VarChar).Value = nomeautortextBox.Text;
                cmd.Parameters.Add("@bAno", SqlDbType.VarChar).Value = Int64.Parse(anotextBox.Text);
                cmd.Parameters.Add("@Aluguer", SqlDbType.VarChar).Value = Int64.Parse(precotextBox.Text);
                cmd.Parameters.Add("@Quantidade", SqlDbType.VarChar).Value = Int64.Parse(qtdtextBox.Text);
                cmd.Parameters.Add("@rowid", SqlDbType.VarChar).Value = rowid;
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
                cmd.CommandText = "DELETE FROM Livro WHERE LivroID  = @rowid";
                cmd.Parameters.Add("@rowid", SqlDbType.VarChar).Value = rowid;
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

