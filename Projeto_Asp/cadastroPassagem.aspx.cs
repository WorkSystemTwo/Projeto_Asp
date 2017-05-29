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
            listViagem.Items.Clear();

            try
            {
                //carregamento de dados para inserção de passagens

                //string connection JP
                SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\João Paulo\Source\Repos\Projeto_Asp\Projeto_Asp\App_Data\BD.mdf;Integrated Security=True");

                //string connection THIAGAO
               // SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thiago_2\Source\Repos\Projeto_Asp\Projeto_Asp\App_Data\BD.mdf;Integrated Security=True");

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                SqlDataReader reg = null;
                comando.CommandText = "SELECT  * FROM viagem ORDER BY data_saida";
                conexao.Open();
                reg = comando.ExecuteReader();

                //variaveis para salvar dados do banco

                string destino, data_saida, hr_saida, id_viagem;

                while (reg.Read())
                {
                    id_viagem = (reg["id_viagem"].ToString());
                    destino = (reg["destino"].ToString());
                    data_saida = (reg["data_saida"].ToString());
                    hr_saida = (reg["hr_saida"].ToString());
                    ListItem viagens = new ListItem(destino, id_viagem, true);
                    listViagem.Items.Add(viagens);
                }

                conexao.Close();
            }

            catch(Exception erro)

            {
                lblMensagem.Text = " Erro ao puxar dados,  " + erro.Message;
            }


            //código para puxar id disponivel
            //string connection JP
           SqlConnection conexao3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\João Paulo\Source\Repos\Projeto_Asp\Projeto_Asp\App_Data\BD.mdf;Integrated Security=True");
            SqlCommand comando3 = new SqlCommand("SELECT  MAX(id_passagem +1) AS id_passagem from passagem", conexao3);
            DataSet ds = new DataSet();
            conexao3.Open();
            if (conexao3.State == ConnectionState.Open)
            {
                txtIdPassagem.Text = comando3.ExecuteScalar().ToString();
            }
            

            //código para puxar id disponivel
            //string connection Thiago
            /* SqlConnection conexao3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thiago_2\Source\Repos\Projeto_Asp\Projeto_Asp\App_Data\BD.mdf;Integrated Security=True");
             SqlCommand comando3 = new SqlCommand("SELECT  MAX(id_passagem +1) AS id_passagem from passagem", conexao3);
             DataSet ds = new DataSet();
             conexao3.Open();
             if (conexao3.State == ConnectionState.Open)
             {
                 txtIdPassagem.Text= comando3.ExecuteScalar().ToString();
             }
             */

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
            txtNomeCliente.Enabled = true;
            txtIdPassagem.Enabled = true;
            listViagem.Enabled = true;
            txtCPF.Focus();
        }
        //function for button save and cancel
        private void salvar_cancelar()
        {
            txtIdPassagem.Enabled = false;
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
            listViagem.Enabled = false;
            Label5.Visible = false;
            txtCPF.Visible = false;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Passagem insert = new Passagem(listViagem.SelectedValue, txtCPF.Text, double.Parse(txtValorPassagem.Text), int.Parse(txtPoltrona.Text));
                lblMensagem.Text = "Passagem inserido com sucesso!";
                lblMensagem.ForeColor = System.Drawing.Color.Green;
                salvar_cancelar();
            }
            catch(Exception erro)
            {
                lblMensagem.Text = "Erro ao inserir passagem!" + erro.Message;
            }
        }

        protected void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente selectSpecial = new Cliente();
                selectSpecial.pesquisaClienteSpecial(txtNomeCliente.Text);
                txtCPF.Text = selectSpecial.cpf_cliente.ToString();
            }
            catch(Exception erro)
            {
                lblMensagem.Text = "Esse cliente não possui cadastro, " + erro.Message;
            }

        }
    }
}