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

        private void Dev_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "SELECT * FROM Req";
            con.Close();
        }

        private void Procurar_Click(object sender, EventArgs e)
        {
            var a = new Info();
            this.Close();
            a.Show();
        }

        private void Devolver_Click(object sender, EventArgs e)
        {
            int qtd;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE Req SET DataReturn = @DataReturn WHERE ReqID = @ReqID AND ID_NIF = @NIF";
                cmd.Parameters.Add("@DataReturn", SqlDbType.VarChar).Value = datareturnDataPicker.Text;
                cmd.Parameters.Add("@NIF", SqlDbType.Int).Value = nifTextBox.Text;
                cmd.Parameters.Add("@ReqID", SqlDbType.Int).Value = idTextBox.Text;
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("SELECT * FROM Livro", con);
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = nomelivroTextBox.Text;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                qtd = int.Parse(ds.Tables[0].Rows[0]["Quantidade"].ToString());

                cmd.CommandText = "UPDATE Livro SET Quantidade = Quantidade+1 WHERE Nome = @Nome";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Livro Devolvido", "Devolução", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ref();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no Botão de Devolver", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
           
        }

      
        private void Ref()
        {
            nifTextBox.Clear();
            nomelivroTextBox.Clear();
            datareqTextBox.Clear();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            nifTextBox.Clear();
            nomelivroTextBox.Clear();
            datareqTextBox.Clear();
        }


        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
