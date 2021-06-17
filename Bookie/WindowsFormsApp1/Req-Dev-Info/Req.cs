using System;
using System.Data;
using System.Drawing;
using System.Text;
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

        int count;
        public Req()
        {
            InitializeComponent();
        }

        private void Requisitar_Load(object sender, EventArgs e)
        {

            nomelivroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            nomelivroComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            nomelivroComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                try
                {
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


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro no Load: Requisitar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Req_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                try
                {
                    if (nifTextBox.Text != "")
                    {

                        int qtd = 0;

                        cmd = new SqlCommand("SELECT * FROM Livro WHERE Nome = @Nome", con);
                        cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = nomelivroComboBox.Text;
                        cmd.ExecuteNonQuery();


                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        qtd = int.Parse(ds.Tables[0].Rows[0]["Quantidade"].ToString());

                        if (qtd > 0)
                        {

                            cmd.CommandText = "UPDATE Livro SET Quantidade = Quantidade-1 WHERE Nome = @Nome";
                            cmd.ExecuteNonQuery();


                            if (nomelivroComboBox.SelectedIndex != -1 && count <= 2)
                            {

                                cmd.CommandText = "INSERT INTO Req (ID_NIF,Nome,Email,NomeLivro,Contacto,DataReq,DataEntrega) VALUES (@NIF,@NC,@Email,@NL,@Contacto,@Datareq,@Dataentrega)";
                                cmd.Parameters.Add("@Dataentrega", SqlDbType.VarChar).Value = datareqDataPicker.Value.AddDays(7).ToString("dd/MM/yyyy");
                                cmd.Parameters.Add("@NIF", SqlDbType.Int).Value = nifTextBox.Text;
                                cmd.Parameters.Add("@NC", SqlDbType.VarChar).Value = nomecompletoTextBox.Text;
                                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = emailTextBox.Text;
                                cmd.Parameters.Add("@NL", SqlDbType.VarChar).Value = nomelivroComboBox.Text;
                                cmd.Parameters.Add("@Contacto", SqlDbType.VarChar).Value = contactoTextBox.Text;
                                cmd.Parameters.Add("@Datareq", SqlDbType.VarChar).Value = datareqDataPicker.Value.ToString("dd/MM/yyyy");
                                cmd.ExecuteNonQuery();


                                if (MessageBox.Show("Deseja criar um recibo?", "Requisição", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                                    {
                                        if (sfd.ShowDialog() == DialogResult.OK)
                                        {
                                            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A6);
                                            try
                                            {
                                                var offset = DateTimeOffset.Now.Offset;
                                                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                                                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.NORMAL);
                                                BaseFont bf2 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                                                iTextSharp.text.Font font2 = new iTextSharp.text.Font(bf2, 14, iTextSharp.text.Font.NORMAL);
                                                PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                                                doc.Open();
                                                doc.Add(new iTextSharp.text.Paragraph("BOOKIE\n\n", font));
                                                doc.Add(new iTextSharp.text.Paragraph($"NIF: {this.nifTextBox.Text.Trim()}\n\n", font2));
                                                doc.Add(new iTextSharp.text.Paragraph($"Nome: {this.nomecompletoTextBox.Text.Trim()}\n\n", font2));
                                                doc.Add(new iTextSharp.text.Paragraph($"Livro: {this.nomelivroComboBox.Text.Trim()}\n\n", font2));
                                                doc.Add(new iTextSharp.text.Paragraph($"Data de Requisição: {this.datareqDataPicker.Value:dd/MM/yyyy}\n\n", font2));
                                                doc.Add(new iTextSharp.text.Paragraph($"Data de Entrega: {this.datareqDataPicker.Value.AddDays(7):dd/MM/yyyy}\n\n", font2));
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message, "Erro: PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            finally
                                            {
                                                doc.Close();

                                            }
                                        }
                                    }
                                    MessageBox.Show("PDF com informações criado", "Requisição", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    MessageBox.Show("Livro Requisitado", "Requisição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Livro Requisitado", "Requisição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Escolha um livro / O número máximo de livros foi requisitado para este utente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Livro indisponível", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Indique um NIF válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro no Evento: Req_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

                Ref();
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

        private void PT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProcButton_Click_1(object sender, EventArgs e)
        {
       
            var a = new VerUtente();
            this.Close();
            a.Show();
            
        }
    }
}
