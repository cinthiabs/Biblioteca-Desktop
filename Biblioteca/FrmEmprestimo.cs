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
    public partial class FrmEmprestimo : Form
    {
        public FrmEmprestimo()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmBiblioteca frmBiblioteca = new FrmBiblioteca();
            this.Hide();
            frmBiblioteca.Show();
        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario frmCadastroUsuario = new FrmCadastroUsuario();
            this.Hide();
            frmCadastroUsuario.Show();
        }

        private void btnCadastroLivro_Click(object sender, EventArgs e)
        {
            FrmCadastroLivro frmCadastroLivro = new FrmCadastroLivro();
            this.Hide();
            frmCadastroLivro.Show();
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

        public void listaGrid()
        {
            string SQL = "SELECT * FROM EMPRESTIMO";

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

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO EMPRESTIMO(CODLIVRO, CODUSUARIO,DATA_EMPRESTIMO, PRAZO)VALUES(@CODLIVRO, @CODUSUARIO, @DATA_EMPRESTIMO, @PRAZO)", banco);

            int prazo = Convert.ToInt32(txtprazo.Text);

            sqlCommand.Parameters.Add("@CODLIVRO", SqlDbType.Int).Value = txtcodlivro.Text;
            sqlCommand.Parameters.Add("@CODUSUARIO", SqlDbType.Int).Value = txtcodusuario.Text;
            sqlCommand.Parameters.Add("@DATA_EMPRESTIMO", SqlDbType.DateTime).Value = txtdataemprestimo.Text;
            sqlCommand.Parameters.Add("@PRAZO", SqlDbType.Int).Value = prazo;

            if(txtcodlivro.Text !="" && txtcodusuario.Text !="" && txtdataemprestimo.Text !="" && this.prazo.Text != "")
            {
                try
                {
                    banco.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com Sucesso!");
                    txtcodlivro.Text = "";
                    txtcodusuario.Text = "";
                    txtdataemprestimo.Text = "";
                    txtprazo.Text = "";
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
                txtcodusuario.Focus();
            }
        }

        private void FrmEmprestimo_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtcodlivro.Text = "";
            txtcodusuario.Text = "";
            txtdataemprestimo.Text = "";
            txtprazo.Text = "";
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            FrmDevolucao devolucao = new FrmDevolucao();
            this.Hide();
            devolucao.Show();

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisaEmprestimo emprestimo = new FrmPesquisaEmprestimo();
            emprestimo.ShowDialog();
        }
    }   
}
