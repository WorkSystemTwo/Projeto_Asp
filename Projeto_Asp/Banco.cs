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
        public string pesquisa;

        public static SqlConnection conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Thiago_2\Source\Repos\Projeto_Asp\Projeto_Asp\App_Data\BD.mdf;Integrated Security=True");

        //construtor para inserção de CLIENTE
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

        //construtor para inserção de PASSAGEM
        public Banco (int id_viagem, string cpf_cliente, double vlr_passagem, int poltrona, string mensagem)
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

        //construtor para inserção de VIAGEM
        public Banco (string origem, string destino, string data_saida, string hr_saida, string prev_chegada, string obs)
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

        //construtor para exclusão de dados do CLIENTE
        /*public Banco (string cpf)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@cpf", cpf);
            comando.CommandText = "DELETE FROM cliente WHERE cpf=@cpf";
            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        */
        
        //construtor para pesquisa de dados em CLIENTE 
        public void pesquisaCliente (string cpf_cliente, string nome, string celular, string rg, string obs)
        {            

            SqlCommand comando = new SqlCommand();
            SqlDataReader reg = null;
            comando.Connection = conexao;
            comando.CommandText = "SELECT * FROM cliente WHERE nome LIKE '" + pesquisa + "% '";
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
        
        public Banco()
        {

        }    

    }    

}



