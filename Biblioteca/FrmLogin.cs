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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public bool logado = false;
        public static string usuarioConectado="";//falta terminar 

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LbCadastrese_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro();
            this.Hide();
            frmCadastro.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            txtLogin.Focus();
            if(txtLogin.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                txtLogin.Focus();
            }

            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=PROJETOS;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT * FROM CADASTRO where LOGIN=@LOGIN AND SENHA=@SENHA", banco);

            comando.Parameters.Add("@LOGIN", SqlDbType.VarChar).Value = txtLogin.Text;
            comando.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = txtSenha.Text;

            try
            {
                banco.Open();
                SqlDataReader leia = comando.ExecuteReader();
                if(leia.HasRows == false)
                {
                    throw new Exception("Usuário ou senha Incorreta!");
                    
                }
                else
                {
                    leia.Read();
                    FrmBiblioteca frmBiblioteca = new FrmBiblioteca();
                    this.Hide();
                    frmBiblioteca.ShowDialog();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                banco.Close();
            }
        }
    }
}
