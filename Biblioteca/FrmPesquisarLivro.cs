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
    public partial class FrmPesquisarLivro : Form
    {
        public FrmPesquisarLivro()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM LIVRO WHERE NOME=@NOME", banco);

            sqlCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtnome.Text;


            try
            {
                banco.Open();
                SqlDataReader leia = sqlCommand.ExecuteReader();
                if (leia.HasRows == false)
                {
                    throw new Exception("Usuario não encontrado");
                }
                leia.Read();
                txtnome.Text = Convert.ToString(leia["NOME"]);
                txtdata.Text = Convert.ToString(leia["DATA_PUBLICACAO"]);
                txtautor.Text = Convert.ToString(leia["AUTOR"]);
                txtquantidade.Text = Convert.ToString(leia["QUANTIDADE"]);
                cbcategoria.Text = Convert.ToString(leia["CATEGORIA"]);
              
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("UPDATE LIVRO SET NOME=@NOME, AUTOR=@AUTOR, DATA_PUBLICACAO=@DATA_PUBLICACAO,QUANTIDADE=@QUANTIDADE, CATEGORIA=@CATEGORIA WHERE NOME=@NOME", banco);

            int quantidade = Convert.ToInt32(txtquantidade.Text); // converte para inteiro

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
                    MessageBox.Show("Cadastro atualizado com Sucesso!");
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM LIVRO  WHERE NOME=@NOME", banco);

            sqlCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtnome.Text;


            try
            {
                banco.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Dados Excluidos com Sucesso!");
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
    }
}
