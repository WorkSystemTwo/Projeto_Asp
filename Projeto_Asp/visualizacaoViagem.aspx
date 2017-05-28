<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="visualizacaoViagem.aspx.cs" Inherits="Projeto_Asp.visualizacaoViagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Gerenciar Viagem</title>
    <link href="CSS/Style.css" rel="stylesheet" type="text/css" />

</head>

<body>

    <form id="form1" runat="server">

    <div id="consulta">
    
            <center> <h4> GERENCIAR VIAGEM</h4></center>

            <br />
            <br />

        <div id="escritaPagina">

            <center>

                <b>
                <asp:Label ID="Label8" runat="server" Text="Pesquisa por :"></asp:Label>
                 &nbsp;
                <asp:RadioButton ID="rdId" runat="server" Text="ID Viagem"></asp:RadioButton>
                <asp:RadioButton ID="rdOrigem" runat="server" Text="Cidade Origem"></asp:RadioButton>
                <asp:RadioButton ID="rdDestino" runat="server" Text="Cidade Destino"></asp:RadioButton>
                &nbsp;
                <br />
                <asp:TextBox ID="txtPesquisa" runat="server" Width="364px"></asp:TextBox>
                 &nbsp;
                <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" BorderStyle="None" Height="26px" />
                </b>

            </center>

        <br />
        <br />
        
        <asp:Label ID="Label1" runat="server" Text="ID Viagem : "></asp:Label>
        <asp:TextBox ID="txtIdViagem" runat="server" ReadOnly="True" Width="108px" Enabled="False"></asp:TextBox>
            <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Cidade Origem : "></asp:Label>
        <asp:TextBox ID="txtOrigem" runat="server" Width="226px" Enabled="False"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Label3" runat="server" Text="Cidade Destino : "></asp:Label>
        <asp:TextBox ID="txtDestino" runat="server" Width="225px" Enabled="False"></asp:TextBox>
            <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Data Viagem : "></asp:Label>
        <asp:TextBox ID="txtData" runat="server" TextMode="Date" Enabled="False"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Label5" runat="server" Text="Hora Viagem : "></asp:Label>
        <asp:TextBox ID="txtHora" runat="server" Enabled="False"></asp:TextBox>
            <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Previsão Chegada : "></asp:Label>
        <asp:TextBox ID="txtPrevChegada" runat="server" Width="135px" Enabled="False"></asp:TextBox>
            <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Observação : "></asp:Label>
        <asp:TextBox ID="txtObs" runat="server" Height="95px" TextMode="MultiLine" Width="391px" Enabled="False"></asp:TextBox>

        <br />
        <br />

        <center> 
            
            <asp:Button ID="btnAlterar" runat="server" Text="Alterar" Width="87px" BorderStyle="None" Height="25px" OnClick="btnAlterar_Click"></asp:Button>

            &nbsp;

            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" BorderStyle="None" Height="25px" Enabled="False" Width="63px" OnClick="btnSalvar_Click"></asp:Button> 

            &nbsp;

            <asp:Button ID="btnExcluir" runat="server" BorderStyle="None" Enabled="False" Text="Excluir" Height="25px" />
&nbsp;<asp:Button ID="btnCancelar" runat="server" Text="Cancelar" BorderStyle="None" Height="25px" Enabled="False" OnClick="btnCancelar_Click" /></asp:Button>
            
            <br />
            <asp:Label ID="lblMensagem" runat="server">**</asp:Label>
            
        </center>

            </div>

    </div>

    </form>

</body>

</html>
