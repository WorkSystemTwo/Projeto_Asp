using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_Asp
{
    public partial class visualizacaoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Label8.Text = "Registro alterado com sucesso!";
            Label8.ForeColor = System.Drawing.Color.Green;
            Limpar();
            Desabilitar();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilitar();
            Limpar();
        }

        public void Habilitar()
        {
            txtCelular.Enabled = txtCPF.Enabled = txtNome.Enabled = txtOBS.Enabled = txtRG.Enabled = true;
            btnCancelar.Enabled = btnSalvar.Enabled = btnExcluir.Enabled = true;
        }

        public void Desabilitar()
        {
            txtCelular.Enabled = txtCPF.Enabled = txtNome.Enabled = txtOBS.Enabled = txtRG.Enabled = false;
            btnCancelar.Enabled = btnSalvar.Enabled = btnExcluir.Enabled = false;

        }

        public void Limpar()
        {
            txtCelular.Text = txtCPF.Text = txtNome.Text = txtOBS.Text = txtPesquisaNome.Text = txtRG.Text = "";

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {                     
            Limpar();
            Desabilitar();
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {

            Banco pesquisa = new Banco(txtPesquisaNome.Text);
            


        }
    }
}