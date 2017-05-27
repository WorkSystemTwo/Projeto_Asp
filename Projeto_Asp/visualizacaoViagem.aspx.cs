using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_Asp
{
    public partial class visualizacaoViagem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilitar();
            Limpar();
        }


        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Registro alterado com sucesso!";
            lblMensagem.ForeColor = System.Drawing.Color.Green;
            Desabilitar();
            Limpar();
        }

        public void Habilitar()//metodo para habilitar textbox e botoes
        {
            txtData.Enabled = txtDestino.Enabled = txtHora.Enabled = txtIdViagem.Enabled = txtObs.Enabled = txtOrigem.Enabled = txtPrevChegada.Enabled = true;
            btnCancelar.Enabled = btnSalvar.Enabled = btnExcluir.Enabled = true;
        }

        public void Desabilitar()//metodo para desabilitar textbox e botoes
        {
            txtData.Enabled = txtDestino.Enabled = txtHora.Enabled = txtIdViagem.Enabled = txtObs.Enabled = txtOrigem.Enabled = txtPrevChegada.Enabled = false;
            btnCancelar.Enabled = btnSalvar.Enabled = btnExcluir.Enabled = false;
        }
        public void Limpar()//metodo para limpar textbox
        {
            txtData.Text = txtDestino.Text = txtHora.Text = txtIdViagem.Text = txtObs.Text = txtOrigem.Text = txtPrevChegada.Text = txtPesquisa.Text = "";

        }

    }
}