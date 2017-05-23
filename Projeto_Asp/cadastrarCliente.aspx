<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastrarCliente.aspx.cs" Inherits="Projeto_Asp.cadastrarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 559px">
    
    &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b> Cadastro Cliente </b><br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="CPF:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCpf" runat="server" Enabled="False" Width="142px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
&nbsp;<asp:TextBox ID="txtNome" runat="server" Enabled="False" Width="387px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="RG:"></asp:Label>
&nbsp;<asp:TextBox ID="txtRg" runat="server" Enabled="False" Width="181px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Celular:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCelular" runat="server" Enabled="False" Width="120px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Obs:"></asp:Label>
&nbsp;<asp:TextBox ID="txtObs" runat="server" Enabled="False" Height="236px" TextMode="MultiLine" Width="432px"></asp:TextBox>
        <br />
        <br />
        <center><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Novo" />

        <asp:Button ID="Button2" runat="server" Text="Salvar" OnClick="Button2_Click" />
&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Cancelar" OnClick="Button3_Click" />
        <asp:Label ID="Label6" runat="server"></asp:Label>
        </center>
        
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
