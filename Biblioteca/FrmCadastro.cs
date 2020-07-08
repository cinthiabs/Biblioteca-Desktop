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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Application.Exit();
        
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtNome.Focus();
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=PROJETOS;Integrated Security=True");
            SqlCommand comando = new SqlCommand("INSERT INTO CADASTRO(CODCADASTRO, NOME, SEXO, EMAIL, LOGIN, SENHA)VALUES(@CODCADASTRO, @NOME, @SEXO, @EMAIL, @LOGIN, @SENHA)",banco);

            //criando numero para chave primaria
            Random chave = new Random();
            chave.Next();

            comando.Parameters.Add(new SqlParameter("@CODCADASTRO", chave.Next()));
            comando.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@SEXO", SqlDbType.VarChar).Value = cbSexo.Text;
            comando.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@LOGIN", SqlDbType.VarChar).Value = txtLogin.Text;
            comando.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = txtSenha.Text;

            if(txtNome.Text !="" && txtEmail.Text !="" && cbSexo.Text !="" && txtEmail.Text !="" && txtLogin.Text !="" && txtSenha.Text != "")
            {
                try
                {
                    banco.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com Sucesso!" + MessageBoxButtons.OK);
                    txtNome.Text = "";
                    cbSexo.Text = "";
                    txtEmail.Text = "";
                    txtLogin.Text = "";
                    txtSenha.Text = "";
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
                txtNome.Focus();
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if(txtLogin.Text.Length > 10)
            {
                MessageBox.Show("Maximo de caracteres permitido 10");
            }
        }
    }
}
