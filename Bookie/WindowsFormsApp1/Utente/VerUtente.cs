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
    public partial class VerUtilizador : Form
    {
        public VerUtilizador()
        {
            InitializeComponent();
           

        }
       

        private void PT_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        int bid;
        Int64 rowid;

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            panel1.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM Utente WHERE NIF = @bid";
            cmd.Parameters.Add("@bid", SqlDbType.VarChar).Value = bid;
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0]["NIF"].ToString());


            pnTextBox.Text = ds.Tables[0].Rows[0]["Pn"].ToString();
            unTextBox.Text = ds.Tables[0].Rows[0]["Un"].ToString();
            sexoComboBox.Text = ds.Tables[0].Rows[0]["Sexo"].ToString();
            contactoTextBox.Text = ds.Tables[0].Rows[0]["Contacto"].ToString();
            emailTextBox.Text = ds.Tables[0].Rows[0]["Email"].ToString();

        }

        private void VerUtilizador_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Utente";
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Os campos serão atualizados.", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String bPN = pnTextBox.Text;
                String bUN = unTextBox.Text;
                String bSexo = sexoComboBox.Text;
                String bContacto = contactoTextBox.Text;
                String bEmail = emailTextBox.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "UPDATE Utente SET Pn = @bPN, Un = @bUN, Sexo = @bSexo, Contacto = @bContacto, Email = @bEmail WHERE NIF = @rowid";
                cmd.Parameters.Add("@bPN", SqlDbType.VarChar).Value = pnTextBox.Text;
                cmd.Parameters.Add("@bUN", SqlDbType.VarChar).Value = unTextBox.Text;
                cmd.Parameters.Add("@bSexo", SqlDbType.VarChar).Value = sexoComboBox.Text;
                cmd.Parameters.Add("@bContacto", SqlDbType.VarChar).Value = contactoTextBox.Text;
                cmd.Parameters.Add("@bEmail", SqlDbType.VarChar).Value = emailTextBox.Text;
                cmd.Parameters.Add("@rowid", SqlDbType.VarChar).Value = rowid;
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dt.Fill(ds);

            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("O utilizador será apagado.", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM Utente WHERE NIF  = @rowid";
                cmd.Parameters.Add("@rowid", SqlDbType.VarChar).Value = rowid;
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dt.Fill(ds);
            }
        }

        
   
        

        private void nomeuserproctextBox_TextChanged(object sender, EventArgs e)
        {
            if (nomeuserproctextBox.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Utente WHERE Pn LIKE '" + nomeuserproctextBox.Text + "%'";
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
                cmd.CommandText = "SELECT * FROM Utente";
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dt.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Atualiza_Click_1(object sender, EventArgs e)
        {
            string con = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            using (SqlConnection sqlCon = new SqlConnection(con))
            {

                string query = "SELECT * FROM Utente";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
