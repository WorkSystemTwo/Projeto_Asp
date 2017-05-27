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

            <h4> HOME </h4> 

        </center>

        <br />

        <div id="h3_menu">

            <li><b> <a href="cadastrarCliente.aspx" target="lado_direito"> Cadastrar Clientes </a></b></li>

        <br />
        <br />

            <li><b> <a href="visualizacaoCliente.aspx" target="lado_direito"> Gerenciar Clientes</a></b></li>

        <br />
        <br />
                    
            <li><b> <a href="cadastroViagem.aspx" target="lado_direito"> Cadastrar Viagem</a></b></li>

        <br />
        <br />

            <li><b> <a href="visualizacaoViagem.aspx" target="lado_direito"> Gerenciar Viagens</a></b></li>

        <br />
        <br />
        
            <li><b> <a href="cadastroPassagem.aspx" target="lado_direito"> Nova Passagem</a></b></li>

        <br />
        <br />

            <li><b> <a href="visualizacaoPassagem.aspx" target="lado_direito"> Visualizar Viagens</a></b></li>
            
        <br />     
            
        </div>                 

     </div>
               

    </form>

</body>

</html>
