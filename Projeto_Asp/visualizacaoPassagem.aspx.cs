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
            if (txtPesquisa.Text == "")
            {
                Label5.Text = "Para poder alterar, é preciso ter um registro!";
                Label5.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                Habilitar();
            }   
        }       

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            Desabilitar();

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Passagem update = new Passagem();
                update.updatePassagem(int.Parse(txtCodPassagem.Text), int.Parse(txtCodViagem.Text), txtCpf.Text, double.Parse(txtVlrPassagem.Text), int.Parse(txtPoltrona.Text));
                Desabilitar();
                Limpar();
                MessagemSalvar();
            }
            catch(Exception erro)
            {
                Label5.Text = "Erro ao excluir Passagem, " + erro.Message;
            }
        }

        public void Habilitar()
        {
            txtCodPassagem.Enabled = txtCodViagem.Enabled = txtCpf.Enabled = txtPoltrona.Enabled = txtVlrPassagem.Enabled= true;
            btnCancelar.Enabled = btnExcluir.Enabled = btnSalvar.Enabled = true;
        }

        public void Desabilitar()
        {
            txtCodPassagem.Enabled = txtCodViagem.Enabled = txtCpf.Enabled = txtPoltrona.Enabled= txtVlrPassagem.Enabled = false;
            btnCancelar.Enabled = btnExcluir.Enabled = btnSalvar.Enabled = false;
        }

        public void Limpar()
        {
            txtCodPassagem.Text = txtCodViagem.Text = txtCpf.Text = txtPoltrona.Text = txtPesquisa.Text = txtVlrPassagem.Text = "";
        }

        public void MessagemSalvar()
        {
            Label5.Text = "Registro Alterado com sucesso!";
            Label5.ForeColor = System.Drawing.Color.Green;
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Passagem delete = new Passagem();
                delete.exclusaoPassagem(txtCodPassagem.Text);
                Desabilitar();
                Limpar();
                Label5.Text = "Registro excluido com sucesso!";
                Label5.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception erro)
            {
                Label5.Text = "Erro ao excluir Passagem," + erro.Message;
            }
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            Label5.Text = "";
            if (txtPesquisa.Text == "")
            {
                Label5.Text = "Digite um parametro para poder pesquisar";
                Label5.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                // verifica se um dos radiobutton esta ativo
                if (rdCPF.Checked == false && rdIDViagem.Checked == false)
                {
                    Label5.Text = "Seleciona uma uma Opção(Código da passagem ou cpf do passageiro!)";
                    Label5.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    Label5.Text = "";
                    //VERIFICAR QUAL RADIOBUTTON ESTA ATIVO E CHAMAR METODO
                    if (rdCPF.Checked == true)
                    {
                        Passagem pesquisa = new Passagem();
                        pesquisa.pesquisaCPFCliente(txtPesquisa.Text);

                        txtCodPassagem.Text = pesquisa.id_passagem;
                        txtCodViagem.Text = pesquisa.id_viagem;
                        txtCpf.Text = pesquisa.cpf_cliente;
                        txtPoltrona.Text = pesquisa.poltrona;
                        txtVlrPassagem.Text = pesquisa.vlr_passagem;
                        rdCPF.Checked = false;
                        txtPesquisa.Text = "";

                    }
                    else if (rdIDViagem.Checked == true)
                    {
                        Passagem pesquisa2 = new Passagem();
                        pesquisa2.pesquisaIdViagem(txtPesquisa.Text);

                        txtCodPassagem.Text = pesquisa2.id_passagem;
                        txtCodViagem.Text = pesquisa2.id_viagem;
                        txtCpf.Text = pesquisa2.cpf_cliente;
                        txtPoltrona.Text = pesquisa2.poltrona;
                        txtVlrPassagem.Text = pesquisa2.vlr_passagem;
                        rdIDViagem.Checked = false;
                        txtPesquisa.Text = "";
                    }
                }

            }
            
        }
    }

}