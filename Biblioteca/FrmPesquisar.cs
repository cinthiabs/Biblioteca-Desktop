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
    public partial class FrmPesquisar : Form
    {
        public FrmPesquisar()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM USUARIO WHERE NOME=@NOME", banco);

            sqlCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtnome.Text;
            

             try
                {
                    banco.Open();
                    SqlDataReader leia = sqlCommand.ExecuteReader();
                    if(leia.HasRows == false)
                {
                    throw new Exception("Usuario não encontrado");
                }
                leia.Read();
                txtnome.Text = Convert.ToString(leia["NOME"]);
                txtdata.Text = Convert.ToString(leia["DATA_NASCIMENTO"]);
                txtescolariedade.Text = Convert.ToString(leia["ESCOLARIEDADE"]);
                txtendereco.Text = Convert.ToString(leia["ENDERECO"]);
                txtemail.Text = Convert.ToString(leia["EMAIL"]);
                cbgenero.Text = Convert.ToString(leia["GENERO"]);
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

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            SqlConnection banco = new SqlConnection("Data Source=DESKTOP-7VCU04E;Initial Catalog=BIBLIOTECA;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("UPDATE USUARIO SET NOME=@NOME, DATA_NASCIMENTO=@DATA_NASCIMENTO, ESCOLARIEDADE=@ESCOLARIEDADE, ENDERECO=@ENDERECO, EMAIL=@EMAIL, GENERO=@GENERO  WHERE NOME=@NOME", banco);

            sqlCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtnome.Text;
            sqlCommand.Parameters.Add("@DATA_NASCIMENTO", SqlDbType.VarChar).Value = txtdata.Text;
            sqlCommand.Parameters.Add("@ESCOLARIEDADE", SqlDbType.VarChar).Value = txtescolariedade.Text;
            sqlCommand.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = txtendereco.Text;
            sqlCommand.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = txtemail.Text;
            sqlCommand.Parameters.Add("@GENERO", SqlDbType.VarChar).Value = cbgenero.Text;


            if (txtnome.Text != "" && txtdata.Text != "" && txtescolariedade.Text != "" && txtemail.Text != "" && cbgenero.Text != "")
            {
                try
                {
                    banco.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cadastro atualizado com Sucesso!");
                    txtnome.Text = "";
                    txtdata.Text = "";
                    txtescolariedade.Text = "";
                    txtendereco.Text = "";
                    txtemail.Text = "";
                    cbgenero.Text = "";
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
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM USUARIO WHERE NOME=@NOME", banco);

            sqlCommand.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtnome.Text;


            try
            {
                banco.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Dados Excluidos com Sucesso!");
                txtnome.Text = "";
                txtdata.Text = "";
                txtescolariedade.Text = "";
                txtendereco.Text = "";
                txtemail.Text = "";
                cbgenero.Text = "";

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
