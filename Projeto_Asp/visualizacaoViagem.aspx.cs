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

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            //os métodos de pesquisa estão funcionais

            Viagem pesquisar = new Viagem();
            pesquisar.selectIDViagem(txtPesquisa.Text);

            txtIdViagem.Text = pesquisar.id_viagem;
            txtHora.Text = pesquisar.hr_saida;
            txtObs.Text = pesquisar.obs;
            txtPrevChegada.Text = pesquisar.prev_chegada;
            txtData.Text = pesquisar.data_saida;
            txtDestino.Text = pesquisar.destino;
            txtOrigem.Text = pesquisar.origem;

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            // o método está funcionando, falta tratar
            try
            {
                Viagem delete = new Viagem();
                delete.exclusaoViagem(txtIdViagem.Text);
                lblMensagem.Text = "Viagem excluída com sucesso do sistema";
            }
            catch(Exception erro)
            {
                lblMensagem.Text = "Erro ao excluir viagem, " + erro.Message;
            }                       

        }
    }
}