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

        public string id_viagem, origem, destino, data_saida, hr_saida, prev_chegada, obs;              

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

        //método para exclusao de viagem
        public void exclusaoViagem(string id_viagem)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "DELETE FROM viagem WHERE id_viagem=@id_viagem";
            comando.Parameters.AddWithValue("@id_viagem", id_viagem);

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();           
        }

        //método para pesquisa por CidadeOrigem
        public void selectCidadeOrigem(string pesquisa)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@origem", pesquisa);
            SqlDataReader reg = null;
            comando.CommandText = "SELECT * FROM viagem WHERE origem LIKE '" + pesquisa + "%'";
            conexao.Open();
            reg = comando.ExecuteReader();

            if (reg.Read())
            {
                id_viagem = reg["id_viagem"].ToString();
                origem = reg["origem"].ToString();
                destino = reg["destino"].ToString();
                data_saida = reg["data_saida"].ToString();
                hr_saida = reg["hr_saida"].ToString();
                prev_chegada = reg["prev_chegada"].ToString();
                obs = reg["obs"].ToString();
            }
                        
            conexao.Close();
        }

        //método para pesquisa por IDViagem
        public void selectIDViagem(string pesquisa)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@id_viagem", pesquisa);
            SqlDataReader reg = null;
            comando.CommandText = "SELECT * FROM viagem WHERE id_viagem LIKE '" + pesquisa + "%'";
            conexao.Open();
            reg = comando.ExecuteReader();

            if (reg.Read())
            {
                id_viagem = reg["id_viagem"].ToString();
                origem = reg["origem"].ToString();
                destino = reg["destino"].ToString();
                data_saida = reg["data_saida"].ToString();
                hr_saida = reg["hr_saida"].ToString();
                prev_chegada = reg["prev_chegada"].ToString();
                obs = reg["obs"].ToString();
            }

            conexao.Close();
        }

        //método para pesquisa por CidadeDestino
        public void selectCidadeDestino(string pesquisa)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@destino", pesquisa);
            SqlDataReader reg = null;
            comando.CommandText = "SELECT * FROM viagem WHERE destino LIKE '" + pesquisa + "%'";
            conexao.Open();
            reg = comando.ExecuteReader();

            if (reg.Read())
            {
                id_viagem = reg["id_viagem"].ToString();
                origem = reg["origem"].ToString();
                destino = reg["destino"].ToString();
                data_saida = reg["data_saida"].ToString();
                hr_saida = reg["hr_saida"].ToString();
                prev_chegada = reg["prev_chegada"].ToString();
                obs = reg["obs"].ToString();
            }

            conexao.Close();
        }
        
        //construtor default
        public Viagem()
        {

        }

        //método para alterar dados viagem
        public void updateViagem(int id_viagem, string origem, string destino, DateTime data_saida, DateTime hr_saida, DateTime prev_chegada, string obs)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "UPDATE viagem SET origem=@origem, destino=@destino, data_saida=@data_saida, hr_saida=@hr_saida, prev_chegada=@prev_chegada, obs=@obs WHERE id_viagem=@id_viagem";

            comando.Parameters.AddWithValue("@id_viagem", id_viagem);
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

    }
}