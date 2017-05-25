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
            txtCodPassagem.Enabled = txtCodViagem.Enabled = txtCpf.Enabled = true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodPassagem.Text = txtCodViagem.Text = txtCpf.Text = "";
            txtCodPassagem.Enabled = txtCodViagem.Enabled = txtCpf.Enabled = false;
        }
    }
}