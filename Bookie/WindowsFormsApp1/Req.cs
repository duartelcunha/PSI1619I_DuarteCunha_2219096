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

            cmd = new SqlCommand("SELECT Livro FROM NovoLivro", con);
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
            if (ProcUtenteTextBox.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@NIF", ProcUtenteTextBox.Text.ToString());

                cmd.CommandText = "SELECT * FROM NovoUtente WHERE NIF = @NIF";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                cmd.CommandText = "SELECT Count(NIF) FROM Req WHERE NIF = @NIF AND DataReturn is null";
                SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);

                count = int.Parse(ds2.Tables[0].Rows[0][0].ToString());
               
                if (ds.Tables[0].Rows.Count != 0)
                {
                    NIFTextBox.Text = ds.Tables[0].Rows[0]["NIF"].ToString();
                    nomecompletoTextBox.Text = $"{ds.Tables[0].Rows[0]["PrimeiroNome"].ToString()} {ds.Tables[0].Rows[0]["UltimoNome"].ToString()}"; // ds.Tables[0].Rows[0]["PrimeiroNome"].ToString();
                    ContactoTextBox.Text = ds.Tables[0].Rows[0]["Contacto"].ToString();
                    emailTextBox.Text = ds.Tables[0].Rows[0]["Email"].ToString();

                }
                else
                {
                    NIFTextBox.Clear();
                    nomecompletoTextBox.Clear();
                    ContactoTextBox.Clear();
                    emailTextBox.Clear();
                    MessageBox.Show("Número de Identificação Fiscal Inválido", "Tente Novamente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Sair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Req_Click(object sender, EventArgs e)
        {
            if(NIFTextBox.Text != "")
            {
                if(nomelivroComboBox.SelectedIndex != -1 && count <=2)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.Add("@proc", SqlDbType.VarChar).Value = ProcUtenteTextBox.Text;
                    cmd.Parameters.Add("@NIF", SqlDbType.VarChar).Value = NIFTextBox.Text;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nomecompletoTextBox.Text;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = emailTextBox.Text;
                    cmd.Parameters.Add("@nl", SqlDbType.VarChar).Value = nomelivroComboBox.Text;
                    cmd.Parameters.Add("@contacto", SqlDbType.VarChar).Value = Int64.Parse(ContactoTextBox.Text);
                    cmd.Parameters.Add("@datareq", SqlDbType.VarChar).Value = datareqDataPicker.Text;
                    cmd.CommandText = cmd.CommandText = "INSERT INTO Req (NIF,NIF,Nome,Email,NomeLivro,Contacto,DataReq) VALUES (@proc,@NIF,@nome,@email,@nl,@contacto,@datareq)";
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



        private void ProcButton_Click_1(object sender, EventArgs e)
        {
            var a = new VerUtilizador();
            a.Show();
        }

 
    }
}
