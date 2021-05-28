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
    public partial class Req : Form
    {
        public Req()
        {
            InitializeComponent();
        }

        private void Requisitar_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("SELECT Nome FROM Livro", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while(sdr.Read())
            {
                for(int i=0 ; i<sdr.FieldCount ; i++)
                {
                    nomelivroComboBox.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }




        int count;
        private void Procurar_Click(object sender, EventArgs e)
        {
            if (procutenteTextBox.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.Parameters.Add("@NIF", SqlDbType.Int).Value = procutenteTextBox.Text;

                cmd.CommandText = "SELECT * FROM Utente WHERE NIF = @NIF";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                cmd.CommandText = "SELECT Count(ID_NIF) FROM Req WHERE ID_NIF = @NIF AND DataReturn is null";
                SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);

                count = int.Parse(ds2.Tables[0].Rows[0][0].ToString());
               
                if (ds.Tables[0].Rows.Count != 0)
                {
                    nifTextBox.Text = ds.Tables[0].Rows[0]["NIF"].ToString();
                    nomecompletoTextBox.Text = $"{ds.Tables[0].Rows[0]["Pn"]} {ds.Tables[0].Rows[0]["Un"]}"; // ds.Tables[0].Rows[0]["PrimeiroNome"].ToString();
                    contactoTextBox.Text = ds.Tables[0].Rows[0]["Contacto"].ToString();
                    emailTextBox.Text = ds.Tables[0].Rows[0]["Email"].ToString();

                }
                else
                {
                    nifTextBox.Clear();
                    nomecompletoTextBox.Clear();
                    contactoTextBox.Clear();
                    emailTextBox.Clear();
                    MessageBox.Show("Número de Identificação Fiscal Inválido", "Tente Novamente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void PT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Req_Click(object sender, EventArgs e)
        {
            if(nifTextBox.Text != "")
            {
                if(nomelivroComboBox.SelectedIndex != -1 && count <=2)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = cmd.CommandText = "INSERT INTO Req (ID_NIF,Nome,Email,NomeLivro,Contacto,DataReq) VALUES (@NIF,@nome,@email,@nl,@contacto,@datareq)";

                    cmd.Parameters.Add("@NIF", SqlDbType.Int).Value = nifTextBox.Text;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nomecompletoTextBox.Text;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = emailTextBox.Text;
                    cmd.Parameters.Add("@nl", SqlDbType.VarChar).Value = nomelivroComboBox.Text;
                    cmd.Parameters.Add("@contacto", SqlDbType.Int).Value = contactoTextBox.Text;
                    cmd.Parameters.Add("@datareq", SqlDbType.VarChar).Value = datareqDataPicker.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Livro Requisitado", "Requisição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                else
                {
                    MessageBox.Show("Escolha um livro. Ou então o nº máximo de livros foi requisitado","Confirme", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }



        private void ProcButton_Click(object sender, EventArgs e)
        {
            var a = new VerUtilizador();
            a.Show();
        }

     
    }
}
