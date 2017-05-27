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
            txtCpf.Enabled = txtCelular.Enabled = txtNome.Enabled = txtObs.Enabled = txtRg.Enabled = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            txtCelular.Enabled = txtCpf.Enabled = txtNome.Enabled = txtObs.Enabled = txtRg.Enabled = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"");
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "Insert into ";




        }
    }
}