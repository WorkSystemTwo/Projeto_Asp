using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_Asp
{
    public partial class cadastroPassagem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            txtCodPassagem.Enabled = txtCodViagem.Enabled = txtCpf.Enabled = txtPoltrona.Enabled = true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            desabilitar();
        }
        private void Limpar()
        {
            txtCodPassagem.Text = txtCodViagem.Text = txtCpf.Text = txtPoltrona.Text = "";
        }
        private void desabilitar()
        {
            txtCodPassagem.Enabled = txtCodViagem.Enabled = txtCpf.Enabled = txtPoltrona.Enabled = false;
        }
        private void Habilitar()
        {
            txtCodPassagem.Enabled = txtCodViagem.Enabled = txtCpf.Enabled = txtPoltrona.Enabled = false;
        }
    }
}