<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="visualizacaoPassagem.aspx.cs" Inherits="Projeto_Asp.visualizacaoPassagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 534px">
    <br/>
        <br/>
        <center><h3> Consulta Passagem</h3></center>
        <br/>
        
        <asp:Label ID="Label1" runat="server" Text="Cód Passagem:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtCodPassagem" runat="server" Width="69px" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Cód Viagem:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCodViagem" runat="server" Width="72px" Enabled="False"></asp:TextBox>
        
      
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="CPF:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCpf" runat="server" Width="140px" Enabled="False"></asp:TextBox>
&nbsp;<asp:Label ID="Label4" runat="server" Text="Poltrona:"></asp:Label>
&nbsp;<asp:TextBox ID="txtPoltrona" runat="server" Width="83px" Enabled="False"></asp:TextBox>
        
      
        <br />
        <br />
        
      
        <br />
        <center>
        <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" BorderStyle="None" />
        &nbsp;<asp:Button ID="btnSalvar" runat="server" Text="Salvar" Enabled="False" BorderStyle="None" OnClick="btnSalvar_Click" />&nbsp;
            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" Enabled="False" BorderStyle="None" />&nbsp;
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Enabled="False" BorderStyle="None" OnClick="btnCancelar_Click" />
        &nbsp;<asp:Label ID="Label5" runat="server"></asp:Label>
        </center>
      
    </div>
    </form>
</body>
</html>
