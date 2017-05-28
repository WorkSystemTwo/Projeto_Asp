using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Projeto_Asp
{
    public class Viagem
    {

        public SqlConnection conexao = Banco.conexao;              

        //construtor para insercao de viagens
        public Viagem(string origem, string destino, string data_saida, string hr_saida, string prev_chegada, string obs)
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "INSERT INTO viagem (origem, destino, data_saida, hr_saida, prev_chegada, obs) VALUES (@origem, @destino, @data_saida, @hr_saida, @prev_chegada, @obs)";

            comando.Parameters.AddWithValue("@origem", origem);
            comando.Parameters.AddWithValue("@destino", destino);
            comando.Parameters.AddWithValue("@data_saida", data_saida);
            comando.Parameters.AddWithValue("@hr_saida", hr_saida);
            comando.Parameters.AddWithValue("@prev_chegada", prev_chegada);
            comando.Parameters.AddWithValue("@obs", obs);

            conexao.Open();

            comando.ExecuteNonQuery();

            conexao.Close();

        }

        //método para delete de viagem
        public void exclusaoViagem(string id_viagem)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@id_viagem", id_viagem);
            comando.CommandText = "DELETE FROM viagem WHERE id_viagem=@id_viagem";
            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        
        public Viagem()
        {

        }

    }
}