<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastrarCliente.aspx.cs" Inherits="Projeto_Asp.cadastrarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Cadastro de Clientes</title>

    <link href="CSS/Style.css" type="text/css" rel="stylesheet" />
    
</head>

<body>

    <form id="form1" runat="server">

    <div id="cadastro">

        <center><h4> CADASTRO DE CLIENTES</h4><br /></center>

        <br />

        <div id="escritaPagina">

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
                &nbsp;<asp:TextBox ID="txtObs" runat="server" Enabled="False" Height="164px" TextMode="MultiLine" Width="432px"></asp:TextBox>
                <br />
                <br />

                <center>
            
                        <asp:Button ID="btnNovo" runat="server" OnClick="Button1_Click" Text="Novo" BorderStyle="None" Height="25px" Width="48px" />&nbsp;

                        &nbsp;<asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="Button2_Click" BorderStyle="None" Height="25px" Width="51px" Enabled="False" />&nbsp;
                        &nbsp;<asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="Button3_Click" BorderStyle="None" Height="25px" Enabled="False" />
                        &nbsp;
                        <br />

                        <asp:Label ID="lblMensagem" runat="server">**</asp:Label>

                </center>

        </div>
        
        <br />
        <br />
    
    </div>

    </form>

</body>

</html>
