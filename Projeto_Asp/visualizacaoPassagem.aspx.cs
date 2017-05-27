using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_Asp
{
    public partial class visualizacaoPassagem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar();   
        }
        public void Habilitar()
        {
            txtCodPassagem.Enabled = txtCodViagem.Enabled = txtCpf.Enabled = txtPoltrona.Enabled = true;
            btnCancelar.Enabled = btnExcluir.Enabled = btnSalvar.Enabled = true;
        }

        public void Desabilitar()
        {
            txtCodPassagem.Enabled = txtCodViagem.Enabled = txtCpf.Enabled = txtPoltrona.Enabled = false;
            btnCancelar.Enabled = btnExcluir.Enabled = btnSalvar.Enabled = false;
        }

        public void Limpar()
        {
            txtCodPassagem.Text = txtCodViagem.Text = txtCpf.Text = txtPoltrona.Text = txtPesquisa.Text= "";
        }

        public void MessagemSalvar()
        {
            Label5.Text = "Registro inserido com sucesso!";
            Label5.ForeColor = System.Drawing.Color.Green;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            Desabilitar();

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilitar();
            Limpar();
            MessagemSalvar();
        }
    }

}