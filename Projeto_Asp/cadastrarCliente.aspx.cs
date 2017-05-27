using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Projeto_Asp
{
    public partial class cadastrarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            novo();            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            save_cancel();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //insert através do banco
            try
            {
                Banco insert = new Banco(txtCpf.Text, txtNome.Text, txtCelular.Text, txtRg.Text, txtObs.Text);
                lblMensagem.Text = "Cliente inserido com Sucesso";
                save_cancel();                
            }

            catch (Exception erro)
            {
                lblMensagem.Text = "Erro ao inserir cliente, favor verificar dados! Erro -> " + erro.Message;
            }

        }

        //function for button new
        private void novo()
        {
            txtCpf.Enabled = true;
            txtCelular.Enabled = true;
            txtNome.Enabled = true;
            txtObs.Enabled = true;
            txtRg.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            txtCpf.Focus();
        }
        //function for button save and cancel
        private void save_cancel()
        {
            txtCpf.Enabled = false;
            txtCpf.Text = "";
            txtCelular.Enabled = false;
            txtCelular.Text = "";
            txtNome.Enabled = false;
            txtNome.Text = "";
            txtObs.Enabled = false;
            txtObs.Text = "";
            txtRg.Enabled = false;
            txtRg.Text = "";
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;            
        }
    }
}