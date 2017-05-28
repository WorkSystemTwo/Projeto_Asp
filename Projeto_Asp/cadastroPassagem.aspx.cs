using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Projeto_Asp
{
	public partial class cadastroPassagem : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            //carregamento de dados para inserção de passagens
            SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\João Paulo\Source\Repos\Projeto_Asp\Projeto_Asp\App_Data\BD.mdf;Integrated Security=True");
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            SqlDataReader reg = null;
            comando.CommandText = "SELECT  * FROM viagem ORDER BY data_saida";
            conexao.Open();
            reg = comando.ExecuteReader();

            //variaveis para salvar dados do banco

            string destino, data_saida;

            while (reg.Read())
            {
                destino = (reg["destino"].ToString());
                data_saida = (reg["data_saida"].ToString());
                listViagem.Items.Add(destino.ToString() + " - " + data_saida.ToString());
            }

            conexao.Close();
		}

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            novo();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            salvar_cancelar();
        }


        //function for button new
        private void novo()
        {
            txtCPF.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtPoltrona.Enabled = true;
            txtValorPassagem.Enabled = true;
            btnSalvar.Enabled = true;
            btnVerificar.Visible = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            Label5.Visible = true;
            txtCPF.Visible = true;
            txtCPF.Focus();
        }
        //function for button save and cancel
        private void salvar_cancelar()
        {
            txtCPF.Enabled = false;
            txtCPF.Text = "";
            txtNomeCliente.Enabled = false;
            txtNomeCliente.Text = "";
            txtPoltrona.Enabled = false;
            txtPoltrona.Text = "";
            txtValorPassagem.Enabled = false;
            txtValorPassagem.Text = "";
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
            btnVerificar.Visible = false;
            Label5.Visible = false;
            txtCPF.Visible = false;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Passagem insert = new Passagem(int.Parse(txtIdPassagem.Text), txtCPF.Text, double.Parse(txtValorPassagem.Text), int.Parse(txtPoltrona.Text));
                Label6.Text = "Passagem inserido com sucesso!";
                Label6.ForeColor = System.Drawing.Color.Green;
                salvar_cancelar();
            }
            catch(Exception erro)
            {
                Label6.Text = "Erro ao inserir passagem!" + erro.Message;
            }
        }
       
    }
}