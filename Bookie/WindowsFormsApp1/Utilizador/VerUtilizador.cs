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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     

        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            panel1.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM Registo WHERE Username = 'Username', PrimeiroNome = 'Primeiro Nome', UltimoNome = 'Último Nome', Sexo = 'Sexo', Contacto = 'Contacto', Email = 'Email' ";
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);

        }
    }
}
