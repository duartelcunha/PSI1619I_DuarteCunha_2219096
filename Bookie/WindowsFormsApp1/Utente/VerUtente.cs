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

        int id;
        Int64 ID;
        static public int a = 0;

        public VerUtilizador()
        {
            InitializeComponent();
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            panel2.Visible = true;
          
         
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT * FROM Utente WHERE NIF = @NIF";
            cmd.Parameters.Add("@NIF", SqlDbType.Int).Value = id;
            cmd.ExecuteReader();
            con.Close();
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
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT NIF, [Pn] + ' ' + [Un] AS [Nome], Genero AS 'Género', Contacto, Email FROM Utente";
            cmd.ExecuteReader();
            con.Close();
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            try
            {
                if (MessageBox.Show("Os campos serão atualizados.", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    con.Open();
                    cmd.CommandText = "UPDATE Utente SET Pn = @Pn, Un = @Un, Genero = @Genero, Contacto = @Contacto, Email = @Email WHERE NIF = @NIF";
                    cmd.Parameters.Add("@Pn", SqlDbType.VarChar).Value = pnTextBox.Text;
                    cmd.Parameters.Add("@Un", SqlDbType.VarChar).Value = unTextBox.Text;
                    cmd.Parameters.Add("@Genero", SqlDbType.VarChar).Value = generoComboBox.Text;
                    cmd.Parameters.Add("@Contacto", SqlDbType.VarChar).Value = contactoTextBox.Text;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = emailTextBox.Text;
                    cmd.Parameters.Add("@NIF", SqlDbType.Int).Value = ID;
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter dt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dt.Fill(ds);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no Botão de Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            try
            {
                if (MessageBox.Show("O utilizador será apagado.", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    con.Open();
                    cmd.CommandText = "DELETE FROM Utente WHERE NIF  = @NIF";
                    cmd.Parameters.Add("@NIF", SqlDbType.Int).Value = ID;
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter dt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dt.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no Botão de Apagar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void procnifTextBox_TextChanged_1(object sender, EventArgs e)
        {
          
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            con.Open();
         try
           {
                if (procnifTextBox.Text != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "SELECT NIF, [Pn] + ' ' + [Un] AS [Nome], Genero AS 'Género', Contacto, Email FROM Utente WHERE NIF LIKE @NIF";
                    cmd.Parameters.Add("@NIF", SqlDbType.VarChar).Value = $"{procnifTextBox.Text}%";
                    cmd.ExecuteReader();
                    SqlDataAdapter dt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dt.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];

                }
                else
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT NIF, [Pn] + ' ' + [Un] AS [Nome], Genero AS 'Género', Contacto, Email FROM Utente";
                    cmd.ExecuteReader();
                    SqlDataAdapter dt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dt.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];
                }
         }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no procnifTextBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }




        private void Atualiza_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT NIF, [Pn] + ' ' + [Un] AS [Nome], Genero AS 'Género', Contacto, Email FROM Utente";
            cmd.ExecuteReader();
            con.Close();
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            pnTextBox.Clear();
            unTextBox.Clear();
            contactoTextBox.Clear();
            emailTextBox.Clear();
            generoComboBox.Items.Clear();
        }

        private void PT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancelar_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if (a == 1)
            {
                con.Open();

                Req req = new Req();

                req.nifTextBox.Text = dataGridView1.CurrentRow.Cells["NIF"].Value.ToString();
                req.nomecompletoTextBox.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                req.contactoTextBox.Text = dataGridView1.CurrentRow.Cells["Contacto"].Value.ToString();
                req.emailTextBox.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();

                cmd = new SqlCommand("SELECT Nome FROM Livro", con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        req.nomelivroComboBox.Items.Add(sdr.GetString(i));
                    }
                }

                sdr.Close();
                con.Close();
                this.Close();
                req.Show();
            }
            else if (a == 0)
            {
                Info info = new Info();

                info.procutenteTextBox.Text = dataGridView1.CurrentRow.Cells["NIF"].Value.ToString();

                this.Close();
                
                info.Show();
            }
            else if(a == 2)
            {
                Dev dev = new Dev();

                dev.nifTextBox.Text = dataGridView1.CurrentRow.Cells["NIF"].Value.ToString();
                this.Close();
                dev.Show();
            }

        }

      
    }

}
