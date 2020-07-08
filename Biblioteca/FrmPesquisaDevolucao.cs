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
    public partial class FrmPesquisaDevolucao : Form
    {
        public FrmPesquisaDevolucao()
        {
            InitializeComponent();
        }

        private void FrmPesquisaDevolucao_Load(object sender, EventArgs e)
        {
            //vazio
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM DEVOLUCAO WHERE CODDEVOLUCAO=@CODDEVOLUCAO", banco);

            sqlCommand.Parameters.Add("@CODDEVOLUCAO", SqlDbType.VarChar).Value = txtcoddevolucao.Text;


            try
            {
                banco.Open();
                SqlDataReader leia = sqlCommand.ExecuteReader();
                if (leia.HasRows == false)
                {
                    throw new Exception("Usuario não encontrado");
                }
                leia.Read();
                txtcoddevolucao.Text = Convert.ToString(leia["CODDEVOLUCAO"]);
                txtcodemprestimo.Text = Convert.ToString(leia["CODEMPRESTIMO"]);
                txtdatadevolucao.Text = Convert.ToString(leia["DATA_DEVOLUCAO"]);
                txtprazo.Text = Convert.ToString(leia["DIAS_ATRASO"]);
                
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("UPDATE DEVOLUCAO SET CODEMPRESTIMO=@CODEMPRESTIMO, DATA_DEVOLUCAO=@DATA_DEVOLUCAO, DIAS_ATRASO=@DIAS_ATRASO WHERE CODDEVOLUCAO=@CODDEVOLUCAO", banco);

            int prazo = Convert.ToInt32(txtprazo.Text);


            sqlCommand.Parameters.Add("@CODDEVOLUCAO", SqlDbType.Int).Value = txtcoddevolucao.Text;
            sqlCommand.Parameters.Add("@CODEMPRESTIMO", SqlDbType.Int).Value = txtcodemprestimo.Text;
            sqlCommand.Parameters.Add("@DATA_DEVOLUCAO", SqlDbType.DateTime).Value = txtdatadevolucao.Text;
            sqlCommand.Parameters.Add("@DIAS_ATRASO", SqlDbType.Int).Value = prazo;

            if (txtcoddevolucao.Text !="" && txtcodemprestimo.Text != "" && txtdatadevolucao.Text != "" && txtprazo.Text != "")
            {
                try
                {
                    banco.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cadastro atualizado com Sucesso!");
                    txtdatadevolucao.Text = "";
                    txtcodemprestimo.Text = "";
                    txtprazo.Text = "";
                    txtcoddevolucao.Text = "";
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
                txtcoddevolucao.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM DEVOLUCAO WHERE CODDEVOLUCAO=@CODDEVOLUCAO", banco);

            sqlCommand.Parameters.Add("@CODDEVOLUCAO", SqlDbType.VarChar).Value = txtcoddevolucao.Text;


            try
            {
                banco.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Dados Excluidos com Sucesso!");
                txtdatadevolucao.Text = "";
                txtcodemprestimo.Text = "";
                txtprazo.Text = "";
                txtcoddevolucao.Text = "";

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
    }
}
