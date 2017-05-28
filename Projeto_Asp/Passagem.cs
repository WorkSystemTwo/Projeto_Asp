using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Projeto_Asp
{
    public class Passagem
    {

        public SqlConnection conexao = Banco.conexao;

        public string id_passagem, id_viagem, cpf_cliente, vlr_passagem, poltrona;        

        //construtor para insercao de passagens
        public Passagem(int id_viagem, string cpf_cliente, double vlr_passagem, int poltrona)
        {

            SqlCommand comando = new SqlCommand();

            comando.Connection = conexao;

            comando.CommandText = "INSERT INTO passagem (id_viagem, cpf_cliente, vlr_passagem, poltrona) VALUES (@id_viagem, @cpf_cliente, @vlr_passagem, @poltrona";

            comando.Parameters.AddWithValue("@id_viagem", id_viagem);
            comando.Parameters.AddWithValue("@cpf_cliente", cpf_cliente);
            comando.Parameters.AddWithValue("@vlr_passagem", vlr_passagem);
            comando.Parameters.AddWithValue("@poltrona", poltrona);

            conexao.Open();

            comando.ExecuteNonQuery();

            conexao.Close();

        }

        //método para pesquisa por ID Viagem
        public void pesquisaIdViagem(string pesquisa)
        {
            SqlCommand comando = new SqlCommand();
            SqlDataReader reg = null;
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM passagem WHERE id_passagem LIKE '" + pesquisa + "%'";
            conexao.Open();
            reg = comando.ExecuteReader();
            if (reg.Read())
            {
                id_passagem = reg["id_passagem"].ToString();
                id_viagem = reg["id_viagem"].ToString();
                cpf_cliente = reg["cpf_cliente"].ToString();
                vlr_passagem = reg["vlr_passagem"].ToString();
                poltrona = reg["poltrona"].ToString();
            }

            conexao.Close();
        }

        //método para pesquisa por CPF Cliente
        public void pesquisaCPFCliente(string pesquisa)
        {
            SqlCommand comando = new SqlCommand();
            SqlDataReader reg = null;
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM passagem WHERE cpf_cliente LIKE '" + pesquisa + "%'";
            conexao.Open();
            reg = comando.ExecuteReader();
            if (reg.Read())
            {
                id_passagem = reg["id_passagem"].ToString();
                id_viagem = reg["id_viagem"].ToString();
                cpf_cliente = reg["cpf_cliente"].ToString();
                vlr_passagem = reg["vlr_passagem"].ToString();
                poltrona = reg["poltrona"].ToString();
            }

            conexao.Close();
        }

        //método para exclusao de passagens
        public void exclusaoPassagem(string id_passagem)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@id_passagem", id_passagem);
            comando.CommandText = "DELETE FROM passagem WHERE id_passagem=@id_passagem";
            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        //construtor default
        public Passagem()
        {

        }

    }
}