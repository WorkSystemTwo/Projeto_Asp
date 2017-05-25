<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastroPassagem.aspx.cs" Inherits="Projeto_Asp.cadastroPassagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Venda de Passagem</title>

</head>

<body>

    <form id="form1" runat="server">

    <div>

        <center><h3>VENDA DE PASSAGENS</h3></center>

        <br />
        <br />
        <br />

        <asp:Label ID="Label1" runat="server" Text="Cod Passagem : "></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtIdPassagem" runat="server" ReadOnly="true" Width="65px"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="Label3" runat="server" Text="Viagem :"></asp:Label>
        &nbsp;
        <asp:ListBox ID="listViagem" runat="server" Height="25px" Width="278px" Enabled="False"></asp:ListBox>
        <br />
        <br />

        <asp:Label ID="Label4" runat="server" Text="Poltrona : "></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtPoltrona" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="Label2" runat="server" Text="Nome Cliente : " ReadOnly="true"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtNomeCliente" runat="server" ReadOnly="true" Width="316px" Enabled="False"></asp:TextBox>
        &nbsp;
        <asp:Button ID="btnVerificar" runat="server" Text="Verificar" />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Confirmar CPF : " Visible="False"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtCPF" runat="server" Enabled="False" Visible="False" Width="168px"></asp:TextBox>

        <br />
        <br />
        
        <center>

            <asp:Button ID="btnNovo" runat="server" Text="Novo" Width="51px"></asp:Button>
            &nbsp;
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Enabled="False"></asp:Button>
            &nbsp;
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Enabled="False"></asp:Button>

        </center>

    
    </div>

    </form>

</body>

</html>
