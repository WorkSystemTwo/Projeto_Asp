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

        public static SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\João Paulo\Source\Repos\Projeto_Asp\Projeto_Asp\App_Data\BD.mdf;Integrated Security=True");

        //construtor para inserção de cliente
        public Banco (string cpf_cliente, string nome, string celular, string rg, string obs)
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

        //construtor para inserção de passagem
        public Banco (int id_passagem, int id_viagem, string cpf_cliente, double vlr_passagem, int poltrona, string mensagem)
        {

            SqlCommand comando = new SqlCommand();

            comando.Connection = conexao;

            comando.CommandText = "INSERT INTO passagem (id_passagem, id_viagem, cpf_cliente, vlr_passagem, poltrona) VALUES (@id_passagem, @id_viagem, @cpf_cliente, @vlr_passagem, @poltrona";

            comando.Parameters.AddWithValue("@id_passagem", id_passagem);
            comando.Parameters.AddWithValue("@id_viagem", id_viagem);
            comando.Parameters.AddWithValue("@cpf_cliente", cpf_cliente);
            comando.Parameters.AddWithValue("@vlr_passagem", vlr_passagem);
            comando.Parameters.AddWithValue("@poltrona", poltrona);

            conexao.Open();

            comando.ExecuteNonQuery();

            conexao.Close();

        }

        //construtor para inserção de viagem
        public Banco (int id_viagem, string origem, string destino, string data_saida, string hr_saida, string prev_chegada, string obs)
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "INSERT INTO viagem (id_viagem, origem, destino, data_saida, hr_saida, prev_chegada, obs) VALUES (@id_viagem, @origem, @destino, @data_saida, @hr_saida, @prev_chegada, @obs)";

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



