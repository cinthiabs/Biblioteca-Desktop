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
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            listaGrid(); 
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

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO USUARIO (NOME, DATA_NASCIMENTO, ESCOLARIEDADE, ENDERECO, EMAIL, GENERO)VALUES(@NOME, @DATA_NASCIMENTO,@ESCOLARIEDADE,@ENDERECO,@EMAIL,@GENERO)", banco);

            sqlCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtnome.Text;
            sqlCommand.Parameters.Add("@DATA_NASCIMENTO", SqlDbType.DateTime).Value = txtdata.Text;
            sqlCommand.Parameters.Add("@ESCOLARIEDADE", SqlDbType.VarChar).Value = txtescolariedade.Text;
            sqlCommand.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = txtendereco.Text;
            sqlCommand.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = txtemail.Text;
            sqlCommand.Parameters.Add("@GENERO", SqlDbType.VarChar).Value = cbgenero.Text;

            if(txtnome.Text !="" && txtdata.Text !="" && txtescolariedade.Text !="" && txtemail.Text !="" && cbgenero.Text != "")
            {
                try
                {
                    banco.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com Sucesso!");
                    txtnome.Text = "";
                    txtdata.Text = "";
                    txtescolariedade.Text = "";
                    txtendereco.Text = "";
                    txtemail.Text = "";
                    cbgenero.Text = "";
                }
                catch(Exception ex)
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
        // fazendo a grid função

        public void listaGrid() 
        {
            string SQL = "SELECT * FROM USUARIO";
           
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
            private void pesquisar_Click(object sender, EventArgs e)
        {
            //cancelado form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPesquisar frmPesquisar = new FrmPesquisar();
            frmPesquisar.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtnome.Text = "";
            txtemail.Text = "";
            txtendereco.Text = "";
            txtdata.Text = "";
            txtescolariedade.Text = "";
            cbgenero.Text = "";
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            FrmDevolucao devolucao = new FrmDevolucao();
            this.Hide();
            devolucao.Show();
        }
    }
}
