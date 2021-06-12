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


        private void Procurar_Click(object sender, EventArgs e)
        {
            var a = new Info();
            this.Close();
            a.Show();
        }

        private void Devolver_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "UPDATE Req SET DataReturn = @DataReturn WHERE ReqID = @ReqID AND ID_NIF = @NIF";
            cmd.Parameters.Add("@DataReturn", SqlDbType.VarChar).Value = datareturnDataPicker.Text;
            cmd.Parameters.Add("@NIF", SqlDbType.Int).Value = nifTextBox.Text;
            cmd.Parameters.Add("@ReqID", SqlDbType.Int).Value = idTextBox.Text;
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Livro Devolvido", "Devolução", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Ref();
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

        private void Dev_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "SELECT * FROM Req";
        }

       
    }
}
