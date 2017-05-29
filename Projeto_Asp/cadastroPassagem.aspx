<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastroPassagem.aspx.cs" Inherits="Projeto_Asp.cadastroPassagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Venda de Passagem</title>
    <link href="CSS/Style.css" rel="stylesheet" type="text/css" />

</head>

<body>

    <form id="form1" runat="server">

    <div id="cadastro">

        <center><h4>VENDA DE PASSAGENS</h4></center>

        <br />
        <br />

        <div id="escritaPagina">

        <asp:Label ID="Label1" runat="server" Text="Cod Passagem : "></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtIdPassagem" runat="server" ReadOnly="true" Width="65px" Enabled="False"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="Label3" runat="server" Text="Viagem :"></asp:Label>
        &nbsp;
            <asp:DropDownList ID="listViagem" runat="server" Height="21px" Width="308px" Enabled="False">
            </asp:DropDownList>
        <br />
        <br />

        <asp:Label ID="Label4" runat="server" Text="Poltrona : "></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtPoltrona" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="Label6" runat="server" Text="Valor Passagem : "></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtValorPassagem" runat="server" Enabled="False" Width="78px"></asp:TextBox>
            <br />
            <br />
            Informações Viagem:<br />
            <br />
            Origem:
            <asp:Label ID="lblOrigem" runat="server" Text="**"></asp:Label>
            <br />
            Destino:
            <asp:Label ID="lblDestino" runat="server" Text="**"></asp:Label>
            <br />
            Hora Saída:
            <asp:Label ID="lblHora" runat="server" Text="**"></asp:Label>
            <br />
            Data:
            <asp:Label ID="lblData" runat="server" Text="**"></asp:Label>
        <br />
        <br />

        <asp:Label ID="Label2" runat="server" Text="Nome Cliente : " ReadOnly="true"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtNomeCliente" runat="server" Width="316px" Enabled="False"></asp:TextBox>
        &nbsp;
        <asp:Button ID="btnVerificar" runat="server" Text="Verificar Cliente" BorderStyle="None" Height="27px" Visible="False" OnClick="btnVerificar_Click" />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Confirmar CPF : " Visible="False"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtCPF" runat="server" Visible="False" Width="168px" ReadOnly="True"></asp:TextBox>

        <br />
        <br />
        
        <center>

            <asp:Button ID="btnNovo" runat="server" Text="Novo" Width="51px" BorderStyle="None" Height="25px" OnClick="btnNovo_Click"></asp:Button>
            &nbsp;
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Enabled="False" BorderStyle="None" Height="25px" OnClick="btnSalvar_Click"></asp:Button>
            &nbsp;
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Enabled="False" BorderStyle="None" Height="25px" OnClick="btnCancelar_Click"></asp:Button>

            <br />
            <asp:Label ID="lblMensagem" runat="server" Text="**"></asp:Label>

        </center>
        </div>
    
    </div>

    </form>

</body>

</html>
