<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="visualizacaoCliente.aspx.cs" Inherits="Projeto_Asp.visualizacaoCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 438px">
    
        <center><h3>Consulta Cliente</h3></center>
        
       <center> <asp:Label ID="Label2" runat="server" Text="Pesquisa por nome:"></asp:Label>
         &nbsp;<asp:TextBox ID="txtPesquisaNome" runat="server" Width="478px"></asp:TextBox>&nbsp;
           <asp:Button ID="Button1" runat="server" Text="Pesquisar" />
        </center>
       
        <br />
        <br />
        
        <asp:Label ID="Label3" runat="server" Text="CPF:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="133px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Nome:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" Width="387px"></asp:TextBox>
&nbsp;<asp:Label ID="Label5" runat="server" Text="RG:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server" Width="181px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Celular:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox4" runat="server" Width="120px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Obs:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox5" runat="server" Height="175px" TextMode="MultiLine" Width="418px"></asp:TextBox>
        <br />
        
    </div>
    </form>
</body>
</html>
