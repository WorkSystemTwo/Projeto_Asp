<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="visualizacaoViagem.aspx.cs" Inherits="Projeto_Asp.visualizacaoViagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Gerenciar Viagem</title>

</head>

<body>

    <form id="form1" runat="server">

    <div>
    
            <center> <h3> GERENCIAR VIAGEM</h3></center>

            <br />
            <br />
            <br />

        <b>
        <asp:Label ID="Label8" runat="server" Text="Pesquisa por Nome:"></asp:Label>
         &nbsp;
        <asp:TextBox ID="txtPesquisa" runat="server" Width="406px"></asp:TextBox>
         &nbsp;
        <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" BorderStyle="None" Height="28px" />
        </b>

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
            
            <asp:Button ID="btnAlterar" runat="server" Text="Alterar" Width="87px" BorderStyle="None" Height="25px"></asp:Button>

            &nbsp;

            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" BorderStyle="None" Height="25px" Enabled="False" Width="63px"></asp:Button> 

            &nbsp;

            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" BorderStyle="None" Height="25px" Enabled="False" /></asp:Button>
            
        </center>

    </div>

    </form>

</body>

</html>
