using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Projeto_Asp
{
    public class Cliente
    {

        public SqlConnection conexao = Banco.conexao;

        public string cpf_cliente, nome, celular, rg, obs;

        //construtor para insert de clientes
        public Cliente(string cpf_cliente, string nome, string celular, string rg, string obs)
        {

            SqlCommand comando = new SqlCommand();

            comando.Connection = conexao;

            comando.CommandText = "INSERT INTO cliente (cpf_cliente, nome, celular, rg, obs) VALUES (@cpf_cliente, @nome, @celular, @rg, @obs)";

            comando.Parameters.AddWithValue("@cpf_cliente", cpf_cliente);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@celular", celular);
            comando.Parameters.AddWithValue("@rg", rg);
            comando.Parameters.AddWithValue("@obs", obs);

            conexao.Open();

            comando.ExecuteNonQuery();

            conexao.Close();

        }

        //metodo para pesquisa
        public void pesquisaCliente(string pesquisa)
        {
            SqlCommand comando = new SqlCommand();
            SqlDataReader reg = null;
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM cliente WHERE nome LIKE '" + pesquisa + "%'";
            conexao.Open();
            reg = comando.ExecuteReader();

            if (reg.Read())
            {
                cpf_cliente = reg["cpf_cliente"].ToString();
                nome = reg["nome"].ToString();
                celular = reg["celular"].ToString();
                rg = reg["rg"].ToString();
                obs = reg["obs"].ToString();
            }

            conexao.Close();
        }

        //método para exclusão de clientes
        public void exclusaoCliente(string cpf)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@cpf", cpf);
            comando.CommandText = "DELETE FROM cliente WHERE cpf_cliente=@cpf";
            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        //construtor default
        public Cliente()
        {

        }


    }
}