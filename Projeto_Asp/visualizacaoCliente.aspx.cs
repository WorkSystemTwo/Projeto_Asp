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
            try
            {
                Cliente delete = new Cliente();
                delete.exclusaoCliente(txtCPF.Text.ToString());
                Limpar();
                Desabilitar();
                Label8.Text = "Cliente excluído com Sucesso";
            }   
            catch(Exception erro)
            {
                Label8.Text = "Erro ao excluir cliente, " + erro.Message;
            }    

        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente teste = new Cliente();
                teste.pesquisaCliente(txtPesquisaNome.Text);
                txtNome.Text = teste.nome;
                txtCPF.Text = teste.cpf_cliente;
                txtOBS.Text = teste.obs;
                txtCelular.Text = teste.celular;
                txtRG.Text = teste.rg;
            }
            catch(Exception erro)
            {
                Label8.Text = "Erro ao pesquisar cliente, " + erro.Message;
            }      
        }
    }
}