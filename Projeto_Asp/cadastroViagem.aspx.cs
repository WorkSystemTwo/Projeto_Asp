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
    public partial class cadastroViagem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conexao3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thiago_2\Source\Repos\Projeto_Asp\Projeto_Asp\App_Data\BD.mdf;Integrated Security=True");
            SqlCommand comando3 = new SqlCommand("SELECT  MAX(id_viagem +1) AS id_viagem from viagem", conexao3);
            DataSet ds = new DataSet();
            conexao3.Open();
            if (conexao3.State == ConnectionState.Open)
            {
                txtIdViagem.Text = comando3.ExecuteScalar().ToString();
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            Habilitar();
        }
       
        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Viagem insert = new Viagem (txtOrigem.Text, txtDestino.Text, txtData.Text, txtHora.Text, txtPrevChegada.Text, txtObs.Text);
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
            txtData.Enabled = txtDestino.Enabled = txtHora.Enabled =  txtObs.Enabled = txtObs.Enabled = txtOrigem.Enabled = txtPrevChegada.Enabled = true;
            btnCadastrar.Enabled = btnCancelar.Enabled = true;
        }

        public void Desabilitar() // Método para desabilitar botoes e text boxs.
        {
            txtData.Enabled = txtDestino.Enabled = txtHora.Enabled = txtObs.Enabled = txtObs.Enabled = txtOrigem.Enabled = txtPrevChegada.Enabled = false;
            btnCadastrar.Enabled = btnCancelar.Enabled = false;
        }

        public void Limpar() // Método para limpar txts.
        {
            txtData.Text = txtDestino.Text = txtHora.Text =  txtObs.Text = txtOrigem.Text = txtPrevChegada.Text = "";
        }
    }
}