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
    public partial class FrmDevolucao : Form
    {
        public FrmDevolucao()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmBiblioteca biblioteca = new FrmBiblioteca();
            this.Hide();
            biblioteca.Show();
        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario frmCadastroUsuario = new FrmCadastroUsuario();
            this.Hide();
            frmCadastroUsuario.Show();
        }

        private void btnCadastroLivro_Click(object sender, EventArgs e)
        {
            FrmCadastroLivro cadastroLivro = new FrmCadastroLivro();
            this.Hide();
            cadastroLivro.Show();
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            FrmEmprestimo emprestimo = new FrmEmprestimo();
            this.Hide();
            emprestimo.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.Show();
        }

        public void listaGrid()
        {
            string SQL = "SELECT * FROM DEVOLUCAO";

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
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO DEVOLUCAO(CODEMPRESTIMO, DATA_DEVOLUCAO, DIAS_ATRASO)VALUES(@CODEMPRESTIMO, @DATA_DEVOLUCAO, @DIAS_ATRASO)", banco);

            int prazo = Convert.ToInt32(txtprazo.Text);

            sqlCommand.Parameters.Add("@CODEMPRESTIMO", SqlDbType.Int).Value = txtcodemprestimo.Text;
            sqlCommand.Parameters.Add("@DATA_DEVOLUCAO", SqlDbType.DateTime).Value = txtdatadevolucao.Text;
            sqlCommand.Parameters.Add("@DIAS_ATRASO", SqlDbType.Int).Value = prazo;

            if(txtcodemprestimo.Text !="" && txtdatadevolucao.Text !="" && txtprazo.Text !="")
            {
                try
                {
                    banco.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com Sucesso!");
                    txtdatadevolucao.Text = "";
                    txtcodemprestimo.Text = "";
                    txtprazo.Text = "";
                    txtdatadevolucao.Text = "";

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
                txtcodemprestimo.Focus();
            }
        
        }

        private void FrmDevolucao_Load(object sender, EventArgs e)
        {
            listaGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtcodemprestimo.Text = "";
            txtdatadevolucao.Text = "";
            txtprazo.Text = "";
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisaDevolucao frmPesquisaDevolucao = new FrmPesquisaDevolucao();
            frmPesquisaDevolucao.ShowDialog();
        }

        private void BtnPesquisar_Click_1(object sender, EventArgs e)
        {
            FrmPesquisaDevolucao devolucao = new FrmPesquisaDevolucao();
            devolucao.ShowDialog();
        }
    }
}
