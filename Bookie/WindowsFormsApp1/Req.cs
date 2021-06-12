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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Req : Form
    {
       

        public Req()
        {
            InitializeComponent();
          
        }

        int count;
        private void Requisitar_Load(object sender, EventArgs e)
        {

            nomelivroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            nomelivroComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            nomelivroComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd = new SqlCommand("SELECT Nome FROM Livro", con);

            cmd.CommandText = "SELECT * FROM Utente WHERE NIF = @NIF";
            cmd.Parameters.Add("@NIF", SqlDbType.VarChar).Value = nifTextBox.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.CommandText = "SELECT COUNT(ID_NIF) FROM Req WHERE ID_NIF = @NIF AND DataReturn IS NULL";

            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);

            count = int.Parse(ds2.Tables[0].Rows[0][0].ToString());

            con.Close();
        }
       
        private void Req_Click(object sender, EventArgs e)
        {
           
            if (nifTextBox.Text != "")
            {
               
              if (nomelivroComboBox.SelectedIndex != -1 && count <= 2)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = cmd.CommandText = "INSERT INTO Req (ID_NIF,Nome,Email,NomeLivro,Contacto,DataReq,DataEntrega) VALUES (@NIF,@nome,@email,@nl,@contacto,@datareq,@dataentrega)";

                    cmd.Parameters.Add("@dataentrega", SqlDbType.VarChar).Value = datareqDataPicker.Value.AddDays(7).ToString("dd/MM/yyyy");
                    cmd.Parameters.Add("@NIF", SqlDbType.Int).Value = nifTextBox.Text;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nomecompletoTextBox.Text;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = emailTextBox.Text;
                    cmd.Parameters.Add("@nl", SqlDbType.VarChar).Value = nomelivroComboBox.Text;
                    cmd.Parameters.Add("@contacto", SqlDbType.VarChar).Value = contactoTextBox.Text;
                    cmd.Parameters.Add("@datareq", SqlDbType.VarChar).Value = datareqDataPicker.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    if (MessageBox.Show("Deseja criar um recibo?", "Requisição", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                        {
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A6);
                                try
                                {
                                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                                    doc.Open();
                                    doc.Add(new iTextSharp.text.Paragraph("BOOKIE"));
                                    doc.Add(new iTextSharp.text.Paragraph($"NIF: {this.nifTextBox.Text.Trim()}"));
                                    doc.Add(new iTextSharp.text.Paragraph($"Nome: {this.nomecompletoTextBox.Text.Trim()}"));
                                    doc.Add(new iTextSharp.text.Paragraph($"Livro: {this.nomelivroComboBox.Text.Trim()}"));
                                    doc.Add(new iTextSharp.text.Paragraph($"Data de Requisição: {this.datareqDataPicker.Text.Trim()}"));
                                    doc.Add(new iTextSharp.text.Paragraph($"Data de Entrega: {this.datareqDataPicker.Value.AddDays(7).ToString("dd/MM/yyyy")}"));
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                finally
                                {
                                    doc.Close();
                                }
                            }
                        }


                        MessageBox.Show("PDF com informações criado", "Requisição", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MessageBox.Show("Livro Requisitado", "Requisição", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Ref();
                    }
                    else
                    {
                        MessageBox.Show("Livro Requisitado", "Requisição", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Ref();
                    }
                }
                else
                {
                    MessageBox.Show("Escolha um livro / O número máximo de livros foi requisitado para este utente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Indique um NIF válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       

       

        public void Ref()
        {
            nifTextBox.Clear();
            nomecompletoTextBox.Clear();
            contactoTextBox.Clear();
            emailTextBox.Clear();
            nomelivroComboBox.SelectedIndex = -1;
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            Ref();
        }
        private void PT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProcButton_Click_1(object sender, EventArgs e)
        {
       
            var a = new VerUtilizador();
            this.Close();
            a.Show();
            
        }
    }
}
