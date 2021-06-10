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


        int id;
        Int64 ID;

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel1.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Utente WHERE NIF = @id";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);


            ID = Int64.Parse(ds.Tables[0].Rows[0]["NIF"].ToString());
            pnTextBox.Text = ds.Tables[0].Rows[0]["Pn"].ToString();
            unTextBox.Text = ds.Tables[0].Rows[0]["Un"].ToString();
            generoComboBox.Text = ds.Tables[0].Rows[0]["Genero"].ToString();
            contactoTextBox.Text = ds.Tables[0].Rows[0]["Contacto"].ToString();
            emailTextBox.Text = ds.Tables[0].Rows[0]["Email"].ToString();

        }

        private void VerUtente_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT NIF, Pn AS 'Primeiro Nome', Un AS 'Último Nome', Genero AS 'Género', Contacto, Email FROM Utente";
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Os campos serão atualizados.", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Utente SET Pn = @PN, Un = @UN, Genero = @Genero, Contacto = @Contacto, Email = @Email WHERE NIF = @ID";
                cmd.Parameters.Add("@PN", SqlDbType.VarChar).Value = pnTextBox.Text;
                cmd.Parameters.Add("@UN", SqlDbType.VarChar).Value = unTextBox.Text;
                cmd.Parameters.Add("@Genero", SqlDbType.VarChar).Value = generoComboBox.Text;
                cmd.Parameters.Add("@Contacto", SqlDbType.VarChar).Value = contactoTextBox.Text;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = emailTextBox.Text;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
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
                cmd.CommandText = "DELETE FROM Utente WHERE NIF  = @ID";
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
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
                cmd.CommandText = "SELECT * FROM Utente WHERE Pn LIKE @Nome";
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = $"{nomeuserproctextBox.Text}%";
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
            pnTextBox.Clear();
            unTextBox.Clear();
            contactoTextBox.Clear();
            emailTextBox.Clear();
        }

        private void Cancelar_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
