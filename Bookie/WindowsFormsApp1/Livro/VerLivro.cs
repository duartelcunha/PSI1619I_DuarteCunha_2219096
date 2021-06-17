using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class VerLivro : Form
    {

        int id;
        Int64 ID;

        public VerLivro()
        {
            InitializeComponent();
        }

        private void VerLivro_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dataGridView1.ReadOnly = true;

            using (SqlConnection con = new SqlConnection())
            {
                try
                {
                    con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT LivroID AS 'ID', Nome AS 'Título', Categoria, Linguagem, Autor, Ano, Quantidade FROM Livro";

                    SqlDataAdapter dt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dt.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro no Load: VerLivro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;

                    try
                    {
                        if (e.RowIndex == -1) return;
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                        if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                        {
                            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                        }

                        panel1.Visible = true;

                        con.Open();
                        cmd.CommandText = "SELECT LivroID AS 'ID', Nome AS 'Título', Categoria, Linguagem, Autor, Ano, Quantidade FROM Livro WHERE LivroID = @ID";
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                        cmd.ExecuteReader();
                        con.Close();

                        SqlDataAdapter dt = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        dt.Fill(ds);

                        ID = Int64.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                        nomelivrotextBox.Text = ds.Tables[0].Rows[0]["Título"].ToString();
                        nomeautortextBox.Text = ds.Tables[0].Rows[0]["Autor"].ToString();
                        categoriaTextBox.Text = ds.Tables[0].Rows[0]["Categoria"].ToString();
                        linguagemTextBox.Text = ds.Tables[0].Rows[0]["Linguagem"].ToString();
                        anotextBox.Text = ds.Tables[0].Rows[0]["Ano"].ToString();
                        qtdtextBox.Text = ds.Tables[0].Rows[0]["Quantidade"].ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro no Evento: dataGridView1_CellContentClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void nomelivroproctextBox_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                try
                {
                    if (nomelivroproctextBox.Text != "")
                    {

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT LivroID AS 'ID', Nome AS 'Título', Categoria, Linguagem, Autor, Ano, Quantidade FROM Livro WHERE Nome LIKE @Nome";
                        cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = $"{nomelivroproctextBox.Text}%";

                        SqlDataAdapter dt = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        dt.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT LivroID AS 'ID', Nome AS 'Título', Categoria, Linguagem, Autor, Ano, Quantidade FROM Livro";

                        SqlDataAdapter dt = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        dt.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro no Evento: nomelivroproctextBox_TextChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RefBD()
        {
            try
            {
                string con = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";

                using (SqlConnection sqlcon = new SqlConnection(con))
                {

                    string Query = "SELECT LivroID AS 'ID', Nome AS 'Título', Categoria, Linguagem, Autor, Ano, Quantidade FROM Livro";

                    SqlCommand cmd = new SqlCommand(Query, sqlcon);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    nomelivrotextBox.Clear();
                    nomeautortextBox.Clear();
                    categoriaTextBox.Clear();
                    linguagemTextBox.Clear();
                    anotextBox.Clear();
                    qtdtextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no Evento: RefreshBD_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Atualizar_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                try
                {
                    if (MessageBox.Show("Os campos serão atualizados.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;

                        cmd.CommandText = "UPDATE Livro SET Nome = @Nome, Autor = @Autor, Categoria = @Categoria, Linguagem = @Linguagem, Ano = @Ano, Quantidade = @Quantidade WHERE LivroID = @ID";
                        cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = nomelivrotextBox.Text;
                        cmd.Parameters.Add("@Autor", SqlDbType.VarChar).Value = nomeautortextBox.Text;
                        cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = categoriaTextBox.Text;
                        cmd.Parameters.Add("@Linguagem", SqlDbType.VarChar).Value = linguagemTextBox.Text;
                        cmd.Parameters.Add("@Ano", SqlDbType.Int).Value = anotextBox.Text;
                        cmd.Parameters.Add("@Quantidade", SqlDbType.Int).Value = qtdtextBox.Text;
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro no Evento: Atualizar_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

                RefBD();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Server=tcp:devlabpm.westeurope.cloudapp.azure.com;Database=PSIM1619I_DuarteCunha_2219096;User Id=PSIM1619I_DuarteCunha_2219096;Password=4rRBFA21";
                try
                {
                    if (MessageBox.Show("Os campos serão apagados.", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;

                        cmd.CommandText = "DELETE FROM Livro WHERE LivroID  = @ID";
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro no Evento: Apagar_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

                RefBD();
            }
        }

        private void PT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
 }

