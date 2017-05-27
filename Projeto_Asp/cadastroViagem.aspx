<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastroViagem.aspx.cs" Inherits="Projeto_Asp.cadastroViagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Cadastro de Viagem</title>

    <link href="CSS/Style.css" rel="stylesheet" type="text/css" />

</head>

<body>

    <form id="form1" runat="server">

    <div id="cadastro">
    
            <center><h4> CADASTRAR VIAGEM</h4></center>

        <br />
        <br />

        <div id="escritaPagina">

        <asp:Label ID="Label1" runat="server" Text="ID Viagem : "></asp:Label>
        <asp:TextBox ID="txtIdViagem" runat="server" ReadOnly="True" Width="108px"></asp:TextBox>
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
            
            <asp:Button ID="btnNovo" runat="server" Text="Novo" Width="87px" BorderStyle="None" Height="25px" OnClick="btnNovo_Click"></asp:Button>

            &nbsp;

            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" BorderStyle="None" Height="25px" Enabled="False" OnClick="btnCadastrar_Click"></asp:Button> 

            &nbsp;

            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" BorderStyle="None" Height="25px" Enabled="False" OnClick="btnCancelar_Click" /></asp:Button>
            
            <br />

            <asp:Label ID="lblMensagem" runat="server" Text="**"></asp:Label>
            
        </center>

        </div>

    </div>

    </form>

</body>

</html>
