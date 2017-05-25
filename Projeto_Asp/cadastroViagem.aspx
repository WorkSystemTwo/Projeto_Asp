﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastroViagem.aspx.cs" Inherits="Projeto_Asp.cadastroViagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Cadastro de Viagem</title>

</head>

<body>

    <form id="form1" runat="server">

    <div>
    
            <center><h3> Cadastro de Viagem </h3></center>

        <br />
        <br />
        <br />

        <asp:Label ID="Label1" runat="server" Text="ID Viagem : "></asp:Label>
        <asp:TextBox ID="txtIdViagem" runat="server" ReadOnly="True" Width="108px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Cidade Origem : "></asp:Label>
        <asp:TextBox ID="txtOrigem" runat="server" Width="226px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Cidade Destino : "></asp:Label>
        <asp:TextBox ID="txtDestino" runat="server" Width="225px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Data Viagem : "></asp:Label>
        <asp:TextBox ID="txtData" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Hora Viagem : "></asp:Label>
        <asp:TextBox ID="txtHora" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Previsão Chegada : "></asp:Label>
        <asp:TextBox ID="txtPrevChegada" runat="server" Width="135px"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Observação : "></asp:Label>
        <asp:TextBox ID="txtObs" runat="server" Height="95px" TextMode="MultiLine" Width="391px"></asp:TextBox>

        <center> 
            
            <asp:Button ID="btnNovo" runat="server" Text="Novo" Width="87px"></asp:Button>

            &nbsp;

            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar"></asp:Button> 
            
        </center>

    </div>

    </form>

</body>

</html>
