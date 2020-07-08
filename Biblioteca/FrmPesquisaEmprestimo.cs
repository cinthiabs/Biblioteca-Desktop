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
    public partial class FrmPesquisaEmprestimo : Form
    {
        public FrmPesquisaEmprestimo()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("UPDATE EMPRESTIMO SET CODUSUARIO=@CODUSUARIO, CODLIVRO=@CODLIVRO, DATA_EMPRESTIMO=@DATA_EMPRESTIMO, PRAZO=@PRAZO  WHERE CODEMPRESTIMO=@CODEMPRESTIMO", banco);

            int prazo = Convert.ToInt32(txtprazo.Text);
            sqlCommand.Parameters.Add("@CODEMPRESTIMO", SqlDbType.Int).Value = txtemprestimo.Text;
            sqlCommand.Parameters.Add("@CODLIVRO", SqlDbType.Int).Value = txtcodlivro.Text;
            sqlCommand.Parameters.Add("@CODUSUARIO", SqlDbType.Int).Value = txtcodusuario.Text;
            sqlCommand.Parameters.Add("@DATA_EMPRESTIMO", SqlDbType.DateTime).Value = txtdataemprestimo.Text;
            sqlCommand.Parameters.Add("@PRAZO", SqlDbType.Int).Value = prazo;

            if(txtcodlivro.Text !="" && txtcodusuario.Text !="" && txtdataemprestimo.Text !="" && txtprazo.Text != "")
            {

                try
                {
                    banco.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cadastro atualizado com Sucesso!");
                    txtcodlivro.Text = "";
                    txtcodusuario.Text = "";
                    txtdataemprestimo.Text = "";
                    txtemprestimo.Text = "";
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
                txtemprestimo.Focus();
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM EMPRESTIMO WHERE CODEMPRESTIMO=@CODEMPRESTIMO", banco);

            sqlCommand.Parameters.Add("@CODEMPRESTIMO", SqlDbType.VarChar).Value = txtemprestimo.Text;


            try
            {
                banco.Open();
                SqlDataReader leia = sqlCommand.ExecuteReader();
                if (leia.HasRows == false)
                {
                    throw new Exception("Usuario não encontrado");
                }
                leia.Read();
                txtdataemprestimo.Text = Convert.ToString(leia["DATA_EMPRESTIMO"]);
                txtcodusuario.Text = Convert.ToString(leia["CODUSUARIO"]);
                txtcodlivro.Text = Convert.ToString(leia["CODLIVRO"]);
                txtprazo.Text = Convert.ToString(leia["PRAZO"]);
                txtemprestimo.Text = Convert.ToString(leia["CODEMPRESTIMO"]);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM EMPRESTIMO WHERE CODEMPRESTIMO=@CODEMPRESTIMO", banco);

            sqlCommand.Parameters.Add("@CODEMPRESTIMO", SqlDbType.VarChar).Value = txtemprestimo.Text;


            try
            {
                banco.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Dados Excluidos com Sucesso!");
                txtcodlivro.Text = "";
                txtcodusuario.Text = "";
                txtdataemprestimo.Text = "";
                txtemprestimo.Text = "";
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
    }
    
       
    
    }

