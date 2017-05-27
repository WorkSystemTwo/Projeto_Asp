using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_Asp
{
    public partial class cadastroViagem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Registro inserido com sucesso!"; 
            lblMensagem.ForeColor = System.Drawing.Color.Green; // mudando a cor do texto
            Desabilitar();
            Limpar();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilitar();
            Limpar();
        }

        public void Habilitar()// Método para habilitar botoes e text boxs.
        {
            txtData.Enabled = txtDestino.Enabled = txtHora.Enabled = txtIdViagem.Enabled = txtObs.Enabled = txtObs.Enabled = txtOrigem.Enabled = txtPrevChegada.Enabled = true;
            btnCadastrar.Enabled = btnCancelar.Enabled = true;
        }

        public void Desabilitar() // Método para desabilitar botoes e text boxs.
        {
            txtData.Enabled = txtDestino.Enabled = txtHora.Enabled = txtIdViagem.Enabled = txtObs.Enabled = txtObs.Enabled = txtOrigem.Enabled = txtPrevChegada.Enabled = false;
            btnCadastrar.Enabled = btnCancelar.Enabled = false;
        }

        public void Limpar() // Método para limpar txts.
        {
            txtData.Text = txtDestino.Text = txtHora.Text = txtIdViagem.Text = txtObs.Text = txtOrigem.Text = txtPrevChegada.Text = "";
        }
    }
}