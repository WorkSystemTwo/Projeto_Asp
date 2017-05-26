<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Projeto_Asp.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>HOME - AGÊNCIA VIAGEM</title>
    <link href="CSS/Style.css" rel="stylesheet" type="text/css">

</head>

<body>

    <form id="form1" runat="server">

    <div id="menu">
        
        <center> 

            <h4> MENU </h4> 

        </center>

        <br />

        <div id="h3_menu">

            <b> <a href="cadastrarCliente.aspx"> Cadastrar Clientes </a></b>

        <br />
        <br />

            <b> <a href="visualizacaoCliente.aspx"> Gerenciar Clientes</a></b>

        <br />
        <br />
                    
            <b> <a href="cadastroViagem.aspx"> Cadastrar Viagem</a></b>

        <br />
        <br />

            <b> <a href="visualizacaoViagem.aspx"> Gerenciar Viagens</a></b>

        <br />
        <br />
        
            <b> <a href="cadastroPassagem.aspx"> Nova Passagem</a></b>

        <br />
        <br />

            <b> <a href="visualizacaoPassagem.aspx"> Visualizar Viagens</a></b>
            
        <br />     
            
        </div>                 

     </div>
               

    </form>

</body>

</html>
