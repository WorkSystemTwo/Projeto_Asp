using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Projeto_Asp
{
    public class Banco
    {
        //conexao for JP
        public static SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\João Paulo\Source\Repos\Projeto_Asp\Projeto_Asp\App_Data\BD.mdf;Integrated Security=True");
        
        //conexao for Thiago
       // public static SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thiago_2\Source\Repos\Projeto_Asp\Projeto_Asp\App_Data\BD.mdf;Integrated Security=True");
    }

}



