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
    public partial class Requisitar : Form
    {
        public Requisitar()
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
            if (utilizadorprocTextBox.Text != "")
            {
                String username = utilizadorprocTextBox.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM NovoUtilizador WHERE Username = '" + username + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                cmd.CommandText = "SELECT Count(Username), DataReq FROM NovoUtilizador,Requisitado WHERE Username = '" + username + "' and DataReq is null";
                SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);

                count = int.Parse(ds2.Tables[0].Rows[0][0].ToString());


                if (ds.Tables[0].Rows.Count != 0)
                {
                    usernameTextBox.Text = ds.Tables[0].Rows[0]["Username"].ToString();
                    nomecompletoTextBox.Text = $"{ds.Tables[0].Rows[0]["PrimeiroNome"].ToString()} {ds.Tables[0].Rows[0]["UltimoNome"].ToString()}"; // ds.Tables[0].Rows[0]["PrimeiroNome"].ToString();
                    SexoTextBox.Text = ds.Tables[0].Rows[0]["Sexo"].ToString();
                    ContactoTextBox.Text = ds.Tables[0].Rows[0]["Contacto"].ToString();
                    emailTextBox.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                }
                else
                {
                    usernameTextBox.Clear();
                    nomecompletoTextBox.Clear();
                    SexoTextBox.Clear();
                    ContactoTextBox.Clear();
                    emailTextBox.Clear();
                    MessageBox.Show("Nome de Utilizador Inválido", "Tente Novamente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Sair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Req_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text != "")
            {
                if(nomelivroComboBox.SelectedIndex != -1 && count <=2)
                {
                    String proc = utilizadorprocTextBox.Text;
                    String user = usernameTextBox.Text;
                    String nc = nomecompletoTextBox.Text;
                    String sexo = SexoTextBox.Text;
                    String email = emailTextBox.Text;
                    String nl = nomelivroComboBox.Text;
                    Int64 contacto = Int64.Parse(ContactoTextBox.Text);
                    String datareq = datareqDataPicker.Text;

                    String username = utilizadorprocTextBox.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "INSERT Into Requisitados";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
            }
        }
    }
}
