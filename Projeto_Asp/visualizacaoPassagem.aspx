<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="visualizacaoPassagem.aspx.cs" Inherits="Projeto_Asp.cadastroPassagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 475px">
    <form id="form1" runat="server">
    <div style="height: 466px">
    <br>
        <center><h3>Consulta Passagem</h3></center>
        <center>
        <asp:Label ID="Label13" runat="server" Text="Nº Passagem:"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox4" runat="server" Width="478px"></asp:TextBox>
        <asp:Button ID="btnPesquisarNome" runat="server" Text="Pesquisar" />
            </center>
        <br>
       
        
       
       <p>&nbsp; <asp:Label ID="Label9" runat="server" Text="Cód Passagem:"></asp:Label>&nbsp;<asp:TextBox ID="txtCodPassagem" runat="server" Width="86px" Enabled="False"></asp:TextBox>
        &nbsp; <asp:Label ID="Label10" runat="server" Text="Cód Viagem:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCodViagem" runat="server" Width="94px" Enabled="False"></asp:TextBox>
        </p>
        <p>
             &nbsp;
             <asp:Label ID="Label11" runat="server" Text="CPF: "></asp:Label>
             <asp:TextBox ID="txtCpf" runat="server" Width="149px" Enabled="False"></asp:TextBox>
        &nbsp;
             <asp:Label ID="Label12" runat="server" Text="Poltrona:"></asp:Label>
&nbsp;<asp:TextBox ID="txtPoltrona" runat="server" Enabled="False"></asp:TextBox>
 
    <br>
            <br>

            <center> 
            <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />&nbsp;
             <asp:Button ID="btnSalvar" runat="server" Text="Salvar" />&nbsp;
             <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                </center>
    </div>
    </form>
</body>
</html>