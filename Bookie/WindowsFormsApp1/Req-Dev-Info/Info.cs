using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Info : Form
    {

        static public int b = 0;
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;

            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "SELECT ReqID AS 'ID', ID_NIF AS 'NIF', DataReq AS 'Data de Requisição', DataEntrega AS 'Data de Entrega', NomeLivro AS 'Nome do Livro', Nome, Contacto, Email FROM Req WHERE DataReturn IS NULL";

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];

                    cmd.CommandText = "SELECT ReqID AS 'ID', ID_NIF AS 'NIF', DataReq AS 'Data de Requisição', DataReturn AS 'Data de Devolução', NomeLivro AS 'Nome do Livro', Nome, Contacto, Email FROM Req WHERE DataReturn IS NOT NULL";

                    SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);

                    dataGridView2.DataSource = ds1.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no Load: Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RefreshBD_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

                try
                {
                    string query = "SELECT ReqID AS 'ID', ID_NIF AS 'NIF', DataReq AS 'Data de Requisição', DataEntrega AS 'Data de Entrega', NomeLivro AS 'Nome do Livro', Nome, Contacto, Email FROM Req WHERE DataReturn IS NULL";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Connection = con;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    string query1 = "SELECT ReqID AS 'ID', ID_NIF AS 'NIF', DataReq AS 'Data de Requisição', DataReturn AS 'Data de Devolução', NomeLivro AS 'Nome do Livro', Nome, Contacto, Email FROM Req WHERE DataReturn IS NOT NULL";

                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.Connection = con;

                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);

                    dataGridView2.DataSource = dt1;

                    procnifTextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro no Evento: RefreshBD_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

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
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                try
                {
                    if (MessageBox.Show("Tem a certeza que deseja eliminar a(s) linha(s) selecionada(s)?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
                        {


                            SqlCommand cmd = con.CreateCommand();
                            int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                            con.Open();
                            cmd.CommandText = "DELETE FROM Req WHERE ReqID = @ID";
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                            dataGridView2.Rows.RemoveAt(this.dataGridView2.SelectedRows[0].Index);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro no Evento: Apagar_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }


        private void Procurar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                try
                {
                    if (procnifTextBox.Text != "")
                    {

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT ReqID AS 'ID', ID_NIF AS 'NIF', DataReq AS 'Data de Requisição', DataEntrega AS 'Data de Entrega', NomeLivro AS 'Nome do Livro', Nome, Contacto, Email FROM Req WHERE ID_NIF LIKE @NIF AND DataReturn IS NULL";
                        cmd.Parameters.Add("@NIF", SqlDbType.VarChar).Value = $"{procnifTextBox.Text}%";


                        SqlDataAdapter dt = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        dt.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];

                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = con;
                        cmd2.CommandText = "SELECT ReqID AS 'ID', ID_NIF AS 'NIF', DataReq AS 'Data de Requisição', DataReturn AS 'Data de Devolução', NomeLivro AS 'Nome do Livro', Nome, Contacto, Email FROM Req WHERE ID_NIF LIKE @NIF AND DataReturn IS NOT NULL";
                        cmd2.Parameters.Add("@NIF", SqlDbType.VarChar).Value = $"{procnifTextBox.Text}%";


                        SqlDataAdapter dt1 = new SqlDataAdapter(cmd2);
                        DataSet ds1 = new DataSet();
                        dt1.Fill(ds1);

                        dataGridView2.DataSource = ds1.Tables[0];
                    }
                    else
                    {

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT ReqID AS 'ID', ID_NIF AS 'NIF', DataReq AS 'Data de Requisição', DataEntrega AS 'Data de Entrega', NomeLivro AS 'Nome do Livro', Nome, Contacto, Email FROM Req WHERE DataReturn IS NULL";

                        SqlDataAdapter dt = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        dt.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];

                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = con;
                        cmd2.CommandText = "SELECT ReqID AS 'ID', ID_NIF AS 'NIF', DataReq AS 'Data de Requisição', DataReturn AS 'Data de Devolução', NomeLivro AS 'Nome do Livro', Nome, Contacto, Email FROM Req WHERE DataReturn IS NOT NULL";

                        SqlDataAdapter dt1 = new SqlDataAdapter(cmd2);
                        DataSet ds1 = new DataSet();
                        dt1.Fill(ds1);

                        dataGridView2.DataSource = ds1.Tables[0];

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro no Evento: Procurar_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerUtente_Click(object sender, EventArgs e)
        {
            var a = new VerUtente();
            this.Close();
            a.Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (b == 1)
            {

                Dev frm2 = new Dev();

                frm2.datareqTextBox.Text = dataGridView1.CurrentRow.Cells["Data de Requisição"].Value.ToString();
                frm2.nomelivroTextBox.Text = dataGridView1.CurrentRow.Cells["Nome do Livro"].Value.ToString();
                frm2.nifTextBox.Text = dataGridView1.CurrentRow.Cells["NIF"].Value.ToString();
                frm2.idTextBox.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

                this.Close();
                frm2.Show();
            }
            else if (b == 0)
            {

            }
            
        }

        private void procnifTextBox_TextChanged(object sender, EventArgs e)
        {

            this.procnifTextBox.MaxLength = 9;

            if (System.Text.RegularExpressions.Regex.IsMatch(procnifTextBox.Text, "  ^ [0-9]"))
            {
                procnifTextBox.Text = "";
            }

        }

        private void procnifTextBox_Validating(object sender, CancelEventArgs e)
        {

            if (procnifTextBox.Text.Length == 0) return;

            if (procnifTextBox.Text.Length < 9)
            {
                e.Cancel = true;
                MessageBox.Show("Digite 9 números", "NIF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void procnifTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
 }


