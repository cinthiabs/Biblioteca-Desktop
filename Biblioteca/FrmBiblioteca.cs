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
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void btnConsultaUsuario_Click(object sender, EventArgs e)
        {

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

        private void hora_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToLongTimeString(); //hora completa
            lbdia.Text = DateTime.Now.ToString("dddd"); //dia em texto
            lbldia.Text = DateTime.Now.ToString("d "); //dia em numero
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            FrmDevolucao devolucao = new FrmDevolucao();
            this.Hide();
            devolucao.Show();
        }

        public void RegistroUsuario()
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM USUARIO", banco);

            banco.Open();
            lblusuario.Text = sqlCommand.ExecuteScalar().ToString();
            banco.Close();

        }
        public void RegistroLivro()
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM LIVRO", banco);

            banco.Open();
            lbllivro.Text = sqlCommand.ExecuteScalar().ToString();
            banco.Close();

        }
        public void RegistroEmprestado()
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM EMPRESTIMO", banco);

            banco.Open();
            lblemprestado.Text = sqlCommand.ExecuteScalar().ToString();
            banco.Close();

        }


        private void FrmBiblioteca_Load(object sender, EventArgs e)
        {
            RegistroUsuario();
            RegistroLivro();
            RegistroEmprestado();
        }

        private void lblusuario_Click(object sender, EventArgs e)
        {
            //vazio
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DateTime tempo = DateTime.Now;
            string dia = "Bom dia!";
            string tarde = "Boa Tarde!";
            string noite = "Boa Noite!";

            if (tempo.Hour > 6 && tempo.Hour < 12)
                label4.Text = dia;
            else if (tempo.Hour >= 12 && tempo.Hour < 18)
                label4.Text = tarde;
            else
                label4.Text = noite;
        }

        private void lbhora_Click(object sender, EventArgs e)
        {
            //vazio
        }
    }
}
