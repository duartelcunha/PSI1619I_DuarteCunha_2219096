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
    public partial class Dev : Form
    {
        public Dev()
        {
            InitializeComponent();
        }


        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Procurar_Click(object sender, EventArgs e)
        {
            if (procutenteTextBox.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT ReqID AS 'ID',ID_NIF AS 'NIF', DataReq AS 'Data de Requisição', DataReturn AS 'Data de Devolução', NomeLivro AS 'Nome do Livro', Nome, Contacto, Email FROM Req WHERE ID_NIF = @NIF AND DataReturn IS NULL";
                cmd.Parameters.Add("@NIF", SqlDbType.VarChar).Value = procutenteTextBox.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("NIF Inválido ou Nenhum Livro Requisitado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum NIF foi indicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = new VerUtilizador();
            a.Show();
        }

        Int32 ID;
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                ID = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                nomelivroTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Nome do Livro"].Value.ToString();
                datareqTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Data de Requisição"].Value.ToString();

            }
        }

        private void Devolver_Click(object sender, EventArgs e)
        {
            if (procutenteTextBox.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "UPDATE Req SET DataReturn = @DataReturn WHERE ID_NIF = @NIF AND ReqID = @ReqID";
                cmd.Parameters.Add("@DataReturn", SqlDbType.VarChar).Value = datareturnDataPicker.Text;
                cmd.Parameters.Add("@NIF", SqlDbType.VarChar).Value = procutenteTextBox.Text;
                cmd.Parameters.Add("@ReqID", SqlDbType.Int).Value = ID;
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Livro Devolvido", "Devolução", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dev_Load(this, null);
            }
            else
            {
                MessageBox.Show("Nenhum NIF foi indicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Dev_Load(object sender, EventArgs e)
        {
            procutenteTextBox.Clear();
            dataGridView1.ReadOnly = true;
        }

        private void procutenteTextBox_TextChanged(object sender, EventArgs e)
        {
            this.procutenteTextBox.MaxLength = 9;

            if (System.Text.RegularExpressions.Regex.IsMatch(procutenteTextBox.Text, "  ^ [0-9]"))
            {
                procutenteTextBox.Text = "";
            }

            if (procutenteTextBox.Text == "")
            {
                dataGridView1.DataSource = null;
            }
            nomelivroTextBox.Clear();
            datareqTextBox.Clear();
        }

     
        private void Atualizar_Click(object sender, EventArgs e)
        {
            procutenteTextBox.Clear();
            nomelivroTextBox.Clear();
            datareqTextBox.Clear();
        }

        private void procutenteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void procutenteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (procutenteTextBox.Text.Length == 0) return;

            if (procutenteTextBox.Text.Length < 9)
            {
                e.Cancel = true;
                MessageBox.Show("Digite 9 números", "NIF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
