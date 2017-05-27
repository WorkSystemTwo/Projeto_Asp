<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="visualizacaoPassagem.aspx.cs" Inherits="Projeto_Asp.visualizacaoPassagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Visualizar Passagens</title>
    <link href="CSS/Style.css" rel="stylesheet" type="text/css" />

</head>

<body>

    <form id="form1" runat="server">

    <div style="height: 534px" id="consulta">

        <center><h4> CONSULTA DE PASSAGEM</h4></center>

        <br/>
        <br/>
                        
        <div id="escritaPagina">

         <center>

        <asp:Label ID="Label6" runat="server" Text="Pesquisar por Código:"></asp:Label>

            &nbsp;

        <asp:TextBox ID="txtPesquisa" runat="server" Width="478px"></asp:TextBox>

        &nbsp;
            
        <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" BorderStyle="None" Height="27px" />

        </center>

            <br />
            <br />

        <asp:Label ID="Label1" runat="server" Text="Código Passagem:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtCodPassagem" runat="server" Width="69px" Enabled="False" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
        <asp:Label ID="Label2" runat="server" Text="Código Viagem:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCodViagem" runat="server" Width="72px" Enabled="False"></asp:TextBox>
        
      
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="CPF:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCpf" runat="server" Width="140px" Enabled="False"></asp:TextBox>

            <br />
            <br />

            <asp:Label ID="Label4" runat="server" Text="Poltrona:"></asp:Label>
&nbsp;<asp:TextBox ID="txtPoltrona" runat="server" Width="83px" Enabled="False"></asp:TextBox>
        
      
        <br />
        <br />
        
      
        <br />
        <center>
        <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" BorderStyle="None" Height="25px" />
        &nbsp;<asp:Button ID="btnSalvar" runat="server" Text="Salvar" Enabled="False" BorderStyle="None" OnClick="btnSalvar_Click" Height="25px"/>&nbsp;
            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" Enabled="False" BorderStyle="None" Height="25px" />&nbsp;
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Enabled="False" BorderStyle="None" OnClick="btnCancelar_Click" Height="25px" />
        &nbsp;
            <br />
            <asp:Label ID="Label5" runat="server">**</asp:Label>
        </center>

            </div>
      
    </div>
    </form>
</body>
</html>
