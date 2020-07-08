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

namespace Biblioteca
{
    public partial class FrmCadastroLivro : Form
    {
        public FrmCadastroLivro()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmBiblioteca frmBiblioteca = new FrmBiblioteca();
            this.Hide();
            frmBiblioteca.Show();
        }

        private void btnCadastroLivro_Click(object sender, EventArgs e)
        {
            FrmCadastroLivro frmCadastroLivro = new FrmCadastroLivro();
            this.Hide();
            frmCadastroLivro.Show();
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            FrmEmprestimo frmEmprestimo = new FrmEmprestimo();
            this.Hide();
            frmEmprestimo.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario frmCadastroUsuario = new FrmCadastroUsuario();
            this.Hide();
            frmCadastroUsuario.Show();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO LIVRO (NOME, AUTOR, DATA_PUBLICACAO, QUANTIDADE, CATEGORIA)VALUES(@NOME,@AUTOR,@DATA_PUBLICACAO,@QUANTIDADE,@CATEGORIA)", banco);

            int quantidade = Convert.ToInt32(txtquantidade.Text); 

            sqlCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtnome.Text;
            sqlCommand.Parameters.Add("@AUTOR", SqlDbType.VarChar).Value = txtautor.Text;
            sqlCommand.Parameters.Add("@DATA_PUBLICACAO", SqlDbType.VarChar).Value = txtdata.Text;
            sqlCommand.Parameters.Add("@QUANTIDADE", SqlDbType.Int).Value = quantidade;
            sqlCommand.Parameters.Add("@CATEGORIA", SqlDbType.VarChar).Value = cbcategoria.Text;

            if (txtnome.Text != "" && txtautor.Text != "" && txtdata.Text != "" && txtquantidade.Text != "" && cbcategoria.Text != "")
            {


                try
                {
                    banco.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com Sucesso!");
                    txtnome.Text = "";
                    txtautor.Text = "";
                    txtdata.Text = "";
                    txtquantidade.Text = "";
                    cbcategoria.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    banco.Close();

                }
            }
            else
            {
                MessageBox.Show("Por favor Digite todos os Campos!");
                txtnome.Focus();
            }

        }
        public void listaGrid()
        {
            string SQL = "SELECT * FROM LIVRO";
          
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = null;
            sqlCommand = new SqlCommand(SQL, banco);

            try
            {
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                DataTable dtLista = new DataTable();

                sqlData.Fill(dtLista);
                dataGridView.DataSource = dtLista;
            }
            catch
            {
                MessageBox.Show("Ocorreu erro ao se conectar!");
            }


        }

        private void FrmCadastroLivro_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtautor.Text = "";
            txtnome.Text = "";
            txtdata.Text = "";
            txtquantidade.Text = "";
            cbcategoria.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPesquisarLivro frmPesquisarLivro = new FrmPesquisarLivro();
            frmPesquisarLivro.ShowDialog();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //vazio
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            FrmDevolucao devolucao = new FrmDevolucao();
            this.Hide();
            devolucao.Show();
        }
    }
}
